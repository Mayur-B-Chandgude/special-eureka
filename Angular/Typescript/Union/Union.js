/*
Union :
It is  ability to combine one or two types.
Two or more data types are combined using the pipe symbol (|) to denote a Union Type.
In other words, a union type is written as a sequence of types separated by vertical bars.
*/
// This variable can strore string or number in it
var val;
val = 21;
console.log("numeric value of val " + val);
val = "Marvellous Infosystems";
console.log("string value of val " + val);
// We can use the concept of union for function parameters also
// This function can accept number or array of string
function fun(name) {
    if (typeof name == "number") {
        console.log("Function called by passing number");
        console.log(name);
    }
    else {
        console.log("Function called by passing array of strings");
        for (var i = 0; i < name.length; i++) {
            console.log(name[i]);
        }
    }
}
fun(11);
fun(["PPA", "LB", "UNIX", "ANGULAR"]);
