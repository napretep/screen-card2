module app.components.assistDot
open Browser.Types
open Browser.Dom
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Feliz.DaisyUI
open Feliz
open Feliz.ReactApi
open Elmish
open Elmish.React
open app.common
open funcs
open obj
open styleSheet
//
// [<RequireQualifiedAccess>]
// module AssistDot =
//   let IsSubComponent=true
//
//   type Msg =
//     | Close
//     | MoveBegin
//     | MoveEnd
//     | OpenCardLib
//     | CreateCard
//   
//   type States ={
//     IsMoving:bool
//     IsVisible: bool
//     LeftOrRight:Dir
//   }
//     with
//       static member Default = {
//         IsMoving=false
//         IsVisible=true
//         LeftOrRight=Right
//       }
//       
//     end
//   and Dir = |Left |Right
//   
//   
//   type Model = {
//     height: int
//     states:States
//   }
//   with 
//     static member Default = {
//       states=States.Default
//       height=50
//     }
//     member this.SetIsMoving (yesOrNo:bool)=
//       {this with states={this.states with IsMoving=yesOrNo} }
//     member this.SetIsVisible (yesOrNo:bool)=
//       {this with states={this.states with IsVisible=yesOrNo} }
//         
//     member this.SetLeftOrRight (LR:Dir)=
//       {this with states={this.states with LeftOrRight=LR} }
//
//
//   let init () =Model.Default
//
//   let update (msg:Msg) (model:Model)= 
//       match msg with
//       |MoveBegin ->
//         let listenMouseMove (dispatch:'Msg->unit) =
//           let callback (e: MouseEvent) =
//             console.log e
//             
//           window.onmousemove <- callback
//         model.SetIsMoving true,Some listenMouseMove 
//       |MoveEnd  -> model.SetIsMoving false,None
//       |Close -> model.SetIsVisible false,None
//       |_ -> model,None
//   
//   let view (model: Model) (dispatch: Msg -> unit) =
//     
//     Div [ AssistDot_self; Common_glass; if not model.states.IsVisible then Common_displayNone  ] [
//       Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                prop.innerHtml <| ICON.HorizontalMoveBar []
//                prop.onClick <| fun e-> dispatch Msg.MoveBegin
//                ]
//       Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                prop.innerHtml <| ICON.close []
//                prop.onClick <| fun e-> dispatch Msg.Close]
//       Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                prop.innerHtml <| ICON.bookshelf []
//                prop.onClick <| fun e-> dispatch Msg.OpenCardLib]
//       Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                prop.innerHtml <| ICON.newCard []
//                prop.onClick <| fun e-> dispatch Msg.CreateCard
//                ]
//     ]
//
// type  IDraggableProp =
//   |Axis of string
//   |Handle of string 
//   
// //https://github.com/fable-compiler/fable-react/blob/master/docs/using-third-party-react-components.md
// //https://github.com/react-grid-layout/react-draggable/blob/master/example/example.js
// type reactComponent =
//   // [<ReactComponent(import = "Draggable", from = "../../node_modules/react-draggable/cjs/Draggable.js")>]
//   // [<Import( "Draggable",from="react-draggable")>]
//   static member Draggable (props : IDraggableProp list) (elems : ReactElement list) :ReactElement =
//     ofImport "Draggable" "react-draggable" (keyValueList CaseRules.LowerFirst props) elems
//   
//   
//   [<ReactComponent>] 
//   static member AssistDot ()=
//       Div [ AssistDot_self
//             Common_glass;  ]
//           [
//               Html.div[prop.classes <| AsStr [ Common_btn;Common_glass; AssistDot_moveBar]
//                        prop.innerHtml <| ICON.HorizontalMoveBar []
//                        
//                        ]
//               Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                        prop.innerHtml <| ICON.close []
//                        
//                        ]
//               Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                        prop.innerHtml <| ICON.bookshelf []
//                        
//                        ]
//               Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
//                        prop.innerHtml <| ICON.newCard []
//                        
//                        ]
//           ]
//     // Div [ AssistDot_self; Common_glass;  ] [
    //   Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
    //            prop.innerHtml <| ICON.HorizontalMoveBar []
    //            //prop.onClick <| fun e-> dispatch Msg.MoveBegin
    //            ]
    //   Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
    //            prop.innerHtml <| ICON.close []
    //            //prop.onClick <| fun e-> dispatch Msg.Close]
    //   Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
    //            prop.innerHtml <| ICON.bookshelf []
    //            //prop.onClick <| fun e-> dispatch Msg.OpenCardLib]
    //   Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
    //            prop.innerHtml <| ICON.plusPage []
    //            //prop.onClick <| fun e-> dispatch Msg.CreateCard
    //            ]
    // ]