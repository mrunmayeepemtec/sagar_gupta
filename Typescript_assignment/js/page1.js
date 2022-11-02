var MyArray = /** @class */ (function () {
    function MyArray() {
        this.value = 0;
        this.collection = [];
    }
    // constructor(value:string | number ){
    //     this.value=value
    // }
    MyArray.prototype.add = function (value) {
        this.value = value;
        this.collection.push(value);
    };
    MyArray.prototype.remove = function (value) {
        var index = this.collection.indexOf(value);
        this.collection.splice(index, 1);
    };
    MyArray.prototype.getValues = function () {
        return this.collection;
    };
    return MyArray;
}());
var stringAry = new MyArray();
stringAry.add('aaa');
stringAry.add('bbb');
stringAry.add('ccc');
stringAry.remove('bbb');
console.log(stringAry.getValues());
var numberAry = new MyArray();
numberAry.add(1);
numberAry.add(2);
numberAry.add(3);
numberAry.remove(2);
console.log(numberAry.getValues());
var booleanAry = new MyArray();
// numberAry.add(true)
// numberAry.add(false)
