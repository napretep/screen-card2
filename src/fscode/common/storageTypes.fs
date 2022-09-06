module app.common.storageTypes
open System
open Chrome
open Chrome.Chrome
open app.common.funcs
open app.common.obj

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Dom
open Fetch



type  [<StringEnum>] StorageName=
  |TravelCards
  |CardLib //保存了全部的卡片信息, 从中删除就是全部删除
  with
    member this.S= this.ToString()


[<RequireQualifiedAccess>]
type [<StringEnum>] SaveKind =
  |Card
  |CardField
  |CardLib
  |CommonState
  |Count
  with
    member this.S =  this.ToString()
type [<StringEnum>] CardFieldContentKind = |Sentence |Picture
type [<StringEnum>] PinKind = |Page |Screen |Tab
let kv (k: string) v : obj = createObj [ $"{k}" ==> v ]
//扁平化存储, 这个对异步操作要求太高,不太合适,下次再做,
//下面做的是一次性读取方案
[<RequireQualifiedAccess>]
module Save=

  type CardField ={
    majorKind:SaveKind
    contentKind:float // 0 text 1 image
    content:string //如果是image, 则是dataurl
    url:string
    webScrollTo:float*float
    createTime:float //时间戳
    editTime:float //时间戳
    Id :string  
  }


  // type CardNeedDisplay={
  //   mutable transTab:string list
  //   mutable relateTab:string list
  // }
  // with
  //   static member init ={
  //     transTab = []
  //     relateTab = []
  //   } 
  
  type Card={
    mutable Id:string
    mutable homeUrl:string
    mutable birthUrl:string
    mutable webScrollTo:float*float
    mutable majorKind:SaveKind
    mutable createTime:float //时间戳
    mutable editTime:float //时间戳
    mutable fields:CardField array
    mutable pin:float // 0 page 1 screen 2 tab
    mutable position:float*float //x,y 是client bounding rect 的位置
    mutable size:float*float
    mutable show:bool//关闭后通常不会show
    mutable mini:bool//缩小在最右侧
  }
  

  type CardLib ={
    card_ids:string array
  }
  type CommonState={
    Id:SaveKind
    majorKind:SaveKind
    assistDotShow:bool
    cardLibShow:bool
    accompanyCards:Card array
    jumpByFieldId:CardField option
  }
  with
    static member init =
      {
        Id=SaveKind.CommonState
        majorKind=SaveKind.CommonState
        assistDotShow=true
        cardLibShow=false
        accompanyCards=[||]
        jumpByFieldId=None
      }
[<RequireQualifiedAccess>]
type  AllowStoreType=
  |String' of string
  |Array' of Array
  |Number of float
  |Bool of bool
  |NoneAble of option<obj>
  |Card of Save.Card
  
