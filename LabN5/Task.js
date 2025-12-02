const array = () => {
    const arr = [];

    const get = (i) => arr[i];

    get.push = (x) => arr.push(x);
    get.pop = () => arr.pop();

    return get;
} ;

const arr = array();

arr.push('first'); 
arr.push('second'); 
arr.push('third'); 

console.log(arr(0)); 
console.log(arr(1));
console.log(arr(2));

console.log(arr.pop());
console.log(arr.pop());
console.log(arr.pop());

console.log(arr.pop());
// Sequencer:
const seq = (f) => (g) => typeof g === "number" ? f(g) : seq((x) => f(g(x)));

console.log(seq
    ((x) => x + 7)
    ((x) => x *2)(5)
);

console.log(seq
    ((x) => x *2 )
    ((x) => x + 7)(5)
)

console.log(seq
    ((x) => x + 1)
    ((x) => x * 2)
    ((x) => x / 3)
    ((x) => x - 4)(7)
); 