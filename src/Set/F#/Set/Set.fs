namespace DataStructures

open System.Collections.Generic
open System.Collections

type Set<'T when 'T : equality> () =
    let mutable _list  : Microsoft.FSharp.Collections.List<'T> = []
    let mutable _count : int = 0

    member this.Add value =
        if not (this.Exists value)
        then 
             _list <- value :: _list
             _count <- _count + 1

    member this.Remove value =
        if this.Exists value
        then 
            _list <- List.filter (fun x -> x = value) _list
            _count <- _count - 1

    member this.AddRange list =
        for item in list do
            if not (this.Exists item)
            then this.Add item

    member this.Union (set : Set<'T>) =
        let mutable resultSet = Set<'T>()
        for item in set do
            if not (this.Exists item)
            then resultSet.Add item
        for item in _list do
            resultSet.Add item
        resultSet

    member this.Intersect (set : Set<'T>) =
        let mutable resultSet = new Set<'T>()
        for item in set do
            if this.Exists item
            then resultSet.Add item
        resultSet


    member this.Exists value = 
        List.contains value _list

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