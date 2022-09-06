module app.components.tooltip

open System.Text.RegularExpressions
open Fable.Core.JS
open Microsoft.FSharp.Collections
open Microsoft.FSharp.Control
open app.common.globalTypes
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.storageTypes
open app.common.styleSheet
open app.common.DSL
open Browser.Types
open Browser
open Fable.Core


type Tooltip () =
  static member readPosi (p:string) =
    match p with
    |"t" -> [
      CSSPosition ("0","0")
      CSSTransform "translate(0,-100%)"
      ]
    |"b" -> [
      CSSPosition ("0","100%")
      CSSTransform "translate(0,0)"
     ]
    |"l" -> [
      CSSPosition ("0","0")
      CSSTransform "translate(-100%,0)"
      ]  
    |"r" ->[
      CSSPosition ("100%","0")
      CSSTransform "translate(0,0)"
      ]
    |_ ->  failwith "tooltip参数不正确"
    
  //第一个参数是 内容, 第二个参数是 t b l r 
  static member el (param:string list)=
     if param.Length=0 then failwith "tooltip参数不正确"
     (Div [ classes [Common_toolTip;Common_glass];InnerText param[0]
            if param.Length>=2 then
             yield! (Tooltip.readPosi (param[1]))
             ] [])


let mkBtn icon id' tooltip tooltipPosition =
  Span [
    classes [Common_glass;Common_btn]
    Id id'
    InnerHtml <| icon
    ]
    [
        Tooltip.el [tooltip;tooltipPosition]
    ]

let mkBtnMove id' directionIcon  position=
  Span [
    classes [Common_moveBar;Common_glass;Common_btn]
    Id id'
    InnerHtml directionIcon
  ] [
    Tooltip.el ["拖动";position]
  ]

let mkBtnMoveH id' = mkBtnMove  id' ICON.HorizontalMoveBar   "t"
let mkBtnMoveV id' = mkBtnMove  id' ICON.VerticalMoveBar   "r"

