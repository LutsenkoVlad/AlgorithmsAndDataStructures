module Tests

open System
open Xunit
open DataStructures

[<Fact>]
let ``Count = 5 if we push 5 elements`` () =
    let stack = Stack<string>()
    stack.Push "1"
    stack.Push "2"
    stack.Push "3"
    stack.Push "4"
    stack.Push "5"

    Assert.Equal(5, stack.Count)

[<Fact>]
let ``IsEmpty = true if stack is empty`` () =
    let stack = Stack<int>()
    Assert.Equal(true, stack.IsEmpty)

[<Fact>]
let ``Pop should throw exception if stack is empty`` () =
    let stack = Stack<int>()
    Assert.Throws<Exception>(fun () -> 
        stack.Pop |> ignore)

[<Fact>]
let ``Pop should give latest addded emelent`` () =
    let stack = Stack<string>()
    let expected = "second"

    stack.Push "first"
    stack.Push expected

    Assert.Equal(expected, stack.Pop)

[<Fact>]
let ``stack support for in`` () =
    let stack = Stack<int>()
    let mutable index = 3
    let values = [|1;2;3;4|]

    for item in values do 
        stack.Push item

    for item in stack do
        Assert.Equal(values.[index], item)
        index <- index - 1

    Assert.Equal(values.Length, stack.Count)