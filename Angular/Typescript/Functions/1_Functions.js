/*
Program to demonstrate concept of functions in typescript.
*/
// Add funnction accept two parameters as number and return one value as number
function Add(no1, no2) {
    var ans;
    ans = no1 + no2;
    return ans;
}
// Call the add function
var iret;
iret = Add(10, 1);
console.log("Addition is :" + iret);
