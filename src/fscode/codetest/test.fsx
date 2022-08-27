type Msg = {
    content:string 
    callback: obj->unit option
}
type Msg2 = Msg option 
type sendMsg = obj option-> unit 
let g (s:obj option) =
    match s with
    |Some x -> (
            match x with
            | :? Msg -> printf "string"
            | _ -> printf "not string"
        )
    |None -> printf "None"

// g  (Some {content="123";callback=None})


if not true then printfn "ok" else printfn "no"



let resolved = function
    | (a:string) -> printfn "%A" a
    | (v:string) -> printfn "%A" v
    | (v:string) ->  printfn "%A" v
    
resolved("a")

let a b c = printfn "123"
"b"|> a("c")


let x (b:seq<string>) = b
let y n = [for i  in 1..n -> $"{i}"]
x (["a";"b";yield! y(10)])

"123".ToString()

[<Measure>] type percent
1<percent>

let inline add a b =a+b



            

open System
Guid.NewGuid().ToString().Replace("-","")[0..15]


type Record = {
        guid:string
        content:string option
        kind:Kind
        from:string option
        createTime:int
        lastModifiedTime:int }
        with    
            static member Default = {
                guid=""
                content =None
                kind=Text
                from=None
                createTime=0
                lastModifiedTime=0
            }
        end
    and  Kind =
            |Text
            |Pic
            
DateTime.Now.Ticks/(int64 10000000)


type test =
  { a: float }
  member x.b =
    printfn "oh no"
    x.a * 2.

let t = { a = 1. }
t.b
t.b


type text = {
    haha:bool
    IsMoving:bool}
with 
    member this.setMoving b =
        {this with IsMoving=b}

let TTT= {haha=true;IsMoving=false}
let me = TTT.setMoving true 