chrome.runtime.onMessage.addListener(
    (msg)=>{
        if(msg.purpose && msg.purpose === "screenCap"){

            chrome.tabs.query({currentWindow:true,active:true}).then((tabs)=>{
                chrome.tabs.captureVisibleTab().then(
                    (data)=>{
                        console.log(data)
                        chrome.tabs.sendMessage(tabs[0].id,{purpose:"screenCap",status:true,data:data})},
                    (data)=>{chrome.tabs.sendMessage(tabs[0].id,{purpose:"screenCap",status:false,data:null})}

                )
            })

        }
    }
)