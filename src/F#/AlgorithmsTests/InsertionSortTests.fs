module InsertionSortTests

open Xunit
open Algorithms

[<Fact>]
let `` Array should be sorted correctly `` () =
    let array = [| 5; 7; 8; 3; 6; 3; 2; 7 |]

    InsertionSort.Sort array

    Assert.Equal(2, array.[0])
    Assert.Equal(3, array.[1])
    Assert.Equal(3, array.[2])
    Assert.Equal(5, array.[3])
    Assert.Equal(6, array.[4])
    Assert.Equal(7, array.[5])
    Assert.Equal(7, array.[6])
    Assert.Equal(8, array.[7])