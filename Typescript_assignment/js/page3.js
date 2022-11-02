"use strict";
const validator = (validatorFn) => {
    return { valid: false, error: 'error occurred' };
};
const errorResponse = () => {
    return { valid: false, error: 'error occurred' };
};
console.log(validator(() => errorResponse()).valid);
console.log(validator().error);
