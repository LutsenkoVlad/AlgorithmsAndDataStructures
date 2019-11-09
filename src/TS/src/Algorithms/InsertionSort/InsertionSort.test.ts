import { InsertionSort } from "./InsertionSort";

describe("InsertionSort", () => {
    it("algorithm should sort correctly", () => {
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
});