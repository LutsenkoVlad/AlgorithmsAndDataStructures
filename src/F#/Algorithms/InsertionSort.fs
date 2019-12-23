namespace Algorithms

type InsertionSort =
    static member Sort (arr : 'a[]) =
        for i = 1 to arr.Length - 1 do
            let key = arr.[i]
            let mutable j = i - 1
            while j >= 0 && arr.[j] > key do
                arr.[j+1] <- arr.[j] 
                j <- j-1
            arr.[j+1] <- key