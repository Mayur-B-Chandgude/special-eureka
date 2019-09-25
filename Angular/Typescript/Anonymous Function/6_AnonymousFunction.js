/*
Application which demonstrate concept of anonymous function.

Anonymous Function :
Functions that are not bound to an identifier (function name) are called as anonymous functions.
These functions are dynamically declared at runtime.
*/
var iret = function (no1, no2) {
    return no1 + no2;
};
console.log(iret(8, 3));
