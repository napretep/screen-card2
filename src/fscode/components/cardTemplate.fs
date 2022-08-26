module app.components.cardTemplate

open System
open Fable.Core
open Fable.React.ReactiveComponents
open Feliz
open Feliz.DaisyUI
open Feliz.style
open Microsoft.FSharp.Collections
open app.common
open funcs
open obj
open styleSheet
open cssClass
// [<Measure>] type percent = length.percent
let px (i: int) = length.px i
let percent (i: int) = length.percent i
let calc (i: string) = length.calc i

[<RequireQualifiedAccess>]
module Card =
  [<RequireQualifiedAccess>]
  type Msg = | None

  type Record =
    { guid: string
      content: string
      kind: Kind
      from: string
      createTime: float
      lastModifiedTime: float
      geometry : Geometry.Rect
      }
    static member Standard =
      { guid = newGuid ()
        content = "this is default"
        kind = Text
        from = ""
        createTime = thisTime.valueOf ()
        lastModifiedTime = thisTime.valueOf ()
        geometry = Geometry.Rect.Init (30, 30, 300, 300)
         }

    static member TextDefault = Record.Standard

    static member PicDefault =
      { Record.Standard with
          content = URL.logo
          kind = Pic }

  and [<StringEnum>] Kind =
    | Text
    | Pic




  type Model =
    { records: Record list
      pined: bool
      guid: string
      geometry: Rect
      createTime: float
      lastModifiedTime: float
      }
    static member Default =
      { records =
          [ Record.TextDefault
            Record.PicDefault ]
        pined = false
        guid = newGuid ()
        geometry = Rect.Default
        createTime = thisTime.valueOf ()
        lastModifiedTime = thisTime.valueOf ()
        }

  and Rect =
    { top: int
      left: int
      width: int
      height: int }
    static member Default =
      { top = 30
        left = 30
        width = 30
        height = 30 }

  let init () = Model.Default

  let update model msg = init ()


  let view (model: Model) dispatch =
    let textForm =
      Daisy.formControl [ Daisy.textarea [ prop.defaultValue model.records[0].content
                                           prop.className "h-24"
                                           textarea.bordered ] ]

    let renderPic =
      Html.figure [ prop.style [ style.width (length.percent 40)

                                  ]
                    prop.children [ Html.img [ prop.style [ style.width (200) ]
                                               prop.src model.records[1].content ] ] ]

    let inline textBtn (top: ^a, left: ^b, text: string, callback: (^e -> unit) option) =
      Html.a [ prop.style [ position.absolute
                            style.top top
                            style.left left
                            cursor.pointer ]
               prop.text text
               if callback.IsSome then
                 prop.onClick callback.Value ]

    Daisy.card [ prop.classes (AsStr [ "card-side"; ``Common-glass`` ])
                 prop.style [ backgroundColor.transparent ]
                 card.bordered
                 prop.children [ textBtn (px 0, px 0, "❌", None)
                                 textBtn (px 0, calc ("100% - 19px"), "📌", None)
                                 if model.records[1].content <> "" then
                                   renderPic
                                 Daisy.cardBody [ Daisy.cardTitle model.records[0].content
                                                  textForm ] ] ]
