module app.common.obj
open System.Collections.Generic
open Fable.Core
open Chrome


// type jsNumber = |Int of int |Float of float
// type jsType =
//     |String of string
//     |Number of jsNumber
//     |Boolean of bool
//     |Object of obj
//     |Array of ResizeArray<jsType>
 
// let f (a:jsType) = true

type TestButton = Browser.Types.HTMLElement * string * (obj -> unit)
let [<Global("chrome.runtime")>] chromeRuntime:Chrome.Runtime.IExports = jsNative
let [<Global("chrome.tabs")>] chromeTabs:Chrome.Tabs.IExports = jsNative

let [<Global("chrome.extension")>] chromeExtension:Chrome.Extension.IExports = jsNative

let [<Global("chrome.storage")>] chromeStorage:Chrome.Storage.IExports = jsNative
module TabInfo =
    type tabId = float
type runtimeState = unit
type storage = Dictionary<string,obj>
type [<StringEnum>] RuntimeMsgActor = |Tab|Popup|Backend
type [<StringEnum>] RuntimeMsgFormat = |Standard|Other
type [<StringEnum>] RuntimeMsgPurpose = |ShowContent|Continuation|GetStorage|TabLoaded|Call|Other
type RuntimeMsg = 
     { purpose:RuntimeMsgPurpose option
       callback :(obj->unit) option
       content:obj }
     static member Default ={
        callback = None
        purpose = None
        content =""}
      
type RuntimeMsgHeader = 
    {   format:RuntimeMsgFormat
        sender:RuntimeMsgActor
        senderDetail:Chrome.Runtime.MessageSender option
        purpose:RuntimeMsgPurpose
        callback :(obj->unit) option
        receiver:RuntimeMsgActor
        content:obj
        Id:float option}
    static member Default ={
        format = Standard
        sender = Backend
        receiver = Backend
        senderDetail = None
        purpose = Other
        callback = None
        Id = None
        content = "hello world"
    }
    static member backendAsReceiver =RuntimeMsgHeader.Default
    static member popupAsReceiver ={RuntimeMsgHeader.Default with receiver=RuntimeMsgActor.Popup}
    static member tabAsReceiver ={RuntimeMsgHeader.Default with receiver=RuntimeMsgActor.Tab}

module URL =
    let logo = chromeRuntime.getURL("static/logo.svg")
    let DaisyUICSS = chromeRuntime.getURL("""static/daisyui@2.24.0.dist.full.css""")
    let TailwindCSS = chromeRuntime.getURL("static/tailwind@2.2.dist.min.css")
    
    let TailWindJS = chromeRuntime.getURL("static/tailwind@3.1.8.js")

module ICON =
    let  close = """
<svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
  <path stroke-linecap="round" stroke-linejoin="round" d="M9.75 9.75l4.5 4.5m0-4.5l-4.5 4.5M21 12a9 9 0 11-18 0 9 9 0 0118 0z" />
</svg>
"""
    let drop = """
<svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
  <path stroke-linecap="round" stroke-linejoin="round" d="M14.74 9l-.346 9m-4.788 0L9.26 9m9.968-3.21c.342.052.682.107 1.022.166m-1.022-.165L18.16 19.673a2.25 2.25 0 01-2.244 2.077H8.084a2.25 2.25 0 01-2.244-2.077L4.772 5.79m14.456 0a48.108 48.108 0 00-3.478-.397m-12 .562c.34-.059.68-.114 1.022-.165m0 0a48.11 48.11 0 013.478-.397m7.5 0v-.916c0-1.18-.91-2.164-2.09-2.201a51.964 51.964 0 00-3.32 0c-1.18.037-2.09 1.022-2.09 2.201v.916m7.5 0a48.667 48.667 0 00-7.5 0" />
</svg>
"""
    let confirm = """
<svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
  <path stroke-linecap="round" stroke-linejoin="round" d="M3 13.5l6.785 6.785A48.1 48.1 0 0121 4.143" />
</svg>
"""