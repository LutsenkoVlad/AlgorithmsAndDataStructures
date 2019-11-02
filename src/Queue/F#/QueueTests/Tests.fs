module Tests

open System
open Xunit
open DataStructures

[<Fact>]
let ``Count = 5 if we push 5 elements`` () =
    let queue = Queue<string>()
    
    queue.Enqueue "first"
    queue.Enqueue "second"
    queue.Enqueue "third"
    queue.Enqueue "fourth"
    queue.Enqueue "five"

    Assert.Equal(5, queue.Count)

[<Fact>]
let ``IsEmpty = true if queue is empty`` () =
    let queue = Queue<string>()
    
    Assert.Equal(true, queue.IsEmpty)

[<Fact>]
let ``Pop should give first addded emelent`` () =
    let queue = Queue<string>()
    let expected = "first"

    queue.Enqueue expected
    queue.Enqueue "second"

    Assert.Equal(expected, queue.Dequeue)

[<Fact>]
let ``queue support for in`` () =
    let queue = Queue<int>()
    let mutable index = 0
    let values = [|1;2;3;4|]

    for item in values do 
        queue.Enqueue item

    for item in queue do
        Assert.Equal(values.[index], item)
        index <- index + 1

    Assert.Equal(values.Length, queue.Count)

[<Fact>]
let ``Pop should throw exception if stack is empty`` () =
    let queue = Queue<string>()

    Assert.Throws<Exception>(fun () -> 
        queue.Dequeue |> ignore)
