function Maximum(No1, No2, No3) {
    if ((No1 > No2) && (No1 > No3)) {
        return No1;
    }
    else if ((No2 > No1) && (No2 > No3)) {
        return No2;
    }
    else {
        return No3;
    }
}
var iret;
iret = Maximum(23, 89, 6);
console.log("Maximum Number is :" + iret);
