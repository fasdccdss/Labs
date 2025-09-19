const inc = (num) => {
    if (typeof num.n !== "number") throw new Error (" can't increase a non-numeric variable");
    num.n = num.n + 1;
}

const obj = { n: 5 };
inc(obj);

console.dir(obj);