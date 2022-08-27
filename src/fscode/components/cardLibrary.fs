module app.components.cardLibrary

open Feliz
open DaisyUI.Daisy

open Feliz.DaisyUI
open app.common
open app.common.obj
open app.common.styleSheet
open cardTemplate
open funcs
open styleSheet


[<RequireQualifiedAccess>]
module CardLib =
  [<RequireQualifiedAccess>]
  type Msg = | None

  type Model =
    { cardList: Card.Model list
      filterBar: FilterBar
      geometry: Geometry.Rect
      digests:  Digest list
      }
      static member Default ={
        cardList=[for i=1 to 10 do Card.Model.Default]
        filterBar=FilterBar.Default
        geometry=Geometry.Rect.Init (30, 30, 300, 300)
        digests = []
      }
  and Digest = {
    record:string
    cover :string
  }
  and FilterBar =
    { byText: string option
      byUrl: string option
      byLastEditTime: int option}
      static member Default ={
          byText=None
          byUrl=None
          byLastEditTime=None
        }
    
  let init () = Model.Default
  let update model msg = init ()



  let view (model: Model) dispatch =

    let filterBar = Div [] []
    let cardContainer = Div [] [
      
    ]

    Div [ ``CardLib-1-Root``;Common_glass ] [
      
    ]
