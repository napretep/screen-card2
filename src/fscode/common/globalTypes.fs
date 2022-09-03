﻿module app.common.globalTypes

open Browser.Dom
open Browser.Types
open Feliz
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common.DSL
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.storageTypes

type ICore (view,Id) =
  member val view:Brick=view with get,set
  member val Id:string=Id with get,set

// type ComponentCore = Card of Card.Core

type MouseDomPoint = {//用于拖拽位置修正
  mousePoint:Geometry.pointF
  elementPoint:Geometry.pointF
}
  
  with
    static member set mx my ex ey =
      {
        mousePoint = Geometry.pointF.set mx my
        elementPoint = Geometry.pointF.set ex ey
      }
  end
  
type GlobalState = {
  mutable ScreenCapCardId:string option
  mutable IsFrameDrawing:bool
  mutable FrameDrawStartAt:pointF
  mutable FrameRect :Rect
  mutable FrameDiv :HTMLElement
  mutable ScreenCapDataUrl:string
  mutable CurrentFocusElement:HTMLElement option
  mutable cardNeedDisplay:Save.CardNeedDisplay
}
with
  static member init =
    let frame = build (
      Div [Id CapturingFrame_carrier] [
      
      Div [Id CapturingFrame_self;] [] 
      Div [Id CapturingFrame_btns; classes [Common_displayNone]] [
          Span [Id CapturingFrame_btns_no
                classes [Common_btn;Common_glass;]
                InnerHtml <| ICON.close []
                ] []
          Span [Id CapturingFrame_btns_ok
                classes [Common_btn;Common_glass;]
                InnerHtml <| ICON.confirm
                ] []
        ]
      Span [
        Styles ["justify-content: center;"]
        classes [Common_btn;Common_moveBar;Common_glass;Common_displayNone]; InnerHtml <| ICON.HorizontalMoveBar []
      ] []
    ]
     )
    let canvas = document.createElement "canvas" :?>HTMLCanvasElement
    canvas.id = "ScreenCapCanvas"
    {
      ScreenCapCardId = None
      IsFrameDrawing = false
      FrameDrawStartAt = pointF.set -1 -1
      FrameDiv = frame.element.Value
      ScreenCapDataUrl = ""
      FrameRect = Rect.zero
      CurrentFocusElement = None
      cardNeedDisplay = Save.CardNeedDisplay.init
    }
  member this.setFocus (e:HTMLElement) =
    this.CurrentFocusElement |> Option.iter (fun e-> e.classList.remove Common_zindexFocus.S)
    e.classList.add Common_zindexFocus.S
    this.CurrentFocusElement <- Some e
    ()
  
type GlobalEvent={
  mouseMoving:Event<MouseEvent>
  mouseUp:Event<MouseEvent>
  mouseDown:Event<MouseEvent>
  drawBegin:Event<unit>
  screenCapBegin:Event<string> //string 是 card id
  screenCapOk:Event<unit> // card id * dataurl 不传播数据, 数据通过globalstate传播
  openCardFromDB:Event<string> // string 为card id
  deleteCardInDB:Event<string>
}
with
  static member init =
    {
      mouseMoving = Event<MouseEvent>()
      mouseUp=Event<MouseEvent>()
      mouseDown=Event<MouseEvent>()
      drawBegin = Event<unit>()
      screenCapBegin=Event<string>()
      screenCapOk=Event<_>()
      openCardFromDB=Event<string>() // string 为card id
      deleteCardInDB=Event<string>()
    }


  
type GlobalCore = {
  event:GlobalEvent
  root:HTMLElement
  mutable hashMap:Map<string,ICore>
  state : GlobalState
}
with
  member inline this.addMember (core:ICore) =
    this.root.appendChild core.view.element.Value |>ignore
    this.hashMap <- this.hashMap.Add (core.Id,core)
    DataStorage.appendUnique CardLib.S core.Id
  member inline this.removeMember (core:ICore) =
    this.root.removeChild core.view.element.Value |>ignore
    this.hashMap.Remove core.Id
  member this.saveTransTab =
    let transTab = this.state.cardNeedDisplay.transTab|>List.toArray
    DataStorage.set (TransTab.S) transTab |>ignore
    ()
  member this.AppendToTransTab (data:string)=
    let transTab  = this.state.cardNeedDisplay.transTab
    if transTab|>List.contains data |> not then
      this.state.cardNeedDisplay.transTab<-data::transTab
    this.saveTransTab
  member this.RemoveFromTransTab (data:string)=
    let transTab  = this.state.cardNeedDisplay.transTab
    this.state.cardNeedDisplay.transTab<-transTab|>List.filter(fun e->e<>data)
    this.saveTransTab