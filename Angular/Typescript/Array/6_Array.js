/*
Application demonstrates concept of array.

Array is connsidered as homogeneous collections of elements stored in contiguous memory locations and accessed using index.

There are diffrent ways in which we can create array.
*/
// Create array and then initialise
var arr1;
arr1 = [1, 2, 3, 4, 5];
// Create and initialise the array
var arr2 = [11, 21, 51, 101];
// Create array using Array class object
var arr3 = new Array(4);
arr3 = [1, 2, 3, 4];
// Traverse array using for loop
for (var i = 0; i < arr3.length; i++) {
    console.log(arr3[i]);
}
// Createing array of strings
var batches = new Array("PPA", "UNIX", "LB", "ANGULAR");
for (var i = 0; i < batches.length; i++) {
    console.log(batches[i]);
}
