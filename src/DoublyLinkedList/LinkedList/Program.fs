// Learn more about F# at http://fsharp.org

open System
open LinkedList

[<EntryPoint>]
let main argv =
    let list = mkLinkedList ()
    list |> push "some3"
    list |> push "some2"
    list |> push "some1"
    let mutable node = list.head
    for i = 1 to 3 do
        printf "%d item - %s\n" i node.Value.value
        node <- node.Value.next
    printf "count - %d\n" list.count
    0
