module app.components.assistDot

open Feliz.DaisyUI
open Feliz
open app.common
open funcs
open obj
open styleSheet

[<RequireQualifiedAccess>]
module AssistDot =
  type Msg =
    | Close
    | MoveBegin
    | MoveEnd
    | OpenCardLib
    | CreateCard
  
  type States ={
    IsMoving:bool
    IsVisible: bool
    LeftOrRight:Dir
  }
    with
      static member Default = {
        IsMoving=false
        IsVisible=true
        LeftOrRight=Right
      }
      
    end
  and Dir = |Left |Right
  
  
  type Model = {
    height: int
    states:States
  }
  with 
    static member Default = {
      states=States.Default
      height=50
    }
    member this.SetIsMoving (yesOrNo:bool)=
      {this with states={this.states with IsMoving=yesOrNo} }
    member this.SetIsVisible (yesOrNo:bool)=
      {this with states={this.states with IsVisible=yesOrNo} }
        
    member this.SetLeftOrRight (LR:Dir)=
      {this with states={this.states with LeftOrRight=LR} }


  let init () =Model.Default

  let update (msg:Msg) (model:Model)= 
      match msg with
      |_ -> failwith "no msg need update"
  
  let view (model: Model) (dispatch: Msg -> unit) =
    
    Div [ AssistDot_self; Common_glass ] [
      Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
               prop.innerHtml <| ICON.HorizontalMoveBar []
               prop.onClick <| fun e-> dispatch Msg.MoveBegin
               ]
      Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
               prop.innerHtml <| ICON.close []
               prop.onClick <| fun e-> dispatch Msg.Close]
      Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
               prop.innerHtml <| ICON.bookshelf []
               prop.onClick <| fun e-> dispatch Msg.OpenCardLib]
      Html.div[prop.classes <| AsStr [ Common_btn;Common_glass ]
               prop.innerHtml <| ICON.plusPage []
               prop.onClick <| fun e-> dispatch Msg.CreateCard
               ]
    ]
