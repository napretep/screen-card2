module app.components.cardLibrary
open System
open app.common
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open app.common.globalTypes
open app.common.storageTypes
open app.components.cardTemplate
open Browser.Types
open Browser
open Fable.Core
open FSharp.Control
open app.components.tooltip

module CardLib =
  type [<StringEnum>]  Msg = |None|Close
  type Event =
    {Close : Event<unit>}
    with
     static member init =
       {
        Close =  Event<unit>()
        }
  type State={
    mutable IsShow:bool 
    mutable rect:Rect
  }
  let state = {
    IsShow =false
    rect = Rect.set 100 200 300 300
  }
  
  let cardItem img text =
    Div [Id CardLib_card_item;] [
      Div [Id CardLib_card_content;classes [Common_glass]] [
        Img [Src img  ] []
        Span [InnerText text] []
      ]
      Div [Id CardLib_card_btns;
           ] [
        mkBtn ICON.trashBin CardField_btns_del "删除卡片" "l"
        mkBtn ICON.expand CardField_btns_expand "打开卡片" "l"
        mkBtn ICON.backlink  CardLib_card_btns_backlink "溯源卡片" "l"

      ]
  ]
  let testCard = cardItem "https://freefrontend.com/assets/img/css-glassmorphism/2021-feedback-modal-design.jpg" "1231231231 aa a a a a a"
  let atom =
    Div [ classes  [ Common_component]
          CSSPosition ("100px","400px")
          Id CardLib_carrier
    ] [
      Div [ Id CardLib_self
            classes<| [Common_glass]
      ] [
        Div [ Id CardLib_toolbar
              classes<| [Common_glass]
        ] [
          Span [ Id CardLib_toolbar_left
          ] [
            Input [ Id CardLib_searchInput
                    classes<| [Common_glass;Common_btn]
                    PlaceHolder "search"
            ] []
            Span [ classes<| [Common_glass;Common_btn]
                   InnerHtml <| ICON.search []
            ] []
          ]
          Span [classes<| [Common_glass;Common_btn;Common_moveBar]
                Id CardLib_moveBar
                InnerHtml <| ICON.HorizontalMoveBar
          ] []
          Span [Id CardLib_toolbar_right ] [
            mkBtn ICON.refresh CardLib_card_btns_refresh "刷新卡片" "t"
            // Span [classes [Common_glass;Common_btn]
            //       InnerHtml <| ICON.pin
            //       Id CardLib_toolbar_right_pin
            //       ] []
            mkBtn  ICON.close CardLib_toolbar_right_close "关闭卡片库" "t"
            // Span [classes [Common_glass;Common_btn]
            //       InnerHtml <| ICON.close
            //       Id CardLib_toolbar_right_close
            //       ] []
          ]
        ]
        Div [Id CardLib_container; classes [Common_glass]] [

        ]
      ]
    ]
  let view = build atom
  
  // module method =
  //   let hide () = view.element.Value.remove()
  //   let show () =  view.element.Value
    
  type Core(env:GlobalCore,view:Brick,Id:string) as this=
    inherit ICore(view,Id,SaveKind.CardLib)
    member val env=env
    member val state = state with get,set
    member val event = Event.init with get,set
    member val op_view = Op_View(this)
    member val body = view.hashmap[CardLib_container.S]
    
  and Op_View (env:Core) =
    member val env=env
    member this.hide =
      this.cleanItem
      this.env.view.element.Value.remove()
      this.env.state.IsShow<-false
    member this.cleanItem =
      console.log"clean item"
      let body = this.env.body.element.Value
      [for i=0 to body.children.length-1 do body.children[i] ]
      |>Seq.iter(fun el-> el.remove())
        // body.children[i].remove()
    
    member this.loadItem=
      promise{
        let! cards = DataStorage.readCardLibReturnCard
        console.log " member this.loadItem="
        console.log (cards|>Seq.toArray)
        cards
        |>Seq.map this.initItem
        |>Seq.iter (fun e-> env.body.element.Value.appendChild e.element.Value|>ignore)
      }
      
        
    member this.delayReload =
      JS.setTimeout (fun e->
        this.cleanItem
        this.loadItem|>ignore) 200
      
      
    member this.show=
      this.cleanItem
      promise{
        let! x= this.loadItem
        this.env.env.root.appendChild this.env.view.element.Value
        this.env.state.IsShow<-true 
      }
      
    //包括了brick和event
    member this.initItem (card:Save.Card) :Brick =
      console.log card
      let body = this.env.view.hashmap[CardLib_container.S].element.Value
      let text,img = 
          match card.fields.Length with
          |0->
            card.homeUrl,""
          |_->
            let result:Save.CardField option=
              card.fields|>Array.filter (fun e-> e.contentKind=0)|>Array.toList|>List.tryHead
            let text = result|>Option.map (fun e-> e.content) |> Option.defaultValue card.homeUrl
            let imgResult:Save.CardField option =
              card.fields|>Array.filter (fun e-> e.contentKind=1)|>Array.toList|>List.tryHead
            let img = result|>Option.map (fun e-> e.content) |> Option.defaultValue ""
            text,img
      let brick = build (cardItem img text)
      brick.Id<-card.Id
      body.appendChild brick.element.Value|>ignore
      let del = brick.hashmap[CardField_btns_del.S].element.Value
      let get = brick.hashmap[CardField_btns_expand.S].element.Value
      del.onclick <- fun e->
        DataStorage.removeCardsFromCardLib([|card.Id|]).``then``(
          fun e->
            this.delayReload
            this.env.env.event.updateCards.Trigger(card.Id)|>ignore
            this.env.env.removeMember card.Id
         )|>ignore
        
      get.onclick<-fun e->
        DataStorage.readCards([|card.Id|]).``then``(
            fun cards->cards|>Seq.iter (fun (e:Save.Card)-> Card.load this.env.env {e with show=true} |>ignore)
          )|>ignore
      brick
      
  let Init (env:GlobalCore) (p:pointF) =
    let core = Core(
      env = env,
      view = view,
      Id=CardLib_self.S
      )
    let moveBar = view.hashmap[CardLib_moveBar.S].element.Value
    let body = core.body.element.Value
    let refresh = view.hashmap[CardLib_card_btns_refresh.S].element.Value
    let close = view.hashmap[CardLib_toolbar_right_close.S].element.Value
    refresh.onclick <- fun e->
      core.op_view.delayReload
      ()
      
    close.onclick <- fun e->
      core.op_view.hide 
    moveBar.onmousedown<-fun e->
      let root =core.view.element.Value
      let oldEP = pointF.fromElementBounding root
      let oldMP = pointF.fromMouseEvent e
      let mutable IsMoving = true     
      core.env.root|> Op_element.addMask |> ignore
      let onMoveHandle = Handler<MouseEvent>(         
          fun sender e2->
          if IsMoving && e2.buttons =1 then    
            let newMouseP = pointF.fromMouseEvent e2
            pointF.setElementPosition root (oldEP+(newMouseP-oldMP))
            ()
        )
      let onBtnUpHandle = Handler<MouseEvent>(
          fun sender e3 ->
            if IsMoving then
              IsMoving<-false
              core.env.event.mouseMoving.Publish.RemoveHandler onMoveHandle
              core.env.root|>Op_element.delMask|> ignore
              ()
        )
      core.env.event.mouseMoving.Publish.AddHandler onMoveHandle
      core.env.event.mouseUp.Publish.AddHandler onBtnUpHandle
    
    pointF.setElementPosition view.element.Value p
    view.element.Value.onclick<- fun e->
      env.state.setFocus view.element.Value
      ()
    env.addMember core
    core.op_view.hide
    core