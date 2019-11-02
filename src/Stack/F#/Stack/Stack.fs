namespace DataStructures

type Stack<'T>() =
    let mutable _stack : List<'T> = []

    member this.Push value =
        _stack <- value :: _stack

    member this.Pop =
        match _stack with
        | result :: remainder ->
            _stack <- remainder
            result
        | [] -> failwith "Stack is empty"

