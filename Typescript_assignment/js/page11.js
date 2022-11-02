"use strict";
let list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 100];
console.log(`Before Swapping ${list}`);
function swap(list) {
    [list[0], list[list.length - 1]] = [list[list.length - 1], list[0]];
    return list;
}
console.log(`After Swapping ${swap(list)}`);
