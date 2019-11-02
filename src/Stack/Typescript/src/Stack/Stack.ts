export class Stack<T> {
    private top?: Node<T>;
    private count: number = 0;

    Push(data: T) {
        this.top
            ? (this.top = { data, next: this.top })
            : (this.top = { data });

        this.count++;
    }

    Pop() {
        if (!this.top) return undefined;

        let prevTopData = this.top.data;
        this.top = this.top.next;
        this.count--;
        return prevTopData;
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