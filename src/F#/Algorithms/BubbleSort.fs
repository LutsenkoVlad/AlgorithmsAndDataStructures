namespace Algorithms

type BubbleSort =
    static member Sort arr =
        let mutable swapped = BubbleSort.Iterate arr
        while swapped do
            swapped <- BubbleSort.Iterate arr
        arr

    static member Iterate (arr : 'a[]) =
        let mutable swapped = false
        for i = 0 to arr.Length - 2 do
            if arr.[i] > arr.[i + 1] then
                BubbleSort.Swap arr i (i+1)
                swapped <- true
        swapped
        
    static member private Swap (arr : 'a[]) left right =
        let temp = arr.[left]
        arr.[left]  <- arr.[right]
        arr.[right] <- temp

    static member RecSort arr =
        let rec loop (arr : 'a[]) =
            let swapped = BubbleSort.Iterate arr
            match swapped with
            | true  -> loop arr
            | false -> arr

        loop arr