module content
open System
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



let MsgToBackend msg = ChromeMsg.ToBackEnd RuntimeMsgActor.Tab msg
let MsgToPopup msg = ChromeMsg.ToPopup RuntimeMsgActor.Tab msg
let MsgReceivedCallback callback = ChromeMsg.ReceivedCallback RuntimeMsgActor.Tab callback

let MsgToBackendHeader = {RuntimeMsgHeader.backendAsReceiver with sender=RuntimeMsgActor.Tab}

chromeRuntime.onMessage.addListener( MsgReceivedCallback(
        fun msg ->
           match msg.purpose with
           |ShowContent -> msg.content |> Pip.log
           |Continuation -> Continuation.test("count",Pip.log) |> ignore
           |_-> msg |> Pip.log
    )
)


let  Host = document.createElement "div"
Host.id <- "Screen.Card-wrapper"


document.body.appendChild Host |>ignore

[<Emit("""{mode:"open"}""")>]
let shadowRootInit:ShadowRootInit=jsNative
let root = Host.attachShadow(shadowRootInit)

let baseElem = document.createElement "div"
baseElem.id<- "baseRoot"

let CommonStyleEl =  document.createElement "style"
let DaisyStyleEl = document.createElement "style"
let TailWindStyleEl =  document.createElement "style"
let TailWindScriptEl = document.createElement "script"


CommonStyleEl.innerHTML <- styleSheet.commonStyle
// TailWindScriptEl.innerHTML<- JsTailWindScript
// fetchContent URL.TailWindJS TailWindScriptEl |> ignore
fetchContent URL.DaisyUICSS DaisyStyleEl |> ignore
fetchContent URL.TailwindCSS TailWindStyleEl |> ignore

console.log root.ownerDocument
root.appendChild TailWindScriptEl |> ignore
root.appendChild TailWindStyleEl |> ignore
root.appendChild DaisyStyleEl |> ignore
root.appendChild CommonStyleEl |> ignore
root.appendChild baseElem |> ignore

chromeRuntime.sendMessage {MsgToBackendHeader with content = "loaded";purpose=TabLoaded} |> ignore



[<RequireQualifiedAccess>]
type Msg= |DoNoThing|FromAssistDot of AssistDot.Msg |FromCard of Card.Msg

type Model={
    assistDot:AssistDot.Model
    cardsOnScreen:Card.Model seq
}

let init () = {assistDot=AssistDot.init()
               cardsOnScreen= [Card.init()]
               },Cmd.none
let update msg (model: Model):Model*Cmd<Msg>  = model,Cmd.none

let styles =
    Html.style ""
let view (model: Model) (dispatch: Msg -> unit) =
    React.fragment [
    Html.div [
        theme.wireframe
        prop.style [
            style.position.fixedRelativeToWindow
            style.left 0
            style.top 0
            style.zIndex 99999
            style.backgroundColor.transparent
        ]
        prop.classes (AsStr [``Common-Shadow``;``Common-backdropBlur``])
        prop.children[
            AssistDot.view model.assistDot (Msg.FromAssistDot >> dispatch)
            
        ]
    ]
    Html.div [
        theme.wireframe
        prop.style [
            style.position.fixedRelativeToWindow
            style.left 100
            style.top 100
            style.zIndex 99999
            style.backgroundColor.transparent
        ]
        prop.classes (AsStr [``Common-Shadow``;``Common-backdropBlur``])
        prop.children[
            yield! [for card in model.cardsOnScreen -> Card.view card (Msg.FromCard>>dispatch)]
        ]
    ]
]




console.log $" this is content.js from scapp2 version={thisTime.toLocaleString()}"

document.onload<- (fun e->console.log $"document.loaded at {thisTime.toLocaleString()}")

Program.mkProgram init update view
|> Program.withReactSynchronous' baseElem
// |> Program.withSubscription 
|> Program.run




let e = document.querySelector("#baseRoot")
console.log e
// TODO 全体组件背景毛玻璃效果, 需要排查一致性问题, 然后除了用blur,还要用白色的border