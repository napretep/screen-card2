module app.common.storageTypes
open Chrome
open Elmish.React
open app.common.funcs
open app.common.obj
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Browser.Dom

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

    
  type Card={
    Id:string
    majorKind:SaveKind
    createTime:float //时间戳
    editTime:float //时间戳
    fields:CardField array
    pin:float // 0 page 1 screen 2 tab
    position:float*float //x,y
    size:float*float
  }

  // type CardLib = {
  //   majorKind:SaveKind
  //   Id:string
  //   pin:PinKind
  //   searchString:string
  //   position:float*float //x,y
  //   size:float*float
  //   cards:Card array
  // }
  // with
  //   static member init =
  //     {
  //         majorKind=SaveKind.CardLib
  //         Id=SaveKind.CardLib.S
  //         pin=Page
  //         searchString=""
  //         position=(200,200) //x,y
  //         size=(600,400)
  //         cards=[||]
  //     }
  type CardLib ={
    cards:Card array
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

///除了read是必须用promise 其他的不用
type DataStorage =
    static member getString (keys:SaveKind array)=
      keys |> Seq.map (fun key -> key.S )|>Seq.toArray |> ResizeArray<string>
      
    //read 是异步的  
    static member read(key: string array) =
          chromeStorage.local.get(ResizeArray key)
    static member readAll = chromeStorage.local.get()
    static member set (key:string) value =
      chromeStorage.local.set (kv key value)

    static member del (key:string) =
      chromeStorage.local.remove (U2.Case1 key)
      
    static member delMany (key: string array) =
      chromeStorage.local.remove (U2.Case2 (ResizeArray key))
      
      
    static member clear = chromeStorage.local.clear ()

// type Continuation =
    
    // static member test (?key, ?callback)=
    //     let callback = defaultArg callback (fun e->window.alert e)
    //     let key = defaultArg key MajorKind.Count 
    //     let realkey = match key with
    //     |MajorKind.Id s ->s
    //     |_ -> key.ToString()
    //     DataStorage.read([|key|]).``then``(fun e->
    //     let mutable value =0
    //     if e.[key].IsSome then
    //         value <- unbox int e.[realkey].Value + 1
    //     callback value
    //     DataStorage.set key value
    // ) 
