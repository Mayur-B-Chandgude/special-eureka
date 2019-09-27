var str = 'A string to test JavaScript string methods';
var re = /String/i;
console.log(re.test(str)); // true
var ChkString = function () {
    var str = "Pune Kothrud Marvellous Infosystems";
    var search = /Marvellous/i;
    if (search.test(str)) {
        return true;
    }
    else {
        return false;
    }
};
var iret;
iret = ChkString();
if (iret == true) {
    console.log("String contains Marvellous in it");
}
else {
    console.log("No such String..");
}
