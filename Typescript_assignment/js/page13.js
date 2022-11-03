"use strict";
let array = ['a', 'b', 'c', 'd', 'e'];
let r = [1, 2, 3];
array.splice(array.indexOf('b'), 1, r);
console.log(array);
