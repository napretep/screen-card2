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
open app.components.tooltip

let MsgReceivedCallback callback =
  ChromeMsg.ReceivedCallback RuntimeMsgActor.Tab callback

let MsgToBackendHeader =
  { RuntimeMsgHeader.backendAsReceiver with sender = RuntimeMsgActor.Tab }

let THISPAGE = newGuid() 

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
            mkBtn ICON.HorizontalMoveBar AssistDot_btn_moveBar "拖动" "l" 
            mkBtn ICON.close AssistDot_btn_close "临时关闭" "l"
            mkBtn ICON.bookshelf AssistDot_btn_cardLib "打开卡片库" "l"
            mkBtn ICON.newCard AssistDot_btn_newCard "新建卡片" "l"
          ]
    ]
  let view =
    let view = build atom
    let close = view.hashmap[AssistDot_btn_close.S].element.Value    
    let cardLib = view.hashmap[AssistDot_btn_cardLib.S].element.Value
    let newCard = view.hashmap[AssistDot_btn_newCard.S].element.Value
    let moveBar = view.hashmap[AssistDot_btn_moveBar.S].element.Value
    close.onclick<- fun e->
      Event.Close.Trigger()
    cardLib.onclick<- fun e->
      Event.OpenCardLib.Trigger()
    newCard.onclick<- fun e->
      Event.CreateCard.Trigger()
    moveBar.onmousedown<- fun e->
      Event.MoveBegin.Trigger(pointF.set e.clientX e.clientY)
    view
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
      let newE = e:?>MouseEvent
      update view.element.Value <| pointF.set newE.clientX newE.clientY
    static member WatchMouseUp (removeListener:unit->unit) (e:MouseEvent) =
      
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

  
  // globalCore.hashMap.Values|>Seq.filter (fun e->
  //     console.log "202209070047"
  //     console.log e
  //     if e.type'=SaveKind.CardLib then
  //       let core = e :?> CardLib.Core
  //       core.state.IsShow
  //     else
  //       false
  //     )|>Seq.toList


//初始化 capturing frame的移动事件, 全部写在一个函数内


let closeCapFrame ()= 
  size2d.setElementStyleSize (globalCore.state.FrameDiv.children[0]:?>HTMLElement) size2d.zero
  let u = globalCore.state.FrameDiv.children[0]:?>HTMLElement
  for i=0 to u.children.length-1 do u.children[i].remove()
  globalCore.state.FrameDiv.remove()
let CapFrameCancelBtn = globalCore.state.FrameDiv.querySelector $"#{CapturingFrame_btns_no}" :?>HTMLElement
let CapFrameAcceptBtn = globalCore.state.FrameDiv.querySelector $"#{CapturingFrame_btns_ok}":?>HTMLElement




baseElem.appendChild AssistDot.view.element.Value |> ignore 


let cardLib = CardLib.Init globalCore (pointF.set 200 200)


let updateCardsStateFromDB() =
  
  let getCurrentCardInDB =
    let currentCardsLi = globalCore.hashMap.Keys |>Seq.filter (fun key->
        globalCore.hashMap[key].type'=SaveKind.Card
        ) 
    DataStorage.readCards(currentCardsLi|>Seq.toArray)
  //1 更新随行卡片
  let removeNoLongerTravelCards(travelCards:Save.Card seq)=
    console.log ("travelCards at "+thisTime.toLocaleString())
    console.log (travelCards|>Seq.toArray)
    //去掉卡片
    getCurrentCardInDB.``then``(
      fun cards ->
        cards|> Seq.map (
          fun card->
            if card.pin<>2 && (card.show=false || card.homeUrl <> window.location.href) then
              (globalCore.hashMap[card.Id]:?>Card.Core).op_view.hide |> ignore
            ()    
          )|>Seq.toArray 
      ).``then``(fun e->
        console.log ("travelCards to load "+thisTime.toLocaleString())
        console.log (travelCards|>Seq.toArray)
        travelCards|>Seq.map (Card.load globalCore)|>Seq.toArray
      )
    //更新卡片
    

      
  DataStorage.readTravelCards.``then``(
    fun data ->DataStorage.readCards(data).``then``(
        removeNoLongerTravelCards
      )
  )
  
