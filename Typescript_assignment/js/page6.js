"use strict";
function Factorial(n) {
    let fact = 1;
    if (n === 0) {
        return 1;
    }
    else {
        for (var i = n; i >= 1; i--) {
            fact = fact * i;
        }
        return (fact);
    }
}
// console.log(Factorial(3))
for (var i = 1; i <= 20; i++) {
    console.log(Factorial(i));
}
