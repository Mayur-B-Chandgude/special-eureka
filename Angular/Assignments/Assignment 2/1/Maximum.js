function Maximum() {
    var Arr = [23, 89, 6, 29, 56, 45, 77, 32];
    var max = Arr[0];
    for (var i = 0; i < Arr.length; i++) {
        if (Arr[i] > max) {
            max = Arr[i];
        }
    }
    return max;
}
var iret;
iret = Maximum();
console.log("maximum Number is:" + iret);
