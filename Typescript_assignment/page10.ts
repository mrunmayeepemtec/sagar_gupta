class student {
    rollno: number;
    studentname: string;
    course: string;
    marks = {};
    constructor() {
      this.rollno = 0;
      this.studentname = "";
      this.course = "";
      this.marks = {};
    }
    setdata(rollno: number, studentname: string, course: string, marks: any) {
      this.rollno = rollno;
      this.studentname = studentname;
      this.course = course;
      this.marks = marks;
    }
    toString() {
      console.log(this.rollno + " " + this.studentname + " " + this.course);
      console.log(this.marks);
      return;
    }
  }

  
  function failedstudent(obj: Array<student>) {
    for (let i of obj) {
      for (let j of Object.values(i.marks)) {
        if (Number(j) < 33) {
          // console.log("Hello ram")
          i.toString();
        }
      }
    }
  }

  function printstud(obj: Array<student>, id: number) {
    for (let i of obj) {
      if (i.rollno == id) {
        i.toString();
      }
    }
  }
  function createObj() {
    const objArr: Array<student> = [];
    for (let i = 0; i < 3; i++) {
      let obj = new student();
      if (i == 0) {
        obj.rollno = 101;
        obj.course = "BTech";
        obj.studentname = "karan";
        let mks = { math: 67, eng: 77, sst: 30 };
        obj.marks = mks;
      } else if (i == 1) {
        obj.rollno = 102;
        obj.course = "BE";
        obj.studentname = "Sakshi";
        let mks = { math: 60, eng: 97, sst: 87 };
        obj.marks = mks;
      } else if (i == 2) {
        obj.rollno = 103;
        obj.course = "BSC";
        obj.studentname = "ram";
        let mks = { math: 67, eng: 77, sst: 32 };
        obj.marks = mks;
      }
      objArr[i] = obj;
    }
    failedstudent(objArr);
    printstud(objArr, 102);
  }
  createObj();  