module Tests

open Sorts
open Xunit

[<Fact>]
let ``Array should be sorted correctly`` () =
    let arr = [| 3; 7; 4; 4; 6; 5; 8 |]

    let sortedArr = Sort.BubbleSort arr

    Assert.Equal(3, sortedArr.[0])
    Assert.Equal(4, sortedArr.[1])
    Assert.Equal(4, sortedArr.[2])
    Assert.Equal(5, sortedArr.[3])
    Assert.Equal(6, sortedArr.[4])
    Assert.Equal(7, sortedArr.[5])
    Assert.Equal(8, sortedArr.[6])
    Assert.Equal(7, sortedArr.Length)
