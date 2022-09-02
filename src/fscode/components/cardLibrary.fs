module app.components.cardLibrary
open app.common
open app.common.obj
open app.common.funcs
open app.common.obj.Geometry
open app.common.styleSheet
open app.common.DSL
open app.common.globalTypes
open Browser.Types
open Browser
open Fable.Core
open FSharp.Control

module CardLib =
  type [<StringEnum>]  Msg = |None|Close
  type Event =
    {Close : Event<unit>}
    with
     static member init =
       {
        Close =  Event<unit>()
        }
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
        Div [classes [CssClass.Common_glass;CssClass.Common_btn];
             InnerHtml ICON.del ] []
        Div [classes [CssClass.Common_glass;CssClass.Common_btn]
             InnerHtml <| ICON.expand ] []
      ]
  ]
  let testCard = cardItem "https://freefrontend.com/assets/img/css-glassmorphism/2021-feedback-modal-design.jpg" "1231231231 aa a a a a a"
  let atom =
    Div [ classes  [ Common_component]
          CSSPosition ("100px","400px")
          Id CssClass.CardLib_carrier
    ] [
      Div [ Id CssClass.CardLib_self
            Classes<<AsStr <| [CssClass.Common_glass]
      ] [
        Div [ Id CssClass.CardLib_toolbar
              Classes<<AsStr <| [CssClass.Common_glass]
        ] [
          Span [ Id CssClass.CardLib_toolbar_left
          ] [
            Input [ Id CssClass.CardLib_searchInput
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
          Span [Id CssClass.CardLib_toolbar_right ] [
            Span [classes [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.pin []
                  ] []
            Span [classes [CssClass.Common_glass;CssClass.Common_btn]
                  InnerHtml <| ICON.close []
                  ] []
          ]
        ]
        Div [Id <| CssClass.CardLib_container; classes [CssClass.Common_glass]] [
          testCard
          testCard
          testCard
        ]
      ]
    ]
  let view = build atom
  
  module method =
    let hide () = view.element.Value.remove()
    let show () =  view.element.Value
    
  type Core(env:GlobalCore,view:Brick,Id:string) as this=
    inherit ICore(view,Id)
    member val env=env
    member val state = state with get,set
    member val event = Event.init with get,set
    member val op_view = Op_View(this)
  and Op_View (env:Core) =
    member val env=env
    member this.show = env.env.root.appendChild this.env.view.element.Value|>ignore
    member this.hide = this.env.view.element.Value.remove()
  
  let Init (env:GlobalCore) (p:pointF) =
    let core = Core(
      env = env,
      view = view,
      Id=CardLib_self.S
      )
    pointF.setElementPosition view.element.Value p
    view.element.Value.onclick<- fun e->
      env.state.setFocus view.element.Value
      ()
    env.addMember core
    core.op_view.hide
    core