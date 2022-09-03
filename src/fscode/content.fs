module content
open System
open System.Collections.Generic
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.storageTypes
open app.common.styleSheet
open app.common.DSL
open app.common.globalTypes
open app.components
open Fable.Core
open Fable.Core.JsInterop
open Browser.Types
open Browser
open FSharp.Core
open FSharp.Control
open app.components.cardLibrary
open app.components.cardTemplate
open app.components.cardTemplate.Card

let MsgReceivedCallback callback =
  ChromeMsg.ReceivedCallback RuntimeMsgActor.Tab callback

let MsgToBackendHeader =
  { RuntimeMsgHeader.backendAsReceiver with sender = RuntimeMsgActor.Tab }



let Host = document.createElement "div"
Host.id <- "Screen.Card-wrapper"
Host.style.zIndex <- "999999"

document.body.appendChild Host |> ignore

[<Emit("""{mode:"open"}""")>]
let shadowRootInit: ShadowRootInit =
  jsNative

let root =Host.attachShadow (shadowRootInit)
  

let baseBrick = build (Div [
  Id Common_baseRoot
] []
)
let baseElem = baseBrick.element.Value
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
    let ScreenCapBegin = Event<unit>()

  module Subscribe =
    let MoveBegin = Event.MoveBegin.Publish
    let MoveEnd = Event.MoveEnd.Publish
    let Close = Event.Close.Publish
    let OpenCardLib = Event.OpenCardLib.Publish
    let CreateCard = Event.CreateCard.Publish

  type State ={
    mutable MoveBeginRect:MouseDomPoint
    mutable MoveBegin:bool
    mutable IsClosed:bool
  }
  let mutable state = {
    MoveBeginRect= MouseDomPoint.set -1 -1 -1 -1
    MoveBegin = false
    IsClosed = false
  }
  
  let atom:Brick = 
    Div [
      Classes << AsStr <| [CssClass.Common_component;]
      Id  CssClass.AssistDot_carrier
      CSSPosition ("calc(100% - 30px)","200px")
    ] [
      Div [ Classes <<AsStr <|[CssClass.Common_glass]
            Id CssClass.AssistDot_self
             ] [
            Div [ Classes <<AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.HorizontalMoveBar []
                  Id CssClass.Common_moveBar
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
  state.MoveBeginRect<- MouseDomPoint.set beginAt.left beginAt.top cube.left cube.top
  state.MoveBegin <- true
  )

  Subscribe.Close.Add <| fun ()->
    state.IsClosed<-true
    view.element.Value.style.display<-"none"
    
    
let globalCore ={
  event=GlobalEvent.init
  root = baseElem
  hashMap = Map<string,ICore>[]
  state = GlobalState.init
}


    
globalCore.state.FrameDiv.onclick <- fun e->(
  globalCore.state.setFocus globalCore.state.FrameDiv
  ()
  )
//初始化 capturing frame的移动事件, 全部写在一个函数内
let capturingFrameDragBar = globalCore.state.FrameDiv.children[2]:?>HTMLElement
capturingFrameDragBar.onmousedown<-fun e->
  let carrier = globalCore.state.FrameDiv
  let oldMouseP = pointF.fromMouseEvent e
  let oldCarrierP = pointF.fromElementBounding carrier
  let mouseMoveEvent = globalCore.event.mouseMoving
  let mouseUpEvent = globalCore.event.mouseUp
  let mutable IsMoving = true
  let mutable OnDragBarMouseMove = Handler<MouseEvent> (
    fun sender e2 ->
      if IsMoving && e2.buttons=1 then 
        let newMouseP = pointF.fromMouseEvent e2
        pointF.setElementPosition carrier (oldCarrierP+(newMouseP-oldMouseP))
      ()
    )
  let mutable OnDragBarMouseUp =  Handler<MouseEvent> (
    fun sender e3 ->
      IsMoving <- false
      mouseMoveEvent.Publish.RemoveHandler OnDragBarMouseMove
      
      ()
    )
  mouseMoveEvent.Publish.AddHandler OnDragBarMouseMove
  mouseUpEvent.Publish.AddHandler OnDragBarMouseUp
  ()

let closeCapFrame ()= 
  size2d.setElementStyleSize (globalCore.state.FrameDiv.children[0]:?>HTMLElement) size2d.zero
  let u = globalCore.state.FrameDiv.children[0]:?>HTMLElement
  for i=0 to u.children.length-1 do u.children[i].remove()
  globalCore.state.FrameDiv.remove()
let CapFrameCancelBtn = globalCore.state.FrameDiv.querySelector $"#{CapturingFrame_btns_no}" :?>HTMLElement
CapFrameCancelBtn.onclick <- fun e-> closeCapFrame()

let CapFrameAcceptBtn = globalCore.state.FrameDiv.querySelector $"#{CapturingFrame_btns_ok}":?>HTMLElement
CapFrameAcceptBtn.onclick <- fun e->
  globalCore.state.FrameRect<- Rect.fromElement  globalCore.state.FrameDiv
  displayNone globalCore.state.FrameDiv
  JS.setTimeout (fun ()->
     chromeRuntime.sendMessage {MsgToBackendHeader with purpose=ScreenCapRequest} |>ignore
     ()
   ) 20|>ignore
  ()
globalCore.event.screenCapOk.Publish.Add(fun ()->
  console.log "screenshot ok!" |>ignore
  // closeCapFrame()
  ()
) 

let mutable DrawingCapFrameOnMouseMove = Handler<MouseEvent> ( fun sender e->
  if globalCore.state.IsFrameDrawing && e.buttons=1 then
    
    let el_carrier = globalCore.state.FrameDiv
    let el_self = el_carrier.children[0]:?>HTMLElement
    let oldP = pointF.fromElementBounding el_carrier
    let newP = pointF.set e.clientX e.clientY
    let size = size2d.from2Point oldP newP
    let newSize = {
                   width = if size.width>0 then size.width else  0
                   height =if size.height>0 then size.height else  0
                   }
    size2d.setElementStyleSize el_self newSize
    console.log (pointF.set e.clientX e.clientY)
  ()
  )

let mutable DrawingCapFrameOnMouseDown =Handler<MouseEvent> ( fun sender e ->
  let root = globalCore.root
  globalCore.state.FrameDrawStartAt<- pointF.set e.clientX e.clientY
  globalCore.state.IsFrameDrawing<- true
  let frame = (root.appendChild globalCore.state.FrameDiv ):?> HTMLElement 
  globalCore.state.setFocus frame
  pointF.setElementPosition frame (pointF.set e.clientX e.clientY)
  
  globalCore.event.mouseMoving.Publish.AddHandler DrawingCapFrameOnMouseMove
  console.log "drawing begin"
  ()
  )
let mutable DrawingCapFrameOnMouseUp = Handler<MouseEvent> ( fun sender e->
  if globalCore.state.IsFrameDrawing then
    globalCore.state.IsFrameDrawing<-false
    let root = globalCore.root
    // root.removeChild globalCore.state.FrameDiv  |> ignore
    let btns = globalCore.state.FrameDiv.children[1]:?>HTMLElement
    btns.classList.remove Common_displayNone.S |> ignore
    globalCore.state.FrameDiv.children[2].classList.remove Common_displayNone.S |> ignore
    let kids = globalCore.root.children
    for i=0 to  kids.length-1 do
      let kid = kids[i]
      kid.classList.remove Common_displayNone.S
      ()
    // root.classList.remove Common_mask.S
    root |> Op_element.delMask |> Op_element.delFixed
    
    globalCore.event.mouseMoving.Publish.RemoveHandler DrawingCapFrameOnMouseMove
    globalCore.event.mouseDown.Publish.RemoveHandler DrawingCapFrameOnMouseDown
    
    console.log "drawing stop"
  ()
  )


globalCore.event.screenCapBegin.Publish.Add (fun card_id->
    console.log "ready for drawing"
    globalCore.state.ScreenCapCardId<- Some card_id
    let root = globalCore.root
    let kids = globalCore.root.children
    //隐藏全部元素
    for i=0 to  kids.length-1 do
      let kid = kids[i]
      kid.classList.add Common_displayNone.S
      ()
    closeCapFrame()
    
    //添加遮罩
    // root.classList.add Common_mask.S
    root |>Op_element.addMask |> Op_element.addFixed
    globalCore.event.mouseDown.Publish.AddHandler DrawingCapFrameOnMouseDown
    globalCore.event.mouseUp.Publish.AddHandler DrawingCapFrameOnMouseUp

    ()
  )



baseElem.appendChild AssistDot.view.element.Value |> ignore 


let cardLib = CardLib.Init globalCore (pointF.set 200 200)
AssistDot.Subscribe.OpenCardLib.Add (fun ()->
  console.log "opencardlib"
  if cardLib.state.IsShow then
    cardLib.op_view.hide
  else
    cardLib.op_view.show
)
AssistDot.Subscribe.CreateCard.Add(fun ()->
  let newCard = Card.Init globalCore (pointF.set 200 200) (newGuid())
  ()
)

window.onmousemove <- fun e->
  globalCore.event.mouseMoving.Trigger(e)
  match AssistDot.state.MoveBegin with 
  |true -> AssistDot.EventHandler.WatchMouseMove e
  |_ ->()

window.onmouseup <- fun e->
  globalCore.event.mouseUp.Trigger(e)
  match AssistDot.state.MoveBegin with
  |true ->
    AssistDot.state.MoveBegin<-false 
  |_ -> ()

window.onmousedown <- fun e->
  globalCore.event.mouseDown.Trigger(e)
  ()
let ReadDisplayCardFromDB() =
  let allTranTabCard=
        globalCore.hashMap.Keys|>Seq.filter(fun key->
        let card = globalCore.hashMap[key]:?>Card.Core
        card.state.pinState=PinState.TransTab
        )|>Seq.toList
      
  
  //读取全部的 TransTab 并展示
  let loadTransTab (data:obj option)=
    data|>Option.iter(
      fun aCard->
        let card=aCard:?>Save.Card
        if card.pin = 2 then Card.load globalCore card|>ignore 
      )
    
  let maybeLoadCards (card_ids:string array) (f:obj option->unit)=
    console.log card_ids
    DataStorage.read(card_ids).``then``(
      fun maybeData->
        allTranTabCard|>List.filter(fun old-> card_ids|>Array.contains old |> not)
        |>List.map(fun i -> globalCore.removeMember  globalCore.hashMap[i])|>ignore
        card_ids|>Array.map (fun card_id-> f(maybeData[card_id])
          )
      )
    |>ignore

  DataStorage.read([|TransTab.S|]).``then``
    (fun maybeData->
      maybeData[TransTab.S]|>Option.iter (
        fun value->maybeLoadCards(value:?>string array) loadTransTab
        )
    )
  |> ignore   
  
  
  
  //读取OnPageCard
  let loadOnPageCard (data:obj option)=
    data|>Option.iter(
      fun aCard->
        let card=aCard:?>Save.Card
        if card.show then 
          Card.load globalCore card|>ignore
      )
  
  DataStorage.read([|window.location.href|]).``then``
    (fun maybeData->
        maybeData[window.location.href]|>Option.iter (
          fun card_ids ->maybeLoadCards (card_ids:?>string array) loadOnPageCard
    )
  )
  |>ignore
  
  // //读取卡片库
  // DataStorage.read([|CardLib.S|]).``then``(
  //   
  //   )
  
  //读取全部的当前页面的内容
  
  
  // DataStorage.read([|SaveKind.CardLib.S|])
  //   .``then``(fun data->
  //     data[SaveKind.CardLib.S]|>Option.iter (fun value ->
  //         let cardlib = value:?>Save.CardLib
  //         let card = cardlib.cards[0]
  //         if card.pin = 2 then 
  //           Card.load globalCore cardlib.cards[0]
  //         else
  //    
  //           ()
  //         console.log cardlib
  //         
  //     )
  //     
  //     )
  |>ignore
let MsgToPopupHeader = {RuntimeMsgHeader.popupAsReceiver with sender = RuntimeMsgActor.Tab}
chromeRuntime.onMessage.addListener (
  MsgReceivedCallback (fun msg ->
    match msg.purpose with
    | ScreenCapOK ->
      
      let frame =globalCore.state.FrameDiv
      frame.remove()
      displayNonNone frame
      let el = build (Img [ ] [ ])
      let img = el.element.Value:?>HTMLImageElement
      // window.setTimeout()
      
      let job() = 
        let canvas = document.createElement "canvas":?>HTMLCanvasElement //globalCore.state.FrameDiv.children[0]:?>HTMLCanvasElement
        // let canvas =  globalCore.state.ScreenCapCanvas
        let r = globalCore.state.FrameRect
        canvas.width <- r.width
        canvas.height <- r.height
        let context = canvas.getContext_2d()
        console.log(r)
        context.drawImage(U3.Case1 img,
                          r.left,r.top,r.width,r.height,0,0,r.width,r.height)
        context.clip()
        globalCore.state.ScreenCapDataUrl <- canvas.toDataURL()
        globalCore.event.screenCapOk.Trigger()
      img.src<- (msg.content:?>string)
      Fable.Core.JS.setTimeout job 30
      
      ()        
    | ScreenCapNo ->
      window.confirm "截屏失败, 请点击插件的图标来激活截屏权限, 然后再试一次"
      displayNonNone (globalCore.state.FrameDiv)
      ()
    | ShowContent -> msg.content |> Pip.log
    | UserActivatedThisPage ->
      ReadDisplayCardFromDB()
      |> ignore
    | _ -> msg |> Pip.log)
)


globalCore.event.screenCapOk.Publish.Add (fun ()->
  let card_id = globalCore.state.ScreenCapCardId.Value
  let dataurl = globalCore.state.ScreenCapDataUrl
  let cardCore = globalCore.hashMap[card_id]:?>Card.Core
  cardCore.op_field.addImgFields [dataurl] |> ignore
  cardCore.op_view.scrollToBottom
  JS.setTimeout (fun ()->cardCore.op_state.save) 100
  ()
  )

console.log $" this is content.js from scapp2 version={thisTime.toLocaleString ()}"
document.onload <- (fun e -> console.log $"document.loaded at {thisTime.toLocaleString ()}")


ReadDisplayCardFromDB()