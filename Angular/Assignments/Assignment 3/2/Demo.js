var Circle = /** @class */ (function () {
    function Circle(value1, value2) {
        if (value2 === void 0) { value2 = 3.14; }
        this.radius = 0;
        this.PI = 0.0;
        this.radius = value1;
        this.PI = value2;
    }
    Circle.prototype.Area = function () {
        var ret = 0;
        ret = this.radius * this.radius * this.PI;
        return ret;
    };
    return Circle;
}());
/***************************************************************************************/
console.log("Object 1:");
var obj1 = new Circle(5);
var ret = 0;
ret = obj1.Area();
console.log("Area is;" + ret);
/***************************************************************************************/
console.log("Object 2:");
var obj2 = new Circle(6);
ret = obj2.Area();
console.log("Area is:" + ret);
/***************************************************************************************/
