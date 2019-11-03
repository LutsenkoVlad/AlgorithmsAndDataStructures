module Tests

open Xunit
open DataStructures

[<Fact>]
let ``My test`` () =
    let set = new Set<int>()
    set.Add 1
    set.Add 2
    set.Add 3
    set.Remove 2
    Assert.Equal(2, set.Count)
