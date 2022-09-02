module app

open Feliz
open Elmish
open Elmish.React
open Browser.Dom
open DaisyUI.Daisy
open Feliz.DaisyUI
open app.common.obj
open app.common.funcs
let ToTabHeader =
    { RuntimeMsgHeader.tabAsReceiver with sender = Popup }

let ToBackendHeader =
    { RuntimeMsgHeader.backendAsReceiver with sender = Popup }

let MsgReceivedCallback callback =
    ChromeMsg.ReceivedCallback RuntimeMsgActor.Popup callback




    

console.log $"time= {thisTime.toLocaleString ()}"

// let root = document.createElement "div"
// root.id <-"root"
// document.body.appendChild root
type Msg= |DoNoThing|ToggleAssistDot
type Model={
    showAssistDot:bool
}
let DaisyStyleEl = document.createElement "style"
let TailWindStyleEl =  document.createElement "style"
// let TailWindScriptEl = document.createElement "script"
//
let appEntrance =  document.createElement "div"
appEntrance.id <- "root"
//
// fetchContent URL.TailWindJS TailWindScriptEl |> ignore
fetchContent URL.DaisyUICSS DaisyStyleEl |> ignore
fetchContent URL.TailwindCSS TailWindStyleEl |> ignore
let body = document.body
// body.appendChild TailWindScriptEl |> ignore
body.appendChild TailWindStyleEl |> ignore
body.appendChild DaisyStyleEl |> ignore
body.appendChild appEntrance |> ignore
let init () = {showAssistDot=true},Cmd.none
let update msg (model: Model):Model*Cmd<Msg>  =
   match msg with
   |ToggleAssistDot -> {model with showAssistDot= not model.showAssistDot},Cmd.none

let popupCard (model:Model) dispatch  =
    Daisy.card [
    theme.wireframe
    card.full
    prop.children [
        
        Html.figure [Html.img [prop.src $"{URL.logo}"
                               prop.className "filter-blur-30"
                               prop.style [
                                   style.maxWidth 300
                               ]
                               ]]
        Daisy.cardBody [
            Html.h2 "Screen.Card 使用说明"
            Html.li "钉住卡片后,它会自动跟随你到任何tab"
            Html.li [
                     prop.children
                        [
                            Html.span "截屏制卡快捷键-"
                            Daisy.kbd "ctrl"
                            Html.span "+"
                            Daisy.kbd "shift"
                            Html.span "+"
                            Daisy.kbd "del" 
                        ]
                     ]
            Html.li "鼠标选取文本,即可选择插入新卡或旧卡"
            Html.li "点击页面中assistDot上的📚可以打开卡片库,查看保存的卡片"
            Html.li "当前页面下点assistDot上的❌,可以临时关闭它"
            Html.li "若想完全关闭assistDot,请使用下面的全局开关"

            Daisy.label [
                Daisy.labelText  $"""assistDot 全局{if model.showAssistDot then "显示" else "关闭" }"""
                Daisy.toggle [prop.defaultChecked model.showAssistDot
                              prop.onClick (fun _->dispatch ToggleAssistDot)
                              ]
            ]
        ]
    ]
]


let render (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        
        prop.style [
            style.width 500
        ]
        prop.children[
            Html.style "li{font-size:15px;}
            .card{border-radius:0px!important;}
            .filter-blur-30{
                filter:blur(7px)!important
            }
            "
            popupCard model dispatch
        ]
]

Program.mkProgram init update render
|> Program.withReactSynchronous "root"
|> Program.run
