namespace DataStructures

type Set<'T when 'T : equality> () =
    let mutable _list  : List<'T> = []
    let mutable _count : int = 0

    member this.Add value =
        if List.contains value _list 
        then failwith "Set already has such item"
        else 
            _list <- value :: _list
            _count <- _count + 1

    member this.Remove value =
        if List.contains value _list
        then 
            _list <- List.filter (fun x -> x = value) _list
            _count <- _count - 1
        else failwith "Set doesn't have such item"

    member this.Count = _count

    member this.IsEmpty = _count = 0