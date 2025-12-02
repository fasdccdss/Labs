function SumFor(...args)   {
    let sum = 0;
    for (let i=0; i <args.length; i++){
        sum += args[i];
    }
return sum;
} 
console.log(SumFor(1, 2, 3))

function SumForOf(...args) {
    let sum = 0;
    for (const num of args) {
        sum += num
    }
    return sum;
}
console.log(SumForOf(0))

function SumWhile(...args) {
    let sum = 0, i =0
    while ( i < args.length){
        sum += args[i];
        i++;
    }
    return(sum)
}
console.log(SumWhile())

function SumDoWhile(...args) {
    let sum = 0, i = 0;
    if(args.length === 0) return 0;
    do{
        sum += args[i];
        i++;
    } while (i < args.length);
    return sum;
}
console.log(SumDoWhile(1, -1, 1))

function SumReduce(...args) {
    return args.reduce((acc, val) => acc + val, 0);
}
console.log(SumReduce(10, -1, -1, -1))