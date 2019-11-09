export function InsertionSort<T>(arr: T[]) {
    for (let i = 1; i < arr.length; i++) {
        let key = arr[i];
        let index = i - 1;
        while (index >= 0 && arr[index] > key) {
            arr[index + 1] = arr[index];
            index--;
        }
        arr[index + 1] = key;
    }
}