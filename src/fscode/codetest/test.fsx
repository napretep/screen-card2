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