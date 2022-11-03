"use strict";
const myFunc = (para) => {
    const { firstParam = "defaultFirst", secondParam = "defaultSecond" } = para;
    const Final_Result = ` firstParam: ${firstParam}, secondParam: ${secondParam}`;
    return (Final_Result);
};
console.log(myFunc({}));
console.log(myFunc({ firstParam: 'first', secondParam: 'second' }));
console.log(myFunc({ firstParam: 'first' }));
console.log(myFunc({ secondParam: 'second' }));
// Normal Function 
// function myFunc(para: Params){
//     const {firstParam = "defaultFirst" ,secondParam ="defaultSecond" } = para
//     const Final_Result =` firstParam: ${firstParam}, secondParam: ${secondParam}`
//     return(Final_Result)
// }
