module app.common.obj
open System.Collections.Generic
open Browser.Types
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
let [<Global("chrome.windows")>] chromeWindows:Chrome.Windows.IExports = jsNative
let [<Global("chrome.extension")>] chromeExtension:Chrome.Extension.IExports = jsNative
let [<Global("chrome.action")>] chromeAction:Chrome.Action.IExports = jsNative
let [<Global("chrome.storage")>] chromeStorage:Chrome.Storage.IExports = jsNative
module TabInfo =
    type tabId = float
type runtimeState = unit
type storage = Dictionary<string,obj>
type [<StringEnum>] RuntimeMsgActor = |Tab|Popup|Backend
type [<StringEnum>] RuntimeMsgFormat = |Standard|Other
type [<StringEnum>] RuntimeMsgPurpose = |ShowContent|UserActivatedThisPage|GetStorage|TabLoaded|Call|Other|ScreenCapRequest|ScreenCapOK|ScreenCapNo
type RuntimeMsg = 
     { purpose:RuntimeMsgPurpose option
       callback :(obj->unit) option
       content:obj }
     static member Default ={
        callback = None
        purpose = None
        content =""}
type Time= |Created of float|LastEdit of float
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
    let (==) (input:string list) (preset:string) =
        input|>Seq.fold (fun sum next->Some next) None |>Option.defaultValue preset

    let close =
        let fill= "#d81e06"
        $"""
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M8 8L40 40" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M8 40L40 8" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
"""
    let trashBin = """
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M15 12L16.2 5H31.8L33 12" stroke="#333" stroke-width="4" stroke-linejoin="round"/><path d="M6 12H42" stroke="#333" stroke-width="4" stroke-linecap="round"/><path fill-rule="evenodd" clip-rule="evenodd" d="M37 12L35 43H13L11 12H37Z" fill="none" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M19 35H29" stroke="#333" stroke-width="4" stroke-linecap="round"/></svg>"""
    let confirm = """
<svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
  <path stroke-linecap="round" stroke-linejoin="round" d="M3 13.5l6.785 6.785A48.1 48.1 0 0121 4.143" />
</svg>
"""
    let plus  =
        let fill=  "#000000" 
        $"""
<svg t="1661620628142" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="2126" width="20" height="20"><path d="M576 64H448v384H64v128h384v384h128V576h384V448H576z" fill="{fill}" p-id="2127"></path></svg>
"""
    let newClip  =
        let fill= "#000000" 
        $"""
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M12 4V36H44" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M20 12H36V28" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M12 12H4" stroke="#333" stroke-width="4" stroke-linecap="round"/><path d="M36 44V36" stroke="#333" stroke-width="4" stroke-linecap="round"/></svg>
""" 
    let newText =
        let fill= "#000000" 
        $"""
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M44 7H4V37H19L24 42L29 37H44V7Z" fill="none" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M14 16H20" stroke="#333" stroke-width="4" stroke-linecap="round"/><path d="M14 24H16" stroke="#333" stroke-width="4" stroke-linecap="round"/><path d="M29 14L36 28" stroke="#333" stroke-width="4" stroke-linecap="round"/><path d="M28.9998 13.9998L21.9998 27.9998" stroke="#333" stroke-width="4" stroke-linecap="round"/><path d="M24 24H34" stroke="#333" stroke-width="4" stroke-linecap="round"/></svg>""" 
    let VerticalMoveBar  =
        let fill=  "#000000" 
        $"""
        <svg t="1661552308179" class="" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="1637" width=20 height=20><path d="M384 768C348.653776 768 320 796.653776 320 832 320 867.346224 348.653776 896 384 896 419.346224 896 448 867.346224 448 832 448 796.653776 419.346224 768 384 768ZM384 448C348.653776 448 320 476.653776 320 512 320 547.346224 348.653776 576 384 576 419.346224 576 448 547.346224 448 512 448 476.653776 419.346224 448 384 448ZM384 128C348.653776 128 320 156.653779 320 192 320 227.346221 348.653776 256 384 256 419.346224 256 448 227.346221 448 192 448 156.653779 419.346224 128 384 128ZM640 768C604.653776 768 576 796.653776 576 832 576 867.346224 604.653776 896 640 896 675.346221 896 704 867.346224 704 832 704 796.653776 675.346221 768 640 768ZM640 448C604.653776 448 576 476.653776 576 512 576 547.346224 604.653776 576 640 576 675.346221 576 704 547.346224 704 512 704 476.653776 675.346221 448 640 448ZM640 128C604.653776 128 576 156.653779 576 192 576 227.346221 604.653776 256 640 256 675.346221 256 704 227.346221 704 192 704 156.653779 675.346221 128 640 128Z" p-id="1638" fill="{fill}"></path></svg>
"""
    let HorizontalMoveBar =
        let fill="#000000"
        $"""
        <svg t="1661605011102" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="1476" width="20" height="20"><path d="M219.428571 585.142857c-36.571429 0-73.142857 36.571429-73.142857 73.142857s36.571429 73.142857 73.142857 73.142857 73.142857-36.571429 73.142858-73.142857-36.571429-73.142857-73.142858-73.142857z m585.142858-146.285714c36.571429 0 73.142857-36.571429 73.142857-73.142857s-36.571429-73.142857-73.142857-73.142857-73.142857 36.571429-73.142858 73.142857 36.571429 73.142857 73.142858 73.142857zM219.428571 292.571429c-36.571429 0-73.142857 36.571429-73.142857 73.142857s36.571429 73.142857 73.142857 73.142857 73.142857-36.571429 73.142858-73.142857-36.571429-73.142857-73.142858-73.142857z m585.142858 292.571428c-36.571429 0-73.142857 36.571429-73.142858 73.142857s36.571429 73.142857 73.142858 73.142857 73.142857-36.571429 73.142857-73.142857-36.571429-73.142857-73.142857-73.142857zM512 292.571429c-36.571429 0-73.142857 36.571429-73.142857 73.142857s36.571429 73.142857 73.142857 73.142857 73.142857-36.571429 73.142857-73.142857-36.571429-73.142857-73.142857-73.142857z m0 292.571428c-36.571429 0-73.142857 36.571429-73.142857 73.142857s36.571429 73.142857 73.142857 73.142857 73.142857-36.571429 73.142857-73.142857-36.571429-73.142857-73.142857-73.142857z" fill={fill} p-id="1477"></path></svg>"""
    let bookshelf =
        $"""
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M32 6H22V42H32V6Z" fill="none" stroke="#333" stroke-width="4" stroke-linejoin="round"/><path d="M42 6H32V42H42V6Z" fill="none" stroke="#333" stroke-width="4" stroke-linejoin="round"/><path d="M10 6L18 7L14.5 42L6 41L10 6Z" fill="none" stroke="#333" stroke-width="4" stroke-linejoin="round"/><path d="M37 18V15" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M27 18V15" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
"""
    let newCard  =
        let fill="#000000"
        $"""<svg t="1661606812396" class="" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="9804" width="20" height="20" fill="#000000"><path d="M938.666667 810.666667H682.666667c-12.8 0-21.333333-8.533333-21.333334-21.333334s8.533333-21.333333 21.333334-21.333333h256c12.8 0 21.333333 8.533333 21.333333 21.333333s-8.533333 21.333333-21.333333 21.333334z" p-id="9805"></path><path d="M810.666667 938.666667c-12.8 0-21.333333-8.533333-21.333334-21.333334V661.333333c0-12.8 8.533333-21.333333 21.333334-21.333333s21.333333 8.533333 21.333333 21.333333v256c0 12.8-8.533333 21.333333-21.333333 21.333334zM552.533333 938.666667H128c-12.8 0-21.333333-8.533333-21.333333-21.333334V106.666667c0-12.8 8.533333-21.333333 21.333333-21.333334h469.333333c6.4 0 10.666667 2.133333 14.933334 6.4l213.333333 213.333334c4.266667 4.266667 6.4 8.533333 6.4 14.933333v213.333333c0 12.8-8.533333 21.333333-21.333333 21.333334s-21.333333-8.533333-21.333334-21.333334v-204.8L588.8 128H149.333333v768h403.2c12.8 0 21.333333 8.533333 21.333334 21.333333s-8.533333 21.333333-21.333334 21.333334z" p-id="9806"></path><path d="M810.666667 341.333333H597.333333c-12.8 0-21.333333-8.533333-21.333333-21.333333V106.666667c0-8.533333 4.266667-17.066667 12.8-19.2 8.533333-4.266667 17.066667-2.133333 23.466667 4.266666l213.333333 213.333334c6.4 6.4 8.533333 14.933333 4.266667 23.466666-2.133333 8.533333-10.666667 12.8-19.2 12.8z m-192-42.666666h140.8L618.666667 157.866667V298.666667zM341.333333 341.333333h-85.333333c-12.8 0-21.333333-8.533333-21.333333-21.333333v-85.333333c0-12.8 8.533333-21.333333 21.333333-21.333334h85.333333c12.8 0 21.333333 8.533333 21.333334 21.333334v85.333333c0 12.8-8.533333 21.333333-21.333334 21.333333z m-64-42.666666h42.666667v-42.666667h-42.666667v42.666667zM341.333333 554.666667h-85.333333c-12.8 0-21.333333-8.533333-21.333333-21.333334v-85.333333c0-12.8 8.533333-21.333333 21.333333-21.333333h85.333333c12.8 0 21.333333 8.533333 21.333334 21.333333v85.333333c0 12.8-8.533333 21.333333-21.333334 21.333334z m-64-42.666667h42.666667v-42.666667h-42.666667v42.666667zM341.333333 768h-85.333333c-12.8 0-21.333333-8.533333-21.333333-21.333333v-85.333334c0-12.8 8.533333-21.333333 21.333333-21.333333h85.333333c12.8 0 21.333333 8.533333 21.333334 21.333333v85.333334c0 12.8-8.533333 21.333333-21.333334 21.333333z m-64-42.666667h42.666667v-42.666666h-42.666667v42.666666zM640 512h-170.666667c-12.8 0-21.333333-8.533333-21.333333-21.333333s8.533333-21.333333 21.333333-21.333334h170.666667c12.8 0 21.333333 8.533333 21.333333 21.333334s-8.533333 21.333333-21.333333 21.333333zM554.666667 725.333333h-85.333334c-12.8 0-21.333333-8.533333-21.333333-21.333333s8.533333-21.333333 21.333333-21.333333h85.333334c12.8 0 21.333333 8.533333 21.333333 21.333333s-8.533333 21.333333-21.333333 21.333333z" fill="{fill}" p-id="9807"></path></svg>"""

    let expand  =
        
        $"""
        <?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M22 42H6V26" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M26 6H42V22" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
        """

    let search (color:string list) =
        let fill = color =="#000000"
        $"""
        <svg t="1661722516265" class="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="1627" width="20" height="20"><path d="M954.4 813.952l-137.664-180.288c48.832-46.656 79.456-112.224 79.456-184.928 0-141.152-114.848-256-256-256s-256 114.848-256 256 114.848 256 256 256c45.472 0 88.096-12.032 125.152-32.896l138.144 180.928c6.304 8.256 15.808 12.608 25.472 12.608 6.752 0 13.6-2.112 19.36-6.56C962.432 848.064 965.12 827.968 954.4 813.952zM448.224 448.704c0-105.888 86.112-192 192-192s192 86.112 192 192-86.112 192-192 192S448.224 554.592 448.224 448.704z" p-id="1628"></path><path d="M320 320 128 320c-17.664 0-32-14.336-32-32s14.336-32 32-32l192 0c17.664 0 32 14.336 32 32S337.664 320 320 320z" p-id="1629"></path><path d="M256 576 128 576c-17.664 0-32-14.304-32-32 0-17.664 14.336-32 32-32l128 0c17.664 0 32 14.336 32 32C288 561.696 273.664 576 256 576z" p-id="1630"></path><path d="M480 800 128 800c-17.664 0-32-14.304-32-32s14.336-32 32-32l352 0c17.664 0 32 14.304 32 32S497.664 800 480 800z"fill="{fill}"  p-id="1631"></path></svg>
        """

    let pin  =
        let fill = "#000000"
        $"""
        <?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M32 4H16L20 7L16 20C16 20 10 24 10 28H20L24 44L28 28H38C38 24 34 21.1667 32 20L28 7L32 4Z" fill="none" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
        """
    
    let link = """
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M24 12V4H40V12" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M40 36V44H24V36" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M24 24L4 24" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M32 34V14" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M12 16L4 24L12 32" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
"""
    let backlink ="""

<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M43 5L29.7 43L22.1 25.9L5 18.3L43 5Z" stroke="#333" stroke-width="4" stroke-linejoin="round"/><path d="M43.0001 5L22.1001 25.9" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
"""

    let powerOff = """
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M14.5 8C13.8406 8.37652 13.2062 8.79103 12.6 9.24051C11.5625 10.0097 10.6074 10.8814 9.75 11.8402C6.79377 15.1463 5 19.4891 5 24.2455C5 34.6033 13.5066 43 24 43C34.4934 43 43 34.6033 43 24.2455C43 19.4891 41.2062 15.1463 38.25 11.8402C37.3926 10.8814 36.4375 10.0097 35.4 9.24051C34.7938 8.79103 34.1594 8.37652 33.5 8" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M24 4V24" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>

"""
    
    let del = """

<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M14 11L4 24L14 37H44V11H14Z" fill="none" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M21 19L31 29" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M31 19L21 29" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></svg>
"""

    let swing ="""
<?xml version="1.0" encoding="UTF-8"?><svg width="24" height="24" viewBox="0 0 48 48" fill="none" xmlns="http://www.w3.org/2000/svg"><g clip-path="url(#icon-459572631d008894)"><path d="M9.99985 35.9998C8.00079 32.4998 7.99899 25.9998 7.99975 16.9998C8.00001 13.9998 11.9995 12.9998 13.9993 15.9998C15.1072 17.6617 15.8159 22.264 15.8159 22.264L22.3109 11.0145C23.0068 9.80903 24.5483 9.396 25.7538 10.092C26.9593 10.788 27.3723 12.3294 26.6763 13.5349L27.0641 12.8633C27.7601 11.6578 29.3015 11.2448 30.507 11.9408C31.7125 12.6368 32.1256 14.1783 31.4296 15.3838L31.0418 16.0554C31.7378 14.8499 33.2793 14.4368 34.4848 15.1328C35.6903 15.8288 36.1033 17.3703 35.4073 18.5758L33.8549 21.2646C34.5517 20.0578 36.0948 19.6443 37.3016 20.3411C38.5066 21.0367 38.921 22.5765 38.2279 23.783L29.0588 39.745C28.9612 39.9148 28.8614 40.0815 28.7382 40.2337C28.1666 40.9395 26.1434 42.9998 21.9999 42.9998C17.3408 42.9998 12.4782 40.339 9.99985 35.9998Z" fill="none" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/><path d="M37 5C38.3788 5.73333 40.5055 6.75828 42 9C43 10.5 43.5 12.5 43.7908 15" stroke="#333" stroke-width="4" stroke-linecap="round" stroke-linejoin="round"/></g><defs><clipPath id="icon-459572631d008894"><rect width="48" height="48" fill="#333"/></clipPath></defs></svg>
"""
module Geometry =


    type pointF={
        left:float
        top:float 
    }
    with
        
        static member set left top =
            {left=left;top=top}
        static member getElement_TL_BR_as4Tuple (e:HTMLElement) =
            let r = e.getBoundingClientRect()
            (r.left,r.top,r.right,r.bottom)
        member this.ToPx =
            ($"{this.left}px",$"{this.top}px")
        member this.toTuple =
            (this.left,this.top)
        static member (-) (a:pointF,b:pointF) =
            {
                left = a.left-b.left
                top = a.top-b.top
            }
        static member (+) (a:pointF,b:pointF) =
            {
                left = a.left+b.left
                top = a.top+b.top
            }    
    type size2d ={
        width:float
        height:float
    }
    with
        static member set w h = {
            width = w
            height = h
        }
        static member from2Point (start:pointF) (end':pointF) =
            size2d.set (end'.left - start.left) (end'.top-start.top)
        static member fromTuple (t:float*float) =
            size2d.set (fst t) (snd t)
        member this.toTuple = (this.width,this.height)
        
    type Rect ={
        top:float
        left:float
        width:float
        height:float
    }
    with
        static member set x y w h =
            {
                left = x
                top = y
                width = w
                height = h
            }
        static member fromPoint_Size (p:pointF) (s:size2d) =
            Rect.set p.left p.top s.width s.height
        static member fromElement (e:HTMLElement) =
            let r = e.getBoundingClientRect()
            Rect.set r.left r.top r.width r.height
        member this.Point = pointF.set this.left this.top
        member this.Size = size2d.set this.width this.height
        
