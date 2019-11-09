export function InsertionSort<T>(arr: T[]) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] > arr[i + 1]) {
            for (let j = i + 1; j > 0; j--) {
                if (arr[j] < arr[j - 1]) {
                    swap(arr, j - 1, j);
                } else {
                    break;
                }
            }
        }
    }
}

function swap<T>(arr: T[], left: number, right: number) {
    const temp = arr[left];
    arr[left]  = arr[right];
    arr[right] = temp;
}