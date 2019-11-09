module BubbleTests

open Xunit
open Algorithms

[<Fact>]
let ``Array should be sorted correctly [| 3; 7; 4; 4; 6; 5; 8 |]`` () =
    let arr = [| 3; 7; 4; 4; 6; 5; 8 |]

    let sortedArr = BubbleSort.Sort arr

    Assert.Equal(3, sortedArr.[0])
    Assert.Equal(4, sortedArr.[1])
    Assert.Equal(4, sortedArr.[2])
    Assert.Equal(5, sortedArr.[3])
    Assert.Equal(6, sortedArr.[4])
    Assert.Equal(7, sortedArr.[5])
    Assert.Equal(8, sortedArr.[6])
    Assert.Equal(7, sortedArr.Length)

[<Fact>]
let ``Array should be sorted correctly [| 2; 0 |]`` () =
    let arr = [| 2; 0 |]

    InsertionSort.Sort arr

    Assert.Equal(0, arr.[0])
    Assert.Equal(2, arr.[1])
    Assert.Equal(2, arr.Length)

[<Fact>]
let ``Array should be sorted correctly [| 3; 4; 5; |]`` () =
    let arr = [| 3; 4; 5; |]

    InsertionSort.Sort arr

    Assert.Equal(3, arr.[0])
    Assert.Equal(4, arr.[1])
    Assert.Equal(5, arr.[2])
    Assert.Equal(3, arr.Length)

[<Fact>]
let ``Array should be sorted correctly [| 3; 7; 4; 4; 6; 5; 8 |] by rec sort`` () =
    let arr = [| 3; 7; 4; 4; 6; 5; 8 |]

    let sortedArr = BubbleSort.RecSort arr

    Assert.Equal(3, sortedArr.[0])
    Assert.Equal(4, sortedArr.[1])
    Assert.Equal(4, sortedArr.[2])
    Assert.Equal(5, sortedArr.[3])
    Assert.Equal(6, sortedArr.[4])
    Assert.Equal(7, sortedArr.[5])
    Assert.Equal(8, sortedArr.[6])
    Assert.Equal(7, sortedArr.Length)

[<Fact>]
let ``Array should be sorted correctly [| 2; 0 |] by rec sort`` () =
    let arr = [| 2; 0 |]

    let sortedArr = BubbleSort.RecSort arr

    Assert.Equal(0, sortedArr.[0])
    Assert.Equal(2, sortedArr.[1])
    Assert.Equal(2, sortedArr.Length)

[<Fact>]
let ``Array should be sorted correctly [| 3; 4; 5; |] by rec sort`` () =
    let arr = [| 3; 4; 5; |]

    let sortedArr = BubbleSort.RecSort arr

    Assert.Equal(3, sortedArr.[0])
    Assert.Equal(4, sortedArr.[1])
    Assert.Equal(5, sortedArr.[2])
    Assert.Equal(3, sortedArr.Length)