let array:any = ['a', 'b', 'c', 'd', 'e']
let r:number[] = [1, 2, 3]
array.splice(array.indexOf('b'),1,r)
console.log(array)