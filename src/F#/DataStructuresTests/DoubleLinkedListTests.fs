module Tests

open Xunit
open DataStructures.LinkedList

[<Fact>]
let ``Push_CountOfNumber_ShouldBeCountOfPushedNumbers`` () = 
    let list = mkLinkedList ()
    list |> push 1
    list |> push 2
    list |> push 3
    list |> push 4
    let expected = 4
    Assert.Equal(expected, list.count)