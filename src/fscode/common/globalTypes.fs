module app.common.eventtypes

open Browser.Types
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common.DSL
open app.common.obj
open app.common.funcs

type ICore =
  abstract member view:Brick
  abstract member Id:string 

// type ComponentCore = Card of Card.Core

type DiffPoint = {//用于拖拽位置修正
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
  
  
type GlobalEvent={
  mouseMoving:Event<MouseEvent>
  mouseUp:Event<MouseEvent>
  
}
with
  static member init =
    {
      mouseMoving = Event<MouseEvent>()
      mouseUp=Event<MouseEvent>()
    }


type GlobalCore = {
  event:GlobalEvent
  root:HTMLElement
  mutable hashMap:Map<string,ICore>
}
// with
//   member inline this.addCard (^core:) =
//     this.root.appendChild core.view.element.Value |>ignore
//     this.hashMap <- this.hashMap.Add (core.Id,core)
  // member inline this.removeCard (core:ICore) = 