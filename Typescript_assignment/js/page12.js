"use strict";
let tuple = [1, 2, 3, 4, 5, 6, 7];
let summ = 0;
function sum(tuple) {
    for (let i = 0; i < tuple.length; i++) {
        summ += i;
    }
    return summ;
}
console.log(`Sum of the tuple [${tuple}] is ${sum(tuple)}`);
