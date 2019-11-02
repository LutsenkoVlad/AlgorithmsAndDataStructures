export class Stack<T> {
    private top: Node<T> | undefined;
    private count: number = 0;

    Push(data: T) {
        if (!this.top) {
            this.top = { data, next: undefined };
        } else {
            let newTop = { data, next: this.top };
            this.top = newTop;
        }

        this.count++;
    }

    Pop() {
        if (!this.top) {
            return undefined;
        } else {
            let prevTop = this.top;
            this.top = this.top.next;
            this.count--;
            return prevTop.data;
        }
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
    next: Node<T> | undefined;
};