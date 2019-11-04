namespace DataStructures

open System.Collections.Generic
open System.Collections

type Queue<'T>() =
    let mutable _list  : Microsoft.FSharp.Collections.List<'T> = []
    let mutable _count : int = 0

    member this.Enqueue value =
        _list <- List.append _list [value]
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

    interface IEnumerable<'T> with
        
        member this.GetEnumerator() = 
            let e = seq {
                yield! _list
            }
            e.GetEnumerator()

        member this.GetEnumerator() =
            (this :> _ seq).GetEnumerator()
            :> IEnumerator
