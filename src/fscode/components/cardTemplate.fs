module app.components.cardTemplate
open Fable.Core
open Fable.React.ReactiveComponents
open Feliz
open Feliz.DaisyUI
open Feliz.style
open app.common
open funcs
open obj
open styleSheet
open cssClass
// [<Measure>] type percent = length.percent
let px (i:int) = length.px i
let percent (i:int) = length.percent i
let calc  (i:string) = length.calc i
[<RequireQualifiedAccess>]
module Card =
    [<RequireQualifiedAccess>]
    type Msg = |None
    type Model = {
        picPath:string option
        text:string option
        title:string
        srcSite:string
        pined:bool
        geometry:Rect
        createTime:int
        lastModifiedTime:int
    }
    and Rect ={
        top:int
        left:int
        width:int
        height:int
    }
    let init () =
        {picPath=Some URL.logo
         text=Some "this is text!"
         title="website name"
         srcSite=""
         pined=true
         createTime=0
         lastModifiedTime=0
         geometry={
             top=50 // percent
             left= 50 // percent
             width=300
             height=100
         }}
    let update model msg = init()
    

    let view (model:Model) dispatch =
        let textForm =
            Daisy.formControl [
            Daisy.textarea [
                prop.defaultValue model.text.Value
                prop.className "h-24"
                textarea.bordered
            ]
        ]
        
        let renderPic  =
            Html.figure [
                prop.style [
                    style.width (length.percent 40)
                
                ]
                prop.children [
                    Html.img [
                        prop.style [
                            style.width ( 200)
                        ]
                        prop.src model.picPath.Value
                    ]
                ]
            ]
        let inline textBtn (top:^a, left:^b, text:string, callback:(^e->unit) option)  =
            Html.a [
                prop.style [
                    position.absolute
                    style.top top
                    style.left left
                    cursor.pointer
                ]
                prop.text text
                if callback.IsSome then prop.onClick callback.Value  
            ]

        Daisy.card [
            prop.classes (AsStr ["card-side";``Common-backdropBlur``])
            prop.style [
                backgroundColor.transparent
            ]
            card.bordered
            prop.children [
                textBtn (px 0,px 0, "❌", None)
                textBtn (px 0,calc("100% - 19px"),"📌",None)
                if model.picPath.IsSome then renderPic  
                Daisy.cardBody [
                    Daisy.cardTitle model.title
                    textForm
                ]
            ]
        ]