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
var CircleX = /** @class */ (function (_super) {
    __extends(CircleX, _super);
    function CircleX() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    CircleX.prototype.Circumference = function () {
        var ret = 0;
        ret = 2 * this.PI * this.radius;
        return ret;
    };
    return CircleX;
}(Circle));
/*****************************************************************************************/
var obj1 = new CircleX(5);
var ret;
ret = obj1.Area();
console.log("Area of Circle is:" + ret);
var obj2 = new CircleX(5);
var ret;
ret = obj2.Circumference();
console.log("Circumference of Circle is:" + ret);
/*****************************************************************************************/
