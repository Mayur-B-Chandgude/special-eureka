/*
Application which demonstates diffrent scopes of variables.

The scope of a variable specifies where the variable is defined. The availability of a variable within a program is determined by its scope.
There are three types of scopes as

Global Scope −
Global variables are declared outside the programming constructs. These variables can be accessed from anywhere within code.

Class Scope −
These variables are also called fields. Fields or class variables are declared within the class but outside the methods.
These variables can be accessed using the object of the class. Fields can also be static. Static fields can be accessed using the class name.

Local Scope −
Local variables are declared within the constructs like methods, loops etc.
Local variables are accessible only within the construct where they are declared.

*/
//global Scope
var global = 101;
var Demo = /** @class */ (function () {
    function Demo() {
        // Class Scope
        this.i = 13; //Instance variable 
    }
    Demo.prototype.fun = function () {
        // Local scope
        var local = 14;
        console.log("Value of global : " + global);
        console.log("Value of local : " + local);
        console.log("Value of class variable : " + Demo.j); // Static members can be accessed using class name
        console.log("Value of Instance variable : " + this.i); // Non static can be accessed using this.
    };
    Demo.j = 10; //Class variable 
    return Demo;
}());
console.log("Global variable: " + global);
console.log(Demo.j); //static variable  
var obj = new Demo();
obj.fun();
console.log("Instance variable: " + obj.i);
