module app.common.funcs

open System.Text.RegularExpressions

open System
open Browser.Types
open Browser
open Browser.Dom
open Browser.Css
open Chrome
open Microsoft.FSharp.Core
open Fable.Core.JsInterop
open Option
open Fable.Core
open Fable.Core.JS
open app.common.obj
open app.common.obj.Geometry
open app.common.styleSheet
open FSharp.Collections

[<Emit("new Date()")>]
let thisTime:Date = jsNative

// module Cmd =
//     let fromAsync (operation: Async<'msg>) : Cmd<'msg> =
//         let delayedCmd (dispatch: 'msg -> unit) : unit =
//             let delayedDispatch = async {
//                 let! msg = operation
//                 dispatch msg
//             }
//
//             Async.StartImmediate delayedDispatch
//
//         Cmd.ofSub delayedCmd


let pipConsoleLog msg = console.log msg
type Pip =
    // static member setValue (target: string with get, set) value = target<-value
    static member withIgnore f = f |> ignore
    static member alert msg =window.alert msg
    static member log msg = console.log msg
let mutable x = 1
let kv (k: string) v : obj = createObj [ $"{k}" ==> v ]


type Obj =
    static member inline create(dict: seq<string * 'a>) =
        dict
        |> Seq.map (fun (k, v) -> $"{k}" ==> v)
        |> Seq.toList
        |> createObj

let rec untilTabCompleteThenSend (tabId:float) (msg:RuntimeMsgHeader)=
    chromeTabs.get(tabId).``then``(
        fun (tab) ->
            match tab.status with
            |Some "complete" ->
                chromeTabs.sendMessage(tabId,msg)
            |_->
                setTimeout (fun ()->untilTabCompleteThenSend tabId msg |> ignore ) 500 |> ignore
                ()
    )


type Series =
    // static member SeqToList seq_ = seq_|>Seq.map id |> List.ofSeq
    // 由于Seq是惰性求值, 在一些js环境下不适用, 而List是贪婪求值,适用于js环境,
    // Seq的类型范围很广, 而List的类型限制严格于Seq, 无法直接使用
    // 结合两者的特点, 可以将迭代序列通过 Seq转换成Seq序列再转换成List序列,再用List的map
    static member map f seq_ = seq_ |> Seq.toList |> List.map f

type ChromeMsg = 
    static member To (info:RuntimeMsgHeader) =
        let msg =
            info.senderDetail
            |> bind (fun x-> x.tab)
            |> bind (fun x-> Some {info with Id = x.id})
            |> defaultValue info 
        match msg.receiver with
        |Tab ->
            match msg.Id with
            |Some Id-> (Id,msg) ||> ChromeMsg.UntilTargetTabCompleteThenSend 
            |_ -> info |> ChromeMsg.UntilCurrentTabExistThenSend  
        |_ -> info |> chromeRuntime.sendMessage |> ignore
    static member UntilCurrentTabExistThenSend (msg:RuntimeMsgHeader) =
        chromeTabs.query(!!{| active= true; currentWindow= true |}).``then``(
            fun tabArray->
                match tabArray.Count with
                |0 -> setTimeout (fun ()->
                    console.log "setTimeout UntilCurrentTabExistThenSend "
                    ChromeMsg.UntilCurrentTabExistThenSend msg |> ignore ) 600 |> ignore
                |_ -> let tab = tabArray.[0]
                      chromeTabs.sendMessage(tab.id.Value,msg)|> ignore
            )|> ignore
        
        
    static member UntilTargetTabCompleteThenSend (tabId:float) (msg:RuntimeMsgHeader)=
        chromeTabs.get(tabId).``then``(
            fun (tab) ->
                match tab.status with
                |Some "complete" -> chromeTabs.sendMessage(tabId,msg) |> ignore
                |_-> setTimeout (fun ()->ChromeMsg.UntilTargetTabCompleteThenSend tabId msg |> ignore ) 200 |> ignore
        )|>ignore
    static member ToTabById (tabId: float) (header: RuntimeMsgHeader) =
       
        ChromeMsg.UntilTargetTabCompleteThenSend tabId header
    
    static member ToAllTab(info: RuntimeMsgHeader) =
        let q: Chrome.Tabs.QueryInfo =
            !!{| status = "complete"
                 windowType = "normal" |}

        chromeTabs.query (
            q,
            fun selectedTab ->
                selectedTab |> pipConsoleLog

                selectedTab
                |> Series.map (fun tab -> chromeTabs.sendMessage (tab.id.Value, info))
                |> ignore

                ()
        )

    static member ReceivedCallback (receiver: RuntimeMsgActor) (f: RuntimeMsgHeader -> unit) =
        let wrapper f =
            fun (msg: obj option) (sender: Chrome.Runtime.MessageSender option) (res: (obj -> unit) option) ->
                match msg with
                | Some valuedMsg ->
                    let valuedMsg = valuedMsg :?> RuntimeMsgHeader
                    match valuedMsg.format with
                    | Standard -> f { valuedMsg with senderDetail = sender; callback = res }
                    | _ -> //只有standard一种类型,如果不匹配,那肯定是 valuedMsg.format == undefined, 就要尝试用其他类型
                        "unknown type message:" |> pipConsoleLog
                        msg |> pipConsoleLog
                | _ -> "unsupported message" |> pipConsoleLog

        Action<obj option, Chrome.Runtime.MessageSender option, (obj -> unit) option>(wrapper f)

    static member ToBackEnd (sender: RuntimeMsgActor) (info: RuntimeMsg) =
        let msg =
            { RuntimeMsgHeader.backendAsReceiver with
                sender = sender
                content = info }
        msg |> chromeRuntime.sendMessage |> ignore
        ()

    static member ToPopup (sender: RuntimeMsgActor) (info: RuntimeMsg) =
        let msg =
            { RuntimeMsgHeader.popupAsReceiver with
                sender = sender
                content = info }
        // console.log ("send begin data= "+msg.ToString())
        msg |> chromeRuntime.sendMessage |> ignore
        ()

type Test =
    static member AddButton(root: HTMLElement, btnName: string, callback: obj -> unit) =
        let btn = document.createElement "button"
        btn.innerText <- btnName
        btn.onclick <- callback
        btn |> root.appendChild |> ignore
        ()


type TabEventHandleWrapper =
    static member OnUpdate(f: 'a -> 'b -> 'c -> unit) = Action<_, _, _>(f)


let AsStr  (li:CssClass seq) =
        li|> Seq.map (fun e-> e.ToString())|> Seq.toList


// let Div classes kids =  createEl Html.div classes kids


let newGuid() = Guid.NewGuid().ToString().Replace("-","")[0..15]

let (==) (input:string list) (preset:string) =
        input|>Seq.fold (fun sum ->Some) None |>Option.defaultValue preset

let getFloat s = float (Regex("\d+").Match(s).Value)

type pointF with
    static member fromElementStyle (el:HTMLElement) =
        {left =getFloat el.style.left;top=getFloat el.style.top}
    static member fromElementBounding (el:HTMLElement)=
            let r= el.getBoundingClientRect()
            {left=r.left; top = r.top}
    static member fromMouseEvent (e:MouseEvent) =
            pointF.set e.clientX e.clientY
    static member fromTuple (t:float*float)=
        {left=fst t ; top = snd t}
    static member setElementPosition (el:HTMLElement) (p:pointF)= 
        el.style.left <- $"{p.left}px"
        el.style.top <- $"{p.top}px"
    static member zero = pointF.set 0 0
    
    
type size2d with
    static member setElementStyleSize  (el:HTMLElement) (size:size2d)=
        el.style.width <- $"{size.width}px"
        el.style.height <- $"{size.height}px"
    static member zero = {width=0;height=0}
    static member fromElementBounding (el:HTMLElement) =
        let r = el.getBoundingClientRect()
        {
            width=r.width
            height=r.height
        }
type Rect with
    static member setElementGeometry  (e:HTMLElement) (rect:Rect) =
        pointF.setElementPosition e rect.Point
        size2d.setElementStyleSize e rect.Size
    static member zero = Rect.fromPoint_Size pointF.zero size2d.zero
    



type Op_element =
    static member addMask (E:HTMLElement) =
        E.classList.add Common_mask.S
        E
    static member delMask (E:HTMLElement) =
        E.classList.remove [|Common_mask.S|]
        E
    static member addFixed (E:HTMLElement) =
        E.style.position <- "fixed"
        E
    static member delFixed (E:HTMLElement) =
        E.style.position <- ""
        E
    static member displayNone  (E:HTMLElement) = 
        E.style.display <-"none"
        E
    static member displayNonNone (e:HTMLElement)=
        e.style.display <-""
        e
    static member switchClass  (E:HTMLElement) add remove =
        E.classList.remove remove
        E.classList.add add
