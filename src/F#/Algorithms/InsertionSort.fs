namespace Algorithms

type InsertionSort =
    static member Sort (arr : 'a[]) =
        let mutable minIndex = 0
        let mutable startFromIndex = 0
        while startFromIndex < arr.Length do
            minIndex <- startFromIndex
            for i = startFromIndex to arr.Length - 1 do
                if arr.[minIndex] > arr.[i] then
                    minIndex <- i

            InsertionSort.Swap arr startFromIndex minIndex
            startFromIndex <- startFromIndex + 1

    static member private Swap (arr : 'a[]) left right =
        let temp = arr.[left]
        arr.[left]  <- arr.[right]
        arr.[right] <- temp