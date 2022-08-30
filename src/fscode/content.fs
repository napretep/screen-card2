module content
open Microsoft.FSharp.Collections
open app.common
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open app.common.eventtypes
open app.components
open Browser.Types
open Browser
open Fable.Core
open FSharp.Core
open FSharp.Control
open app.components.cardLibrary
open app.components.cardTemplate

// type _ExtensionMessageEvent = (obj option *  MessageSender *  (obj -> unit)) -> unit


// let globalEvent = {
//   mouseMoving=Event<MouseEvent>()
//   mouseUp = Event<MouseEvent>()
// }

let x:HTMLElement = document.createElement "div"
x.style
let MsgToBackend msg =
  ChromeMsg.ToBackEnd RuntimeMsgActor.Tab msg

let MsgToPopup msg =
  ChromeMsg.ToPopup RuntimeMsgActor.Tab msg

let MsgReceivedCallback callback =
  ChromeMsg.ReceivedCallback RuntimeMsgActor.Tab callback

let MsgToBackendHeader =
  { RuntimeMsgHeader.backendAsReceiver with sender = RuntimeMsgActor.Tab }

chromeRuntime.onMessage.addListener (
  MsgReceivedCallback (fun msg ->
    match msg.purpose with
    | ShowContent -> msg.content |> Pip.log
    | Continuation -> Continuation.test ("count", Pip.log) |> ignore
    | _ -> msg |> Pip.log)
)


let Host = document.createElement "div"
Host.id <- "Screen.Card-wrapper"


document.body.appendChild Host |> ignore

[<Emit("""{mode:"open"}""")>]
let shadowRootInit: ShadowRootInit =
  jsNative

let root =
  Host.attachShadow (shadowRootInit)

let baseElem = document.createElement "div"
baseElem.id <- "baseRoot"

let CommonStyleEl =
  document.createElement "style"

CommonStyleEl.innerHTML <- styleSheet.CSSInjection

console.log root.ownerDocument
root.appendChild CommonStyleEl |> ignore
root.appendChild baseElem |> ignore

chromeRuntime.sendMessage
  { MsgToBackendHeader with
      content = "loaded"
      purpose = TabLoaded }
|> ignore


module AssistDot =
  type [<StringEnum>] Msg =
    |MoveBegin
    |MoveEnd
    |Close
  module Event=
    let MoveBegin = Event<pointF>()
    let MoveEnd = Event<unit>()
    let Close = Event<unit>()
    let OpenCardLib = Event<unit>()
    let CreateCard = Event<unit>()
  module Subscribe =
    let MoveBegin = Event.MoveBegin.Publish
    let MoveEnd = Event.MoveEnd.Publish
    let Close = Event.Close.Publish
    let OpenCardLib = Event.OpenCardLib.Publish
    let CreateCard = Event.CreateCard.Publish

  type State ={
    mutable MoveBeginRect:DiffPoint
    mutable MoveBegin:bool
    mutable IsClosed:bool
  }
  let mutable state = {
    MoveBeginRect= DiffPoint.set -1 -1 -1 -1
    MoveBegin = false
    IsClosed = false
  }
  
  let atom:Brick = 
    Div [
      Classes << AsStr <| [CssClass.Common_component;]
      Id  CssClass.AssistDot_carrier.S
      CSSPosition ("calc(100% - 30px)","200px")
    ] [
      Div [ Classes <<AsStr <|[CssClass.Common_glass]
            Id CssClass.AssistDot_self.S
             ] [
            Div [ Classes <<AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.HorizontalMoveBar []
                  Id CssClass.Common_moveBar.S
                  OnMouseDown <| fun e-> Event.MoveBegin.Trigger(pointF.set e.clientX e.clientY)
                   ] [  ]
            Div [ Classes <<AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.close []
                  OnClick <| fun e-> Event.Close.Trigger()
                   ] [  ]
            Div [Classes << AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                 InnerHtml <| ICON.bookshelf []
                 OnClick <| fun e->  Event.OpenCardLib.Trigger()
                 ] []
            Div [Classes << AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                 InnerHtml <| ICON.newCard []
                 OnClick <| fun e-> Event.CreateCard.Trigger()
                 ] []
          ]
    ]
  let view = build atom
  let getViewBoundingRect() =
    view.element.Value.getBoundingClientRect()
    
  // getViewBoundingRect().
  let update (e:HTMLElement) (pos:pointF) =
    let mouse = state.MoveBeginRect.mousePoint
    let element = state.MoveBeginRect.elementPoint
    e.style.left<- $"{element.left+pos.left-mouse.left}px"
    e.style.top <- $"{element.top+pos.top-mouse.top}px"
    // e.style.transform<- $"translate({pos.left-mouse.left}px,{pos.top-mouse.top}px)"
  type EventHandler =
    static member WatchMouseMove (e:Event) =
      console.log $"mouse move at {e}"
      let newE = e:?>MouseEvent
      update view.element.Value <| pointF.set newE.clientX newE.clientY
    static member WatchMouseUp (removeListener:unit->unit) (e:MouseEvent) =
      console.log $"mouse up at {e}"
      removeListener()
      
      
  Subscribe.MoveBegin.Add (fun beginAt->
  let cube = getViewBoundingRect()
  state.MoveBeginRect<- DiffPoint.set beginAt.left beginAt.top cube.left cube.top
  state.MoveBegin <- true
  )

  Subscribe.Close.Add <| fun ()->
    state.IsClosed<-true
    view.element.Value.style.display<-"none"


let globalCore ={
  event=GlobalEvent.init
  root = baseElem
  hashMap = Map<string,ICore>[]
}



baseElem.appendChild AssistDot.view.element.Value |> ignore 
baseElem.appendChild CardLib.view.element.Value |> ignore
// baseElem.appendChild card.element.Value |> ignore

AssistDot.Subscribe.OpenCardLib.Add (fun ()->
  console.log "opencardlib"
  if CardLib.state.IsShow then
    CardLib.state.IsShow<-false
    CardLib.method.hide()
  else
    CardLib.state.IsShow<-true
    CardLib.method.show()
)
AssistDot.Subscribe.CreateCard.Add(fun ()->
  let newCard = Card.Init globalCore (pointF.set 100 200)
  ()
  // baseElem.appendChild newCard.element.Value |> ignore
)
// let newCard = Card.Init globalCore (pointF.set 100 200)
// console.log  newCard.view.element.Value
window.onmousemove <- fun e->
  globalCore.event.mouseMoving.Trigger(e)
  match AssistDot.state.MoveBegin with 
  |true -> AssistDot.EventHandler.WatchMouseMove e
  |_ ->()
  // if newCard.state.IsMoving then
  //   Card.method.updatePosition newCard (pointF.set e.clientX e.clientY)

window.onmouseup <- fun e->
  globalCore.event.mouseUp.Trigger(e)
  match AssistDot.state.MoveBegin with
  |true ->
    AssistDot.state.MoveBegin<-false 
  |_ -> ()







console.log $" this is content.js from scapp2 version={thisTime.toLocaleString ()}"
document.onload <- (fun e -> console.log $"document.loaded at {thisTime.toLocaleString ()}")