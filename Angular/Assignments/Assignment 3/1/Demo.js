var Arithmatic = /** @class */ (function () {
    function Arithmatic(value1, value2) {
        this.No1 = 0;
        this.No2 = 0;
        this.ret = 0;
        this.No1 = value1;
        this.No2 = value2;
    }
    Arithmatic.prototype.Addition = function () {
        ret = this.No1 + this.No2;
        return ret;
    };
    Arithmatic.prototype.Substraction = function () {
        ret = this.No1 - this.No2;
        return ret;
    };
    Arithmatic.prototype.Multiplication = function () {
        ret = this.No1 * this.No2;
        return ret;
    };
    Arithmatic.prototype.Division = function () {
        ret = this.No1 / this.No2;
        return ret;
    };
    return Arithmatic;
}());
/*********************************************************************/
console.log("Object 1:");
var obj1 = new Arithmatic(10, 5);
var ret;
ret = obj1.Addition();
console.log("Addition is:" + ret);
ret = obj1.Substraction();
console.log("Substraction is:" + ret);
ret = obj1.Multiplication();
console.log("Multiplication is:" + ret);
ret = obj1.Division();
console.log("Division is:" + ret);
/*********************************************************************/
console.log("Object 2:");
var obj2 = new Arithmatic(20, 5);
ret = obj2.Addition();
console.log("Addition is:" + ret);
ret = obj2.Substraction();
console.log("Substraction is:" + ret);
ret = obj2.Multiplication();
console.log("Multiplication is:" + ret);
ret = obj2.Division();
console.log("Division is:" + ret);
/*********************************************************************/
