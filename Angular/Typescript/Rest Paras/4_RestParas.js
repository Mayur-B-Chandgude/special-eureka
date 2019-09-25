/*

Application to demonstrate concept of Rest Parameters.

Rest Parameters / Variable number of arguments

Rest parameters don’t restrict the number of values that we can pass to a function.

However, the values passed must all be of the same type.

To declare a rest parameter, the parameter name is prefixed with three periods.
Any nonrest parameter should come before the rest parameter.

*/
function Display() {
    var arr = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        arr[_i] = arguments[_i];
    }
    var i;
    console.log("Number of arguments are : " + arr.length);
    for (i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}
Display(1, 2, 3);
Display(11, 21, 51, 101);
