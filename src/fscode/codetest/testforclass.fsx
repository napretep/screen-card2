
open System.Collections.Generic

type Duck =
  abstract member walk:string with get,set


type littleDuck ()=
  interface Duck with
    member val walk="walk" with get,set

let a= [1;2;3;4]
a.[a.Length]
let x = a|> List.insertManyAt 0 [6;7;8;9]
a[2..]

open System.Collections

open System.Collections.Generic
let xx = Dictionary<string,string>[]

xx.Add ("123","123")
xx.["123"]<- "12344"
xx.["123"]



let a1= 1,"1",2
a1|> fun (x,y,z)-> x 

let a2 = [1;2;3;4]
([-1;yield! a2;],[yield! a2;999],[for i=0 to 4 do i]) |||>List.zip3
|> List.filter (fun (a,b,c)->
    a<3 && 3<b
  )
let order = [2;3;4;1]
let compareEntries (n1: int, s1: string) (n2: int, s2: string) =
    let n1idx=order|>List.findIndex (fun e->e=n1)
    let n2idx=order|>List.findIndex (fun e->e=n2)
    n1idx-n2idx
let input = [ (3,"aa"); (4,"bbb"); (1,"cc"); (2,"dd") ]
input |> List.sortWith compareEntries

[1;2;3;4;].Length
[for i=0 to [1;2;3;4;].Length do i]