function unique(array) { 
    return [...new Set(array)]; 
}

const result = unique([2, 1, 1, 3, 2]);
console.log(result);

const result2 = unique(['top', 'bottom', 'top', 'left']); 
console.log(result2); 

module.exports = {unique};