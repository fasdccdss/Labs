function store(initialValue) {
    let value = initialValue;
    function getter() {
        return value;
    }
    getter.set = function(newValue) {
        value = newValue;
    };
    return getter;
}

const read = store(5);
console.log(read());
read.set(10);
console.log(read());