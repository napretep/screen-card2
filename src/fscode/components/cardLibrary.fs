module app.components.cardLibrary
open app.common
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open Browser.Types
open Browser
open Fable.Core
open FSharp.Control

module CardLib =
  type [<StringEnum>]  Msg = |None|Close
  module Event =
    let Close =  Event<unit>()
  type State={
    mutable IsShow:bool 
    mutable rect:Rect
  }
  let state = {
    IsShow =false
    rect = Rect.set 100 200 300 300
  }
  
  let cardItem img text =
    Div [Id CssClass.CardLib_card_item;] [
      Div [Id CssClass.CardLib_card_content;classes [CssClass.Common_glass]] [
        Img [Src img  ] []
        Span [InnerText text] []
      ]
      Div [Id CssClass.CardLib_card_btns;
           ] [
        Div [classes [CssClass.Common_glass;CssClass.Common_btn]
             InnerHtml ICON.trashBin ] []
        Div [classes [CssClass.Common_glass;CssClass.Common_btn]
             InnerHtml <| ICON.expand []] []
      ]
  ]
  let testCard = cardItem "https://freefrontend.com/assets/img/css-glassmorphism/2021-feedback-modal-design.jpg" "1231231231 aa a a a a a"
  let atom =
    Div [ Classes << AsStr <| [ CssClass.Common_component;CssClass.Common_displayNone]
          CSSPosition ("100px","400px")
          Id CssClass.CardLib_carrier.S
    ] [
      Div [ Id CssClass.CardLib_self.S
            Classes<<AsStr <| [CssClass.Common_glass]
      ] [
        Div [ Id CssClass.CardLib_toolbar.S
              Classes<<AsStr <| [CssClass.Common_glass]
        ] [
          Span [ Id CssClass.CardLib_toolbar_left.S
          ] [
            Input [ Id CssClass.CardLib_searchInput.S
                    Classes<<AsStr <| [CssClass.Common_glass;CssClass.Common_btn;CssClass.Common_textArea]
                    PlaceHolder "search"
            ] []
            Span [ Classes<<AsStr <| [CssClass.Common_glass;CssClass.Common_btn]
                   InnerHtml <| ICON.search []
            ] []
          ]
          Span [Classes<<AsStr <| [CssClass.Common_glass;CssClass.Common_btn;CssClass.Common_moveBar]
                InnerHtml <| ICON.HorizontalMoveBar []
          ] []
          Span [Id CssClass.CardLib_toolbar_right.S ] [
            Span [classes [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.pin []
                  ] []
            Span [classes [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.close []
                  ] []
          ]
        ]
        Div [Id <| CssClass.CardLib_container.S; classes [CssClass.Common_glass]] [
          testCard
          testCard
          testCard
        ]
      ]
    ]
  let view = build atom
  
  module method =
    let hide () = view.element.Value.classList.add CssClass.Common_displayNone.S
    let show () = view.element.Value.classList.remove CssClass.Common_displayNone.S