///除了read是必须用promise 其他的不用
type DataStorage =
    static member getString (keys:SaveKind array)=
      keys |> Seq.map (fun key -> key.S )|>Seq.toArray |> ResizeArray<string>
    static member read(key: string array) =
          chromeStorage.local.get(ResizeArray key)
    static member set (key:string) (value:AllowStoreType) =
      console.log value, thisTime.toLocaleString()
      match value with
      |AllowStoreType.Array' value' -> chromeStorage.local.set(kv key value')    
      |AllowStoreType.String' value' -> chromeStorage.local.set(kv key value')    
      |AllowStoreType.Bool value' -> chromeStorage.local.set(kv key value')    
      |AllowStoreType.Number value' -> chromeStorage.local.set(kv key value')    
      |AllowStoreType.Card value' -> chromeStorage.local.set(kv key (value':>obj))    
      |AllowStoreType.NoneAble value' -> chromeStorage.local.set(kv key (
        match value' with
        |Some v -> v
        |None -> undefined
        ))    
      
    static member appendToListUnique (key:string) (values:obj array)=
      promise {
        let! maybeData = chromeStorage.local.get(ResizeArray[key])
        let  oldData = maybeData.[key]
                          |>Option.map (fun (d)->
                              d:?>obj array |> Seq.toList
                            )
                          |>Option.defaultValue []
        let result =  (values |>Seq.fold (fun (sum:obj list) value ->
                                  if oldData|>List.contains value|> not then
                                    value::sum
                                  else
                                    sum
                                  ) oldData )
        DataStorage.set key (AllowStoreType.Array' (result|>Seq.toArray))
        
      }
      //
      // chromeStorage.local.get(ResizeArray[key]).``then``(
      //   fun data->
      //       let result =
      //         console.log data
      //         let newData = data.[key]
      //                     |>Option.map (fun (d)->
      //                         d:?>obj array |> Seq.toList
      //                       )
      //                     |>Option.defaultValue [] 
      //         values|>Seq.fold (fun (sum:obj list) value ->
      //                             if newData|>List.contains value|> not then
      //                               value::sum
      //                             else
      //                               sum
      //                             ) [] 
      //                           
      //       DataStorage.set key (AllowStoreType.Array' (result|>Seq.toArray))
      //   ) 

    
    //读取DB中的list, 并去掉指定的元素
    static member removeFromList (key:string) (values:obj array ) =
      
      DataStorage.read([|key|]).``then``(
        fun maybeData ->
          let data =
            match maybeData[key] with
            |Some d-> d:?> string array
            |_ -> [||]
          let newData = data |>Seq.filter (fun e-> values|>Seq.contains e |> not )|>Seq.toArray 
          DataStorage.set key (AllowStoreType.Array' newData)
      )
      
    static member moveFromAToBList (A:string) (B:string) (value':string array) =
      let value =unbox<obj array> value'
      DataStorage.removeFromList A value 
      DataStorage.appendToListUnique B value
      
       
    static member readAll = chromeStorage.local.get()

    static member del (key:string) =
      chromeStorage.local.remove (U2.Case1 key)
      
    static member delMany (key: string array) =
      chromeStorage.local.remove (U2.Case2 (ResizeArray key))
    static member readCardLibReturnId =
      DataStorage.read([|CardLib.S|]).``then``(
        fun maybeData->
          maybeData[CardLib.S]|>Option.map (fun data'->
            let data = data':?>string array
            data
            )|>Option.defaultValue [||]
      )
    static member readCardLibReturnCard=
      promise {
        let! ids= DataStorage.readCardLibReturnId
        let! cards = DataStorage.readCards(ids)
        return cards
      }
    static member readTravelCardIds =
      DataStorage.read([|TravelCards.S|]).``then``(
        fun maybeData->
          console.log ("static member readTravelCards")
          console.log maybeData
          maybeData[TravelCards.S]|>Option.map (fun data'->
            let data = data':?>string array
            data
            )|>Option.defaultValue [||]
        )
    static member readCards (card_ids:string array) :Promise<seq<Save.Card>> =
      promise {
        let! maybeCards = DataStorage.read(card_ids)
        // cards<-unbox<seq<Save.Card>>(card_ids|>Seq.filter(fun card_id-> maybeCards[card_id].IsSome))
        return card_ids
        |>Seq.map (fun card_id->unbox<Save.Card option>maybeCards[card_id])
        |>Seq.filter(fun maybeCard->maybeCard.IsSome)
        |>Seq.map (fun card->card.Value)
      }
      // cards
      // DataStorage.read(card_ids).``then``(
      //   fun maybeData ->
      //   card_ids|>Seq.filter(fun card_id-> maybeData[card_id].IsSome)
      //           |>Seq.map (fun card_id->maybeData[card_id].Value:?>Save.Card)
      // )
    static member readCardIdsFromUrl (url:string)=
      DataStorage.read([|url|]).``then``(
          fun maybe'->
            let data =( maybe'[url]|>Option.defaultValue [||]  ):?>string array
            data
        )
    static member clear = chromeStorage.local.clear ()
    static member readCardLib =
      promise {
        let! x= DataStorage.read [|CardLib.S|]
        let cardLib =unbox<string array option>x.[CardLib.S]
        return cardLib|>Option.defaultValue [||]
      }
    static member removeCardsFromCardLib (card_ids:string array)=
      DataStorage.delMany(card_ids).``then``(
        fun e->  DataStorage.removeFromList CardLib.S (card_ids|>Seq.map(fun e->e:>obj)|>Seq.toArray)
        )
    static member appendCardToCardLib (card_id) =
      promise{
         let! a= DataStorage.appendToListUnique CardLib.S card_id
        
         let! b= DataStorage.readCardLib
         
         return b
      }
    static member getHomeUrlCards (url:string )=
      promise{
        let! card_ids = DataStorage.readCardIdsFromUrl url
        let! cards = DataStorage.readCards(card_ids)
        return cards 
      }