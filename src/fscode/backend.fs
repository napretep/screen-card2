module app.backend
open System
open System.Collections.Generic
open Browser.Types
open Browser.Dom
open Browser.DomExtensions
open Chrome.Chrome.Tabs
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open FSharp.Collections
open Fable.Import
open app.common.funcs
open app.common.obj
open TabInfo



let Message content =
    { RuntimeMsg.Default with content = content }

let ToTabHeader = {RuntimeMsgHeader.tabAsReceiver with sender = Backend}
let ToPopupHeader = {RuntimeMsgHeader.popupAsReceiver with sender = Backend}
let MsgReceivedCallback callback =
    ChromeMsg.ReceivedCallback RuntimeMsgActor.Backend callback
let backendMsgQueue = Dictionary<tabId,RuntimeMsgHeader list>()

let MsgToPopup msg = ChromeMsg.ToPopup RuntimeMsgActor.Backend msg
let Storage = Dictionary<obj, obj>()

//backend的listener是必须的, 不能没有.
chromeRuntime.onMessage.addListener (
    MsgReceivedCallback (fun header ->
        match header.sender,header.purpose with
        |Tab,ShowContent ->
            {header with sender=Backend;receiver=Tab} |> ChromeMsg.To
        |Tab,TabLoaded -> (
            {header with sender=Backend;receiver=Tab;purpose=ShowContent} |> ChromeMsg.To
            ()
            )
        |_ ->
            "receive Unknown msg"|> Pip.log
            header |> Pip.log
    )
)


chromeTabs.onActivated.addListener(Action<_>(
        fun (tab:TabActiveInfo)->
            console.log $"{Some tab.tabId} on Activated at {thisTime.toLocaleString()}"
            let header = {ToTabHeader with
                                Id =Some tab.tabId
                                content= $"{Some tab.tabId} on Activated at {thisTime.toLocaleString()}"
                                purpose=Continuation}
            (tab.tabId,header) ||>ChromeMsg.ToTabById  |> ignore
        )
)

