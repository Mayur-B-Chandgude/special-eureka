/*
Interface :
    Interfaces define properties, methods, and events, which are the members of the interface.
    Interfaces contain only the declaration of the members.
    It is the responsibility of the deriving class to define the members.
    It often helps in providing a standard structure that the deriving classes would follow.
*/
// Implement the above interface
var obj1 = {
    name: "Mayur B Chandgude",
    college: "Pune University",
    fun: function () { return "Welcome to Marvellous Infosystems"; }
};
// Display contents of object
console.log("Students Object obj1:");
console.log(obj1.name);
console.log(obj1.college);
console.log(obj1.fun());
// Implement the above interface
var obj2 = {
    name: "Rahul Joshi",
    college: "Modern",
    fun: function () { return "Marvellous : Admission Confirmed"; }
};
// Display contents of object
console.log("Students Object obj2");
console.log(obj2.name);
console.log(obj2.college);
console.log(obj2.fun());
