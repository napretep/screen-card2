// import html2canvas from "html2canvas"
// (()=>{
window.onload = (e) => {
    let div = document.createElement("div")
    div.classList.add(".cardField_self")
    div.style.minHeight = "70px"

    let msg = {
        moveBegin: false
    }
    let state = {
        ismoving: false,
        beginY: -1,
        beginTop: -1,
        movingEl: div,
    }
    let body = document.querySelector("#card_body")
    let kids = [].slice.call(body.children, 0)

    let midlist = () => {
        return [].map.call(kids, (e) => {
            let r = e.getBoundingClientRect()
            // return [r.top,,r.bottom]
            return {top:r.top,bottom:r.bottom,mid:(r.top+r.bottom)/2,element:e}
        })
    }

    kids.map((x) => {
            x.onmousedown = (e) => {
                x.insertAdjacentElement("afterend",div)
                x.style.zIndex = "999"
                x.style.top = `calc(${x.offsetTop}px - ${getComputedStyle(x).marginTop} - ${x.parentElement.scrollTop}px)`
                x.style.position = "absolute"
                state.beginY = e.clientY
                state.beginTop = x.style.top.replace(/\D/g, "") - 0
                state.ismoving = true
                state.movingEl = x
            }


        }
    )


    let Y = -1
    let scroll = (Y2) => {
        let bodyTop = body.getBoundingClientRect().top
        let bodyBottom = body.getBoundingClientRect().bottom

        if (bodyTop < Y2 && Y2 - bodyTop < 20 && body.scrollTop > 0) {
            body.scrollTo(0, body.scrollTop - 1)


            setTimeout(() => {
                if (Math.abs(Y2 - Y) < 3) {
                    scroll(Y)
                }
            }, 20)
        }
        if (bodyBottom > Y2 && bodyBottom - Y2 < 20 && body.scrollHeight - body.scrollTop - body.clientHeight > 0) {
            body.scrollTo(0, body.scrollTop + 1)
            setTimeout(() => {
                if (Math.abs(Y2 - Y) < 3) {
                    scroll(Y)
                }
            }, 20)
        }
    }


    window.onmousemove = (e) => {
        // console.log(e.target)
        e.button
        if (state.ismoving && e.buttons===1) {
            let rr  = midlist()
            let el = state.movingEl
            let elTop = el.getBoundingClientRect().top
            let elBottom = el.getBoundingClientRect().bottom

            Y = e.clientY
            for (let j of rr) {
                let jTop = j.element.getBoundingClientRect().top
                let jBottom =j.element.getBoundingClientRect().bottom
                let jMid = (jTop+jBottom)/2
                if (elTop<jMid && elBottom>jBottom){
                    j.element.insertAdjacentElement("beforebegin",div)
                }
                if (elBottom>jMid && elTop<jTop){
                    j.element.insertAdjacentElement("afterend",div)
                }

            }
            scroll(Y)

            state.movingEl.style.top = `${state.beginTop+ e.clientY-state.beginY}px`
        }

    }
    window.onmouseup = (e)=>{
        if (state.ismoving){
            let x= state.movingEl
            state.ismoving = false
            x.style.position = ""
            x.style.zIndex = ""
            body.replaceChild(x, div)
        }
    }



}



// }})()