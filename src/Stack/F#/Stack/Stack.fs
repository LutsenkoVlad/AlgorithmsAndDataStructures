namespace DataStructures

type Stack<'T>() =
    let mutable _stack : List<'T> = []
    let mutable _count : int = 0

    member this.Push value =
        _stack <- value :: _stack
        _count <- _count + 1

    member this.Pop =
        match _stack with
        | result :: remainder ->
            _stack <- remainder
            _count <- _count - 1
            result
        | [] -> failwith "Stack is empty"

    member this.Count =
        _count

    member this.IsEmpty =
        _count = 0

    interface System.Collections.Generic.IEnumerable<'T> with

        member this.GetEnumerator() =
            let e = seq {
                yield! _stack
            }
            e.GetEnumerator()

        member this.GetEnumerator() = 
            (this :> _ seq).GetEnumerator() 
            :> System.Collections.IEnumerator
