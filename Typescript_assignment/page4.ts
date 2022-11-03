class Bank_Acc {
    id: number 
    firstName: string
    lastName: string
    address: string
    phone: number
    email: string
    type:string
    collection:any = []

    constructor(id: number ,firstName: string,lastName: string,address: string,phone: number,email: string,type:string) {
        this.id = id
        this.firstName = firstName
        this.lastName = lastName
        this.address = address
        this.phone = phone
        this.email = email
        this.type = type
      }

    createAccount( id: number,firstName: string,lastName: string,address: string,phone: number,email: string,type:string){
        this.collection.push(id,firstName,lastName,address,phone,email,type)
    }

    updateAccount(id: number){
        let index = this.collection.indexOf(id)
        this.collection.splice(index,1,10)
    }

    deleteAccount(id: number){
        let index = this.collection.indexOf(id)
        this.collection.splice(index,1)
    }
}

class Transaction extends Bank_Acc{
    date: string = ' '
    trans_type: boolean = true // True Means success and False means failed
    amount: number = 0
    customerId: number = this.id
    moni:any = []
    // id_OK = this.id

    depositFunds(firstName: string,date: string, trans_type: boolean,amount:number,customerId:number){
        this.moni.push(firstName,date,trans_type,amount,customerId)
    }
    
    withdrawFunds(amount:number){
        let index = this.moni.indexOf(amount)
        this.moni.splice(index)
    }

}

const b1 = new Bank_Acc(1,'Atik','Shaikh','Mumbai',7219388991,'atik.shaikh@emtecinc.com','Savings')
console.log(b1)

const d1 = new Transaction(1,'Atik','Shaikh','Mumbai',7219388991,'atik.shaikh@emtecinc.com','Savings')
console.log(d1)
d1.depositFunds('Atik','20/11/2022',true,9000000,1)
console.log(d1.moni)
d1.withdrawFunds(9000000)
console.log(d1.moni)
