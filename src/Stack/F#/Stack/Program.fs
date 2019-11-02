// Learn more about F# at http://fsharp.org

open System
open DataStructures

[<EntryPoint>]
let main argv =
    let stack = Stack<string>()
    stack.Push "first"
    stack.Push "second"
    stack.Push "third"
    printfn "%s" stack.Pop
    printfn "%s" stack.Pop
    printfn "%s" stack.Pop
    0
