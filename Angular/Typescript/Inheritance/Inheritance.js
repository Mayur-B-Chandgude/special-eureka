/*
    Inheritance : Reusablity
    typescript supports single level, multiple, multlevel inheritance.
    Access specifiers are public, private,protected.
    Default access specifier is public.
*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Declare class Student
var Student = /** @class */ (function () {
    //constructor 
    function Student(value) {
        this.Sname = value;
    }
    //Behaviour
    Student.prototype.DisplayS = function () {
        console.log("Name of student : " + this.Sname);
    };
    return Student;
}());
// Inherite Student class
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    //constructor 
    function Employee(value, name) {
        var _this = _super.call(this, name) || this;
        _this.Eid = value;
        return _this;
    }
    //Behaviour
    Employee.prototype.DisplayE = function () {
        console.log("ID of Employee : " + this.Eid);
    };
    return Employee;
}(Student));
// Create object of above class
var obj1 = new Employee(11, "Mayur B Chandgude");
obj1.DisplayS();
obj1.DisplayE();
// instanceof operator is used to check whether the specific variable is object of class or not
var bret = obj1 instanceof Student;
console.log(" obj1 is an instance of Student " + bret);
var bret = obj1 instanceof Employee;
console.log(" obj1 is an instance of Employee " + bret);
