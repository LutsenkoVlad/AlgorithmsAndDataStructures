namespace DataStructures

type Queue<'T>() =
    let mutable _list  : List<'T> = []
    let mutable _count : int = 0

    member this.Enqueue value =
        _list  <- _list :: value
        _count <- _count + 1

    member this.Dequeue =
        match List.rev _list with
        | result :: remainder -> 
            _list  <- List.rev remainder
            _count <- _count - 1
            result
        | [] -> failwith "Queue is empty"

    member this.Count = _count

    member this.IsEmpty = _count = 0

    interface System.Collections.Generic.IEnumerable<'T> with
        
        member this.GetEnumerator() = 
            let e = seq {
                yield! _list
            }
            e.GetEnumerator()

        member this.GetEnumerator() =
            (this :> _ seq).GetEnumerator()
            :> System.Collections.IEnumerator
