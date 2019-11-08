namespace Sorts

type Sort =
    static member BubbleSort<'a when 'a : equality> (arr : int[]) =
        let mutable swapped = Sort.PassArray(arr);
        while swapped do
            swapped <- Sort.PassArray(arr)
        arr
        
    static member PassArray<'a when 'a : equality> (arr : int[]) =
        let mutable swapped = false;
        for i = 0 to arr.Length - 2 do
            if arr.[i] > arr.[i + 1]
            then Sort.Swap(arr, i - 1, i)
                 swapped <- true
        swapped

    static member private Swap<'a when 'a : equality> (arr: int[], indexLeft: int, indexRight: int) =
        let temp = arr.[indexLeft]
        arr.[indexLeft] <- arr.[indexRight]
        arr.[indexRight] <- temp

    //static member Sort<'a> (arr : 'a[]) =
    //    Sort.Handle1 arr 0 [arr.Length - 2]

    //static member private Handle1<'a> (arr: 'a[], left: int, max: int) =
    //    if Sort.Rec left max 0 false then
    //        Sort.Handle1 arr left max - 1
        
    //static member private Rec<'a> (arr: 'a[], max: int, index: int, swapped: bool) =
    //    if index >= 0 && index <= max then
    //        if a.[index] > a.[index + 1] then
    //            Sort.Swap arr index index+1
    //            Sort.Rec arr max index+1 true
    //        else 
    //            Sort.Rec arr max index+1 false
    //    else
    //        swapped