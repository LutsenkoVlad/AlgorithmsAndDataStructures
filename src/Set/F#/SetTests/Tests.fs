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

[<Fact>]
let ``Count of set should be equal 4`` () =
    let set = Set<int>()
    let values = [|1;2;3;4|]

    for item in values do 
        set.Add item
    
    Assert.Equal(4, set.Count)

[<Fact>]
let ``AddRange should add 3 elements`` () =
    let set = Set<int>()
    let values = [|1;2;3|]

    set.AddRange values

    Assert.Equal(3, set.Count)

[<Fact>]
let ``set has "first" and "second" item`` () =
    let set = Set<string>()
    let first = "first"
    let second = "secons"

    set.Add first
    set.Add second

    Assert.Equal(true, set.Exists first)
    Assert.Equal(true, set.Exists second)

[<Fact>]
let ``IsEmpty = true if set is empty`` () =
    let set = Set<string>()
    
    Assert.Equal(true, set.IsEmpty)