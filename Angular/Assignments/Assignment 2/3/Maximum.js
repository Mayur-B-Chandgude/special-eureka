function Maximum() {
    var Arr = [23, 89, 6, 29, 56, 45, 77, 32];
    var max = 0;
    var secondmax = 0;
    for (var i = 0; i < Arr.length; i++) {
        if (Arr[i] > max) {
            secondmax = max;
            max = Arr[i];
        }
        else if ((Arr[i] > secondmax) && (max != Arr[i])) {
            secondmax = Arr[i];
        }
    }
    return secondmax;
}
var iret;
iret = Maximum();
console.log("Second Maximum Number is:" + iret);
