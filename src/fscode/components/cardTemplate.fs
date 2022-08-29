module app.components.cardTemplate
open System
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


module Card =
  type CardFieldContent = |Text of string |Image of string  
  let cardField (content:CardFieldContent)=
    Div [
      classes [CardField_self]
    ] [
      Div [classes [Common_glass;Common_btn;CardField_dragBar]
           InnerHtml <| ICON.VerticalMoveBar [] 
           ] []
      Div [classes [Common_glass;CardField_content]] [
        match content with
        |Text s -> TextArea [classes [Common_textArea;Common_glass;CardField_content_text]
                             TextAreaValue s ] []
        |Image s-> Img  [Src s
                         classes [CardField_content_img;]
                         ] []
      ]
      Div [classes [Common_glass;CardField_btns]] [
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.link 
             ] []
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.expand []
             ] []
        Div [classes [Common_glass;Common_btn]
             InnerHtml <| ICON.close []
             ] []
      ]
    
    ]
  let testField = cardField <| Text "123"
  let testField2 = cardField <| Image URL.logo
  let atom (point:pointF) =
    Div [
      classes [Common_component;Card_carrier;Common_glass]
      CSSPosition point.ToPx
    ] [
      Div [ classes [Common_glass;Card_self;] ] [
        Div [ classes [Common_glass;Card_header] ] [
          Span [classes [Common_glass;Common_btn]; InnerHtml <| ICON.close [] ] []
          Span [classes [Common_moveBar;Common_glass;Common_btn]; InnerHtml <| ICON.HorizontalMoveBar []] []
          Span [classes [Common_glass;Common_btn] ; InnerHtml <| ICON.pin [] ] []
        ]
        Div [classes [Card_body]] [
        Div [classes [Common_glass;Card_body_menu]] [
          Span [classes [Common_glass;Common_btn]
                InnerHtml <| ICON.plus [] + ICON.clip []
                ] []
          Span [classes [Common_glass;Common_btn]
                InnerHtml <| ICON.plus [] + ICON.text []
                ] []
        ]
        testField
        testField2
        testField
        testField2
        testField
        testField2
      ]
      ]
      
    ]
    
  