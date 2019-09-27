function Summation() {
    var Arr = [23, 6, 7, 4, 5, 7];
    var add = 0;
    for (var i = 0; i < Arr.length; i++) {
        add = add + Arr[i];
    }
    return add;
}
var iret;
iret = Summation();
console.log("Addition is:" + iret);
