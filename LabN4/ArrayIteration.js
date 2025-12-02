function Max(array) {
    return array.flat().reduce((a, b) => Math.max(a, b), -Infinity);
}

const m = Max([
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9],
]);

console.log(m);