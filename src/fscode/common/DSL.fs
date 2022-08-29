module app.common.DSL
open System
open Browser.Types
open Fable.Core
open Browser
open Microsoft.FSharp.Collections
open app.common.funcs
open app.common.obj


type InnerStyle =
  |Left
  |Top

// type StringCSSClass = |String of string |CssClass

type Prop =
  |Classes of string list
  |Src of string
  |Styles of string list
  |Id of string
  |InnerHtml of string
  |InnerText of string
  |CSSSize of  string*string // width*height
  |CSSPosition of string*string //left*top
  |PlaceHolder of string 
  |OnMouseDown of (MouseEvent->unit)
  |OnMouseUp of (MouseEvent->unit)
  |OnMouseMove of (MouseEvent->unit)
  |OnClick of (MouseEvent->unit)
  |OnDbClick of (MouseEvent->unit)
  |TextAreaValue of string
  
  
type [<StringEnum>] Tag =
  |Div
  |Span
  |Img
  |P
  |Input
  |TextArea

type Brick ={
  tagType:Tag
  mutable element:HTMLElement option
  mutable hashmap:Map<string,HTMLElement>
  property : Prop list
  children : Brick list
}
with 
  static member Builder tag prop kids =
  {
    hashmap = Map<_,_>[] 
    element=None
    tagType = tag
    property = prop
    children =kids
  }
end

let Div = Brick.Builder Div 
let Input = Brick.Builder Input
let Span = Brick.Builder Span
let Img = Brick.Builder Img
let TextArea = Brick.Builder TextArea
let classes objs = Classes << AsStr <| objs
let Id (objs) = //Id <| List.head <| AsStr <| objs
    [objs] |> AsStr |> List.head |> Id
let setUpProperty (node:Brick) (root:Brick) =
 node.element |> Option.iter(fun element ->
   node.property |> List.iter (fun (p:Prop)->
     match p with
     |Classes value -> element.className<- List.fold (fun sum next-> sum+" "+next) "" <|value
     |Id value -> element.id <- value
     |Src value -> (element:?>HTMLImageElement).src <- value
     |InnerHtml value -> element.innerHTML <-value
     |InnerText value -> element.innerText <-value
     |CSSSize  (width,height) ->
       element.style.width <- width
       element.style.height <- height
     |CSSPosition(x , y) ->
       element.style.left<-x
       element.style.top <-y
     |TextAreaValue s -> (element:?>HTMLTextAreaElement).value <- s
     |PlaceHolder value ->  (element:?>HTMLTextAreaElement).placeholder <- value
     |OnClick mouseEventFunc -> element.onclick <- mouseEventFunc
     |OnDbClick mouseEventFunc -> element.ondblclick <- mouseEventFunc
     |OnMouseDown mouseEventFunc -> element.onmousedown <- mouseEventFunc
     |OnMouseUp mouseEventFunc -> element.onmouseup <- mouseEventFunc
     |OnMouseMove mouseEventFunc -> element.onmousemove <- mouseEventFunc
     |_->()
  )
 )
 
 if node.element.Value.id = "" then node.element.Value.id <- Guid.NewGuid().ToString()[0..7]
 root.hashmap<-root.hashmap.Add (node.element.Value.id,node.element.Value)
 
let build (root:Brick) =
  let rec subBuild (papa:Brick option) (kid:Brick) (root:Brick)=
    kid.element<-Some (document.createElement (kid.tagType.ToString()))
    papa|> Option.iter (fun pa-> pa.element.Value.appendChild kid.element.Value |>ignore)
    setUpProperty  kid root
    kid.children |> List.iter (fun kidOfKid->
        subBuild (Some kid) kidOfKid root
      )
  root.element <-Some (document.createElement (root.tagType.ToString()))
  subBuild None root root
  root
