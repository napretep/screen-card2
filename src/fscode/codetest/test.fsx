

module DuckTyping

// Demonstrates F#'s compile-time duck-typing.




type RedDuck =
    { Name : string }
    member this.Quack () = "Red"

type BlueDuck =
    { Name : string }
    member this.Quack () = "Blue"

let inline name this =
    (^a : (member Name : string) this)

let inline quack this =
    (^a : (member Quack : unit -> string) this)

let howard = name { RedDuck.Name = "Howard" }
let bob = name { BlueDuck.Name = "Bob" }
let red = quack { RedDuck.Name = "Jim" }
let blue = quack { BlueDuck.Name = "Fred" }


type Iduck=
    abstract member say:string
type Aduck={
    _say:string
    other:int
}

type Bduck ={
    _say:string
    another:bool
}
with
    interface Iduck with
        member I.say = "123"
type ABduck = Aduck of Aduck|Bduck of Bduck
type Ducks={
    group : Iduck list 
}
//
// let realDuck = {
//     group=[
//         {_say="A";other=1}
//         Bduck {say="B";another=false}
//     ]
// }

