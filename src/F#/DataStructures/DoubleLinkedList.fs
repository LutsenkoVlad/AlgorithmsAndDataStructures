module DataStructures

type Node<'a> =
    {
        mutable prev : Node<'a> option
        mutable next : Node<'a> option
        value        : 'a
    }

type DoubleLinkedList<'a> =
    {
        mutable head  : Node<'a> option
        mutable tail  : Node<'a> option
        mutable count : int
    }

let mkLinkedList () = 
    {
        head  = None
        tail  = None
        count = 0
    }

let private addToEmptyList value list = 
    let node = Some { value = value; 
                      next  = None; 
                      prev  = None }
    list.head  <- node
    list.tail  <- node
    list.count <- 1

let push value list = 
    match list.head with
    | None      -> addToEmptyList value list
    | Some head -> 
        let newHead = Some { value = value;
                             next  = Some head;
                             prev  = None }
        list.head  <- newHead
        list.count <- list.count + 1

let append value list = 
    match list.tail with
    | None      -> addToEmptyList value list
    | Some tail ->
        let newTail = Some { value = value;
                             next  = None;
                             prev  = Some tail }
        tail.next  <- newTail
        list.tail  <- newTail
        list.count <- list.count + 1