let updateSingleCard(card_id)=
  DataStorage.readCards([|card_id|]).``then``(
    fun cards->
        cards|>
        Seq.map (
        fun (card:Save.Card)->
          console.log card
          match (card.pin, globalCore.hashMap.Keys |> Seq.contains card_id,card.show)   with
          |2.0,_,true ->Card.load globalCore card 
          |_,true,_->
            if not card.show || card.homeUrl<>window.location.href then
              globalCore.removeMember card.Id
              ()
          |_,_,_ -> ()
        )
        |> Seq.toList
        |> ignore
    )
  
  
  
let MsgToPopupHeader = {RuntimeMsgHeader.popupAsReceiver with sender = RuntimeMsgActor.Tab}





console.log $" this is content.js from scapp2 version={thisTime.toLocaleString ()}"

//ALL_EVENT here
CapFrameCancelBtn.onclick <- fun e-> closeCapFrame()

CapFrameAcceptBtn.onclick <- fun e->
  globalCore.state.FrameRect<- Rect.fromElement  globalCore.state.FrameDiv
  Op_element.displayNone globalCore.state.FrameDiv
  JS.setTimeout (fun ()->
     chromeRuntime.sendMessage {MsgToBackendHeader with purpose=ScreenCapRequest} |>ignore
     ()
   ) 20|>ignore
  ()

AssistDot.Subscribe.OpenCardLib.Add (fun ()->
  if cardLib.state.IsShow then
    cardLib.op_view.hide
  else
    cardLib.op_view.show|>ignore
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
  DataStorage.readAll.``then``(fun e-> console.log(e))
  match AssistDot.state.MoveBegin with
  |true ->
    AssistDot.state.MoveBegin<-false 
  |_ -> ()

chromeRuntime.onMessage.addListener (
  MsgReceivedCallback (fun msg ->
    match msg.purpose with
    | ScreenCapOK ->
      
      let frame =globalCore.state.FrameDiv
      frame.remove()
      Op_element.displayNonNone frame
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
      Op_element.displayNonNone (globalCore.state.FrameDiv)
      ()
    | ShowContent -> msg.content |> Pip.log
    | UserActivatedThisPage ->
      console.log "UserActivatedThisPage"
      DataStorage.readAll.``then``(
        fun data->
          console.log ("UserActivatedThisPage"+ (thisTime.toLocaleString()))
          console.log data
          )
       |>ignore 
      updateCardsStateFromDB()
      |> ignore
    | CardStateUpdate->
      if msg.UUID <> THISPAGE then
        console.log "CardStateUpdate"
        let cardId =  msg.content:?>string
        updateSingleCard(cardId)|> ignore
        
    | _ -> msg |> Pip.log)
)
globalCore.event.screenCapOk.Publish.Add (fun ()->
  let kids = globalCore.root.children
  for i=0 to  kids.length-1 do
    let kid = kids[i]
    kid.classList.remove Common_displayNone.S
    ()
  let card_id = globalCore.state.ScreenCapCardId.Value
  let dataurl = globalCore.state.ScreenCapDataUrl
  let cardCore = globalCore.hashMap[card_id]:?>Card.Core
  cardCore.op_field.addImgFields [dataurl] |> ignore
  cardCore.op_view.scrollToBottom
  JS.setTimeout (fun ()->cardCore.op_state.saveAndRefresh|>ignore) 100
  ()
  )
document.onload <- (fun e -> console.log $"document.loaded at {thisTime.toLocaleString ()}")

window.onmousedown <- fun e->
  globalCore.event.mouseDown.Trigger(e)
  ()
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
globalCore.event.updateCardLib.Publish.Add(fun e->
    // console.log "globalCore.event.updateCardLib.Publish"
    console.log "cardLib.state.IsShow"
    console.log cardLib.state.IsShow
    if cardLib.state.IsShow  then
       cardLib.op_view.delayReload
       ()
    ()
      
  )
globalCore.event.updateCards.Publish.Add(
  fun e->
    chromeRuntime.sendMessage {MsgToBackendHeader with purpose=CardStateUpdate;content=e;UUID=THISPAGE} |>ignore
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
    
    // root.classList.remove Common_mask.S
    root |> Op_element.delMask |> Op_element.delFixed
    
    globalCore.event.mouseMoving.Publish.RemoveHandler DrawingCapFrameOnMouseMove
    globalCore.event.mouseDown.Publish.RemoveHandler DrawingCapFrameOnMouseDown
    ()
  )




globalCore.event.screenCapBegin.Publish.Add (fun card_id->
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

globalCore.state.FrameDiv.onclick <- fun e->(
  globalCore.state.setFocus globalCore.state.FrameDiv
  ()
  )


updateCardsStateFromDB()