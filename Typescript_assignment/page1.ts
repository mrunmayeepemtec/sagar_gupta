class MyArray {
    value: string | number = 0
    collection:any = []

    // constructor(value:string | number ){
    //     this.value=value
    // }

    add(value: string | number){
        this.value = value
        this.collection.push(value)
    }

    remove(value: string | number){
        let index = this.collection.indexOf(value)
        this.collection.splice(index,1)
    }
    getValues(){
        return this.collection
    }

}

const stringAry = new MyArray()
stringAry.add('aaa')
stringAry.add('bbb')
stringAry.add('ccc')
stringAry.remove('bbb')
console.log(stringAry.getValues())

const numberAry = new MyArray()
numberAry.add(1)
numberAry.add(2)
numberAry.add(3)
numberAry.remove(2)
console.log(numberAry.getValues())

const booleanAry = new MyArray()
// numberAry.add(true)
// numberAry.add(false)