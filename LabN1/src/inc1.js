const inc = (n) => {
    if (typeof n !== "number") throw new Error (" can't increase a non-numeric variable");
    return n + 1;
}

const a = 4;
const b = inc(a); 

console.log("Original number: ", a, "\nIncreased number:",  b);