namespace DataStructures

type Queue<'T>() =
    let mutable _list  : List<'T> = []
    let mutable _count : int = 0

    member this.Enqueue value =
        let revList = List.rev _list
        _list  <- List.rev (value :: revList)
        _count <- _count + 1

    member this.Dequeue =
        match _list with
        | result :: remainder -> 
            _list  <- remainder
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
