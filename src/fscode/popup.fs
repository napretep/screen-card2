module app

open Browser.Dom
open app.common.obj
open app.common.funcs
let ToTabHeader =
    { RuntimeMsgHeader.tabAsReceiver with sender = Popup }

let ToBackendHeader =
    { RuntimeMsgHeader.backendAsReceiver with sender = Popup }

let MsgReceivedCallback callback =
    ChromeMsg.ReceivedCallback RuntimeMsgActor.Popup callback



//
// let (:=) <'T,'F>(a:seq<'T>) = a|>Seq.map (fun e->e:>'F)
   
    

console.log $"time= {thisTime.toLocaleString ()}"

// let root = document.createElement "div"
// root.id <-"root"
// document.body.appendChild root
//
// let a:string list = []
// let b = unbox<obj list> a