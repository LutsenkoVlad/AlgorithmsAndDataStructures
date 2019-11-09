export class Stack<T> {
    private top?: Node<T>;
    private count: number = 0;

    Push(data: T) {
        this.top = { data, next: this.top };
        this.count++;
    }

    Pop() {
        if (!this.top) return undefined;

        const prevTopData = this.top.data;
        this.top = this.top.next;
        this.count--;
        return prevTopData;
    }

    *iterator(): IterableIterator<T> {
        let current = this.top;

        while(current) {
            yield current.data;
            current = current.next;
        }
    }

    [Symbol.iterator]() {
        return this.iterator();
    }

    get Count() {
        return this.count;
    }

    get IsEmpty() {
        return this.count === 0;
    }
}

type Node<T> = {
    data: T;
    next?: Node<T>;
};