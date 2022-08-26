module app.components.cardLibrary
open Feliz
open DaisyUI.Daisy

open Feliz.DaisyUI
open app.common
open app.common.styleSheet
open cardTemplate
open funcs
open styleSheet
[<RequireQualifiedAccess>]
module CardLib =
    [<RequireQualifiedAccess>]
    type Msg = |None

    type Model={
        cardList:Card.Model list
        filterBar:FilterBar
        geometry:Rect
    }
    and Rect ={
        top:float
        left:float
        width:int
        height:int
    }
    and FilterBar={
        byText:string
        byUrl :string 
        byLastEditTime:int
    }
    
    let init ()= {
        cardList = [for i=1 to 10 do Card.init()]
        filterBar = {
            byText=""
            byUrl=""
            byLastEditTime= -1
        }
        geometry={
            top=0.5
            left=0.5
            width=300
            height=400
        }
    }
    
    let update model msg = init()
    
    let view (model:Model) dispatch =
        
        let filterBar = Div [] []
        let cardContainer = Div [] []
        
        Div [``CardLib-1-Root``;]
            [
        ]