function Area(r, PI) {
    if (PI === void 0) { PI = 3.14; }
    var area = PI * r * r;
    return area;
}
var iret;
iret = Area(5);
console.log("Area of Circle is:" + iret);
