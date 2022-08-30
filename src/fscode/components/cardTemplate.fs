module app.components.cardTemplate
open System
open Microsoft.FSharp.Control
open app.common
open app.common.eventtypes
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open Browser.Types
open Browser
open Fable.Core
open FSharp.Control


module Card =
  type[<StringEnum>] Msg=
    |Close
    |MoveBegin
    |MoveEnd
    |Pin
  type State ={
    mutable IsMoving:bool
    mutable MoveBeginAt:DiffPoint
  }
  with
    static member init ={
      IsMoving = false
      MoveBeginAt = DiffPoint.set -1 -1 -1 -1
    }
  type Event' = {
    Close :Event<unit>
    MoveBegin:Event<pointF>
    MoveEnd:Event<unit>
    Pin:Event<pointF>
  }
  with
    static member init = {
          Close=Event<unit>()
          MoveBegin=Event<pointF>()
          MoveEnd=Event<unit>()
          Pin=Event<pointF>()
    }

  type Core = {
    mutable view:Brick
    mutable state:State
    mutable event:Event'
    Id : string 
  }
  type CardFieldContent = |Text of string |Image of string
  
  type ViewUpdate =
    static member position (env:Core) (nowMouseAt:pointF)=
      
      let style = env.view.element.Value.style
      let oldMouse = env.state.MoveBeginAt.mousePoint
      let oldElem = env.state.MoveBeginAt.elementPoint
      // console.log $"{oldElem.left+nowMouseAt.left-oldMouse.left}px"
      style.left <- $"{oldElem.left+nowMouseAt.left-oldMouse.left}px"
      style.top <- $"{oldElem.top+nowMouseAt.top-oldMouse.top}px"
      
  let cardField (content:CardFieldContent)=
    Div [
      classes [CardField_self]
    ] [
      Div [classes [Common_glass;Common_btn;CardField_dragBar]
           InnerHtml <| ICON.VerticalMoveBar [] 
           ] []
      Div [classes [Common_glass;CardField_content]] [
        match content with
        |Text s -> TextArea [classes [Common_textArea;Common_glass;CardField_content_text]
                             TextAreaValue s ] []
        |Image s-> Img  [Src s
                         classes [CardField_content_img;]
                         ] []
      ]
      Div [classes [Common_glass;CardField_btns]] [
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.link 
             ] []
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.expand []
             ] []
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.close []
             ] []
      ]
    
    ]
  let testField = cardField <| Text "123"
  let testField2 = cardField <| Image URL.logo
  let atom (point:pointF) =
    Div [
      classes [Common_component;Card_carrier;Common_glass]
      CSSPosition point.ToPx
    ] [
      Div [ classes [Common_glass;Card_self;] ] [
        Div [ classes [Common_glass;Card_header] ] [
          Span [classes [Common_glass;Common_btn;Card_header_btn_close]; InnerHtml <| ICON.close [] ] []
          Span [classes [Common_moveBar;Common_glass;Common_btn;Card_header_btn_move]; InnerHtml <| ICON.HorizontalMoveBar []] []
          Span [classes [Common_glass;Common_btn;Card_header_btn_pin] ; InnerHtml <| ICON.pin [] ] []
        ]
        Div [classes [Card_body]] [
        Div [classes [Common_glass;Card_body_menu]] [
          Span [classes [Common_glass;Common_btn]
                InnerHtml <| ICON.plus [] + ICON.clip []
                ] []
          Span [classes [Common_glass;Common_btn]
                InnerHtml <| ICON.plus [] + ICON.text []
                ] []
        ]
        testField
        testField2
        testField
        testField2
        testField
        testField2
      ]
      ]
      
    ]
  let Init (env:GlobalCore) (p:pointF) =
    let view = build <|atom (p:pointF)
    let core = {
      view = view
      event = Event'.init
      state = State.init
      Id = view.element.Value.id
    }
    // env.addCard core
    console.log env.hashMap
    let close = getElementFromBrick view $".{Card_header_btn_close}" 
    let move = getElementFromBrick view $".{Card_header_btn_move}"
    let pin = getElementFromBrick view $".{Card_header_btn_pin}"
    close.onclick<- fun e-> core.event.Close.Trigger()
    move.onmousedown<- fun e->
      console.log "mouse down"
      core.event.MoveBegin.Trigger(pointF.set e.clientX e.clientY)
    pin.onclick<- fun e-> core.event.Pin.Trigger(pointF.set e.clientX e.clientY)
    core.event.Close.Publish.Add <| fun e-> env.root.removeChild core.view.element.Value |>ignore
    core.event.MoveBegin.Publish.Add <| fun e->
      let r = view.element.Value.getBoundingClientRect()
      core.state.MoveBeginAt <- DiffPoint.set e.left e.top r.left r.top
      core.state.IsMoving <-true
    env.event.mouseMoving.Publish.Add <| fun e-> 
      if core.state.IsMoving then
        ViewUpdate.position core (pointF.set e.clientX e.clientY)
    env.event.mouseUp.Publish.Add <| fun e->
      core.state.IsMoving <-false
    //TODO 还有一个pin没写, 需要等数据互通搞好
    
    core
  //从内存读取
  let load (guid:string) = ()