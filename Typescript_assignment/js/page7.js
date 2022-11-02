"use strict";
// function Exec(){
//     let name_value = (<HTMLInputElement>document.getElementById("name")).value; 
//     let fees_value = (<HTMLInputElement>document.getElementById("fees")).value; 
// class Course {
//     name:string = String(name_value)
//     fees: number = Number(fees_value)
//     printDetails(){
//     console.log(`Name of the course is ${name_value} and its fees is ${fees_value}`)
//     }
// }
//     const C1 = new Course()
//     C1.printDetails()
// }
class Course {
    constructor() {
        this.name = '';
        this.fees = 0;
        // printDetails(){
        // console.log(`Name of the course is ${name_value} and its fees is ${fees_value}`)
        // }
    }
}
class Computer extends Course {
    constructor() {
        super(...arguments);
        this.subj_val = '';
        this.subjectList = ['C++', 'Python3', 'Andriod Studio'];
    }
    addSubjects(subj_val) {
        this.subjectList.push(subj_val);
    }
    displaySubjects() {
        this.subjectList.forEach((element) => {
            console.log(element);
        });
    }
}
const comp1 = new Computer();
comp1.addSubjects('Kotlin');
comp1.displaySubjects();
class Electronics extends Course {
    constructor() {
        super(...arguments);
        this.subj_val = '';
        this.subjectList = ['BEE', 'DSIP', 'Circuits & Current'];
    }
    addSubjects(subj_val) {
        this.subjectList.push(subj_val);
    }
    displaySubjects() {
        this.subjectList.forEach((element) => {
            console.log(element);
        });
    }
}
const elec1 = new Electronics();
elec1.addSubjects('Logic XOR');
elec1.displaySubjects();
