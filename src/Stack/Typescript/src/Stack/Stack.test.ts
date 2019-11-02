import { Stack } from "./Stack";

describe("Stack", () => {
    let stack;
    beforeEach(() => {
        stack = new Stack();
    });

    it("Count = 5 if we push 5 elements", () => {
        stack.Push(2);
        stack.Push(2);
        stack.Push(2);
        stack.Push(2);
        stack.Push(2);

        expect(stack.Count).toEqual(5);
    });

    it("IsEmpty = true if stack is empty", () => {
        expect(stack.IsEmpty).toEqual(true);
    });

    it("Pop should give undefined if stack is empty", () => {
        expect(stack.Pop()).toBeUndefined();
    });

    it("Pop should give latest added element (5)", () => {
        stack.Push(5);

        expect(stack.Pop()).toEqual(5);
    });

    it("should support for of", () => {
        const values = [1, 2, 3, 4];
        let index = 3;

        values.forEach(x => stack.Push(x));

        for (let item of stack) {
            expect(item).toEqual(values[index--]);
        }

        expect(stack.Count).toEqual(values.length);
    });
});