"use strict";
class Bank_Acc {
    this.collection = [];
    constructor(id, firstName, lastName, address, phone, email, type) {
        
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.phone = phone;
        this.email = email;
        this.type = type;
    }
    createAccount(id, firstName, lastName, address, phone, email, type) {
        this.collection.push(id, firstName, lastName, address, phone, email, type);
    }
    updateAccount(id) {
        let index = this.collection.indexOf(id);
        this.collection.splice(index, 1, 10);
    }
    deleteAccount(id) {
        let index = this.collection.indexOf(id);
        this.collection.splice(index, 1);
    }
}
class Transaction extends Bank_Acc {
    constructor() {
        super(...arguments);
        this.date = ' ';
        this.trans_type = true; // True Means success and False means failed
        this.amount = 0;
        this.customerId = this.id;
        this.moni = [];
    }
    // id_OK = this.id
    depositFunds(firstName, date, trans_type, amount, customerId) {
        this.moni.push(firstName, date, trans_type, amount, customerId);
    }
    withdrawFunds(amount) {
        let index = this.moni.indexOf(amount);
        this.moni.splice(index);
    }
}
const b1 = new Bank_Acc(1, 'Atik', 'Shaikh', 'Mumbai', 7219388991, 'atik.shaikh@emtecinc.com', 'Savings');
console.log(b1);
const d1 = new Transaction(1, 'Atik', 'Shaikh', 'Mumbai', 7219388991, 'atik.shaikh@emtecinc.com', 'Savings');
console.log(d1);
d1.depositFunds('Atik', '20/11/2022', true, 9000000, 1);
console.log(d1.moni);
d1.withdrawFunds(9000000);
console.log(d1.moni);
