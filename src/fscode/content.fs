module content

open System
open Fable.React
open Feliz
open DaisyUI.Daisy
open DaisyUI.Operators
open DaisyUI.Helpers
open Elmish
open Elmish.React
open App.common
open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JS
open Feliz.DaisyUI
open Fetch
open app.common
open app.common.cssClass
open app.common.obj
open app.common.funcs
open jsBind
open app.common.modifies
open app.components
open app.components.assistDot
open cardTemplate
open cardLibrary
open cardGenerater
open cssClass
open styleSheet
// type _ExtensionMessageEvent = (obj option *  MessageSender *  (obj -> unit)) -> unit



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

let DaisyStyleEl =
  document.createElement "style"

let TailWindStyleEl =
  document.createElement "style"

let TailWindScriptEl =
  document.createElement "script"


CommonStyleEl.innerHTML <- styleSheet.commonStyle
// TailWindScriptEl.innerHTML<- JsTailWindScript
// fetchContent URL.TailWindJS TailWindScriptEl |> ignore
fetchContent URL.DaisyUICSS DaisyStyleEl |> ignore

fetchContent URL.TailwindCSS TailWindStyleEl
|> ignore

console.log root.ownerDocument
// root.appendChild TailWindScriptEl |> ignore
// root.appendChild TailWindStyleEl |> ignore
// root.appendChild DaisyStyleEl |> ignore
root.appendChild CommonStyleEl |> ignore
root.appendChild baseElem |> ignore

chromeRuntime.sendMessage
  { MsgToBackendHeader with
      content = "loaded"
      purpose = TabLoaded }
|> ignore



type Msg =
  | DoNoThing
  | ToAssistDot of AssistDot.Msg
  | ToCard of Card.Msg

type Model =
  { assistDot: AssistDot.Model
    cardsOnScreen: Card.Model seq }

let init () =
  { assistDot = AssistDot.init ()
    cardsOnScreen = [ Card.init () ] },
  Cmd.none

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
  match msg with
  | ToAssistDot MoveBegin ->
    { model with assistDot = model.assistDot.SetIsMoving true },
    Cmd.OfAsync
  | _ -> model, Cmd.none


let styles = Html.style ""

let shadowComponent (x: string, y: string) (className: obj list) (kids: ReactElement seq) =
  Html.div [ theme.wireframe
             prop.style [
                          // style.width rect.width
                          // style.height rect.height
                          style.left (length.calc x)
                          style.top (length.calc y) ]
             prop.className (AsStr(className @ [ Common_component ]))
             prop.children kids ]

let view (model: Model) (dispatch: Msg -> unit) =
  React.fragment [ shadowComponent
                     ("100% - 30px", "100px - 0px")
                     []
                     [ AssistDot.view model.assistDot (Msg.ToAssistDot >> dispatch) ]
                   // shadowComponent (50,50) [] [
                   //     yield! [for card in model.cardsOnScreen -> Card.view card (Msg.FromCard>>dispatch)]
                   // ]

                    ]


console.log $" this is content.js from scapp2 version={thisTime.toLocaleString ()}"

document.onload <- (fun e -> console.log $"document.loaded at {thisTime.toLocaleString ()}")

Program.mkProgram init update view
|> Program.withReactSynchronous' baseElem
// |> Program.withSubscription
|> Program.run
