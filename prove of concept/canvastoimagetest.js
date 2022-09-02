
let imagess= document.getElementById('image');
let canvasss = document.createElement("canvas")
let contextss = canvasss.getContext("2d")
contextss.drawImage(imagess,0,0,100,100)
contextss.clip()
document.body.appendChild(canvasss)