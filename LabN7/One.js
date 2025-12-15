const removeElement = (arr, element) => { 
    const index = arr.indexOf(element); 
    if (index !== -1) arr.splice(index, 1);
}

const array = [1, 2, 3, 4, 5, 6, 7]; 
removeElement(array, 5);

const array2 = ['Kiev', 'Beijing', 'Lima', 'Saratov'];
removeElement(array2, 'Lima');
removeElement(array2, 'Berlin');

module.exports = {removeElement}; 