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




    

console.log $"time= {thisTime.toLocaleString ()}"

// let root = document.createElement "div"
// root.id <-"root"
// document.body.appendChild root
