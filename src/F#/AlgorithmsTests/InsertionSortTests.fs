module InsertionSortTests

open Xunit
open Algorithms

[<Theory>]
let ``Array should be sorted correctly [|3; 7; 4; 4; 6; 5; 8|]`` () =
    let arr = [| 3; 7; 4; 4; 6; 5; 8 |]

    InsertionSort.Sort arr

    Assert.Equal(3, arr.[0])
    Assert.Equal(4, arr.[1])
    Assert.Equal(4, arr.[2])
    Assert.Equal(5, arr.[3])
    Assert.Equal(6, arr.[4])
    Assert.Equal(7, arr.[5])
    Assert.Equal(8, arr.[6])
    Assert.Equal(7, arr.Length)

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