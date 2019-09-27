function ChkPrime(No) {
    if ((No % 2) == 0) {
        return false;
    }
    else {
        return true;
    }
}
var iret;
iret = ChkPrime(11);
if (iret == true) {
    console.log("Number is Prime..");
}
else {
    console.log("Number is not Prime..");
}
