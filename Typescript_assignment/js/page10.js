var student = /** @class */ (function () {
    function student() {
        this.marks = {};
        this.rollno = 0;
        this.studentname = "";
        this.course = "";
        this.marks = {};
    }
    student.prototype.setdata = function (rollno, studentname, course, marks) {
        this.rollno = rollno;
        this.studentname = studentname;
        this.course = course;
        this.marks = marks;
    };
    student.prototype.toString = function () {
        console.log(this.rollno + " " + this.studentname + " " + this.course);
        console.log(this.marks);
        return;
    };
    return student;
}());
function failedstudent(obj) {
    for (var _i = 0, obj_1 = obj; _i < obj_1.length; _i++) {
        var i = obj_1[_i];
        for (var _a = 0, _b = Object.values(i.marks); _a < _b.length; _a++) {
            var j = _b[_a];
            if (Number(j) < 33) {
                // console.log("Hello ram")
                i.toString();
            }
        }
    }
}
function printstud(obj, id) {
    for (var _i = 0, obj_2 = obj; _i < obj_2.length; _i++) {
        var i = obj_2[_i];
        if (i.rollno == id) {
            i.toString();
        }
    }
}
function createObj() {
    var objArr = [];
    for (var i = 0; i < 3; i++) {
        var obj = new student();
        if (i == 0) {
            obj.rollno = 101;
            obj.course = "BTech";
            obj.studentname = "karan";
            var mks = { math: 67, eng: 77, sst: 30 };
            obj.marks = mks;
        }
        else if (i == 1) {
            obj.rollno = 102;
            obj.course = "BE";
            obj.studentname = "Sakshi";
            var mks = { math: 60, eng: 97, sst: 87 };
            obj.marks = mks;
        }
        else if (i == 2) {
            obj.rollno = 103;
            obj.course = "BSC";
            obj.studentname = "ram";
            var mks = { math: 67, eng: 77, sst: 32 };
            obj.marks = mks;
        }
        objArr[i] = obj;
    }
    failedstudent(objArr);
    printstud(objArr, 102);
}
createObj();
