
["1";"2"] |> List.fold (fun sum next -> sum+" "+ next) "" 
type CssClass =
    |Common_Shadow
    |``Common-backdropBlur``
    |``Common-fixed``
    |Common_glass
    |Common_component
    |Common_btn
    |Common_displayNone
    |AssistDot_carrier
    |AssistDot_self
    |AssistDot_btn
    |AssistDot_btn_moveBar
    |``CardLib-1-Root``
    |``CardTemplate-btn-``
    with
        member this.ToStr = this.ToString()
    end

Common_btn.ToStr


let i (a) (b) = a + b

open FSharp.Collections
let mutable n = Map<string,int>[]
n<-n.Add ("1",2)
n<-n.Add ("X",2)
n

open FSharp.Core


type Author(name : string) =
    let mutable _name = name;

    //creates event
    let nameChanged = new Event<string>()
    
    //exposed event handler
    member this.NameChanged = nameChanged.Publish
    
    member this.Name
        with get() = _name
        and set(value) =
            _name <- value

            //invokes event handler
            nameChanged.Trigger(_name)
            
            
let p = Author("Mark")
p.NameChanged.Add(fun name -> printfn "-- Name changed! New name: %s" name)
p.Name <- "Andy"

let click = Event<string>()
let clicked = click.Publish

let add a b =
    let x = a+b
    click.Trigger($"{x}")

clicked.Add <| fun x->printfn $"{x}" 

