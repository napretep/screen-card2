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
        Div [classes [Common_glass;Common_btn];
             InnerHtml ICON.trashBin
             Id CardField_btns_del
              ] []
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.expand
             Id CardField_btns_expand
             ] []
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
            Span [classes [Common_glass;Common_btn]
                  InnerHtml <| ICON.pin
                  Id CardLib_toolbar_right_pin
                  ] []
            Span [classes [Common_glass;Common_btn]
                  InnerHtml <| ICON.close
                  Id CardLib_toolbar_right_close
                  ] []
          ]
        ]
        Div [Id <| CardLib_container; classes [Common_glass]] [

        ]
      ]
    ]
  let view = build atom
  
  module method =
    let hide () = view.element.Value.remove()
    let show () =  view.element.Value
    
  type Core(env:GlobalCore,view:Brick,Id:string) as this=
    inherit ICore(view,Id)
    member val env=env
    member val state = state with get,set
    member val event = Event.init with get,set
    member val op_view = Op_View(this)
  and Op_View (env:Core) =
    member val env=env
    member this.show =
      let readCardIds(cids:string array)=
        DataStorage.read(cids).``then``(
        fun maybeData->
          cids|>Array.map (fun cid->maybeData[cid])
          |>Array.filter (fun objop->objop.IsSome)
          |>Array.map(fun oo->
            let card = oo.Value:?> Save.Card
            card 
            )
          |>this.loadItem
      )
      DataStorage.read([|CardLib.S|]).``then``(
        fun maybeData-> maybeData[CardLib.S]|>Option.iter (
            fun realData ->
              let card_ids= realData:?>string array
              readCardIds(card_ids)|>ignore
          )
        )|>ignore
      env.env.root.appendChild this.env.view.element.Value|>ignore
      this.env.state.IsShow<-true
    member this.hide =
      this.cleanItem
      this.env.view.element.Value.remove()
      this.env.state.IsShow<-false
    member this.cleanItem =
      let body = this.env.view.hashmap[CardLib_container.S].element.Value
      for i=0 to body.children.length-1 do
        body.children[0].remove()
    member this.loadItem (items:Save.Card array) =
      let body = this.env.view.hashmap[CardLib_container.S].element.Value
  
      let iter(card:Save.Card)=
        let text,img = 
          match card.fields.Length with
          |0->
            card.url,""
          |_->
            let result:Save.CardField option=
              card.fields|>Array.filter (fun e-> e.contentKind=0)|>Array.toList|>List.tryHead
            let text = result|>Option.map (fun e-> e.content) |> Option.defaultValue card.url
            let imgResult:Save.CardField option =
              card.fields|>Array.filter (fun e-> e.contentKind=1)|>Array.toList|>List.tryHead
            let img = result|>Option.map (fun e-> e.content) |> Option.defaultValue ""
            text,img
        let brick = build (cardItem img text)
        brick.Id<-card.Id
        body.appendChild brick.element.Value|>ignore
        let del = brick.hashmap[CardField_btns_del.S].element.Value
        let get = brick.hashmap[CardField_btns_expand.S].element.Value
        console.log("155行")
        del.onclick <- fun e->
          DataStorage.del(card.Id).``then``(fun e->
            brick.element.Value.remove()          
          )|>ignore
        get.onclick<-fun e->
          DataStorage.read([|card.Id|]).``then``(fun maybeCard->
            maybeCard[card.Id]|>Option.iter(fun data->
                let card' = data:?> Save.Card
                card'.show<-true
                Card.load this.env.env card'|>ignore
              )
            ()
            )|>ignore
      items|> Array.iter iter  
      
  let Init (env:GlobalCore) (p:pointF) =
    let core = Core(
      env = env,
      view = view,
      Id=CardLib_self.S
      )
    let moveBar = view.hashmap[CardLib_moveBar.S].element.Value
    let carrier = view.hashmap[CardLib_carrier.S].element.Value
    let close = view.hashmap[CardLib_toolbar_right_close.S].element.Value
    close.onclick <- fun e->
      core.op_view.hide 
    moveBar.onmousedown<-fun e->
      let oldEP = pointF.fromElementBounding carrier
      let oldMP = pointF.fromMouseEvent e
      let mutable IsMoving = true     
      core.env.root|> Op_element.addMask |> ignore
      let onMoveHandle = Handler<MouseEvent>(         
          fun sender e2->
          if IsMoving && e2.buttons =1 then    
            let newMouseP = pointF.fromMouseEvent e2
            pointF.setElementPosition carrier (oldEP+(newMouseP-oldMP))
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