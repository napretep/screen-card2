let btn = document.createElement("button")
btn.innerText="screen cap"
document.body.appendChild(btn)

btn.onclick=(e)=>{
    chrome.runtime.sendMessage({purpose:"screenCap"})
}

chrome.runtime.onMessage.addListener((msg)=>{
    if(msg.purpose  && msg.purpose==="screenCap" ){
        if(msg.status) {
            console.log(msg.data)
        }
        else{
            console.log("screen cap failed")
        }
    }
})
