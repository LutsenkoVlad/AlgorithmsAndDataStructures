import { InsertionSort } from "./InsertionSort";

describe("InsertionSort", () => {
    it("algorithm should sort correctly [4, 3, 2, 10, 12, 1, 5, 6]", () => {
        let array = [4, 3, 2, 10, 12, 1, 5, 6];

        InsertionSort(array);

        expect(array[0]).toEqual(1);
        expect(array[1]).toEqual(2);
        expect(array[2]).toEqual(3);
        expect(array[3]).toEqual(4);
        expect(array[4]).toEqual(5);
        expect(array[5]).toEqual(6);
        expect(array[6]).toEqual(10);
        expect(array[7]).toEqual(12);
        expect(array.length).toEqual(8);
    });

    it("algorithm should sort correctly [0, 3]", () => {
        let array = [0, 3];

        InsertionSort(array);

        expect(array[0]).toEqual(0);
        expect(array[1]).toEqual(3);
        expect(array.length).toEqual(2);
    });

    it("algorithm should sort correctly [0, 3]", () => {
        let array = [-20, -3, 20, 0, 15, -12312123, 1];

        InsertionSort(array);

        expect(array[0]).toEqual(-12312123);
        expect(array[1]).toEqual(-20);
        expect(array[2]).toEqual(-3);
        expect(array[3]).toEqual(0);
        expect(array[4]).toEqual(1);
        expect(array[5]).toEqual(15);
        expect(array[6]).toEqual(20);
        expect(array.length).toEqual(7);
    });
});