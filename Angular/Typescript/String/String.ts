
var str = new String("Marvellous");
var ptr = new String("Infosystems");

console.log("str.charAt(0) is:" + str.charAt(0));
console.log("str.charAt(1) is:" + str.charAt(1));

console.log("str.charCodeAt(0) is:" + str.charCodeAt(0));
console.log("str.charCodeAt(1) is:" + str.charCodeAt(1));

console.log("Length of str is:" + str.length);
console.log("Length of ptr is:" + ptr.length);


var str1 = "Marvellous";
var ptr1 = "Infosystems";
var final = str1.concat(ptr1);
console.log("Concat String is:" + final);

var ret = ptr.indexOf("sys");
console.log("Index of sys is:" + ret);

var ret1 = ptr.indexOf("Pune");
console.log("Index of Pune is:" + ret1);


var str2 = "MarvellousInfosystemsMarvellousPuneAndNashik";
var ret2 = str2.lastIndexOf("Marvellous");
console.log("Last index of marvellous is:" + ret2);

var replace = /Marvellous/gi;
var str2 = "Marvellous Infosystems Pune & Marvellous Magic Thoughts Pune";
var newstr = str2.replace(replace, "NewMarvellous");
console.log(newstr);

var replace1 = /Marvellous/gi;
var str3 = "Marvellous Infosystems Pune & Marvellous Magic Thoughts Pune";
if(str3.search(replace1) == -1)
{
	console.log("Does not contain Marvellous..");
}
else
{
	console.log("contains Marvellous..");
}


var str4 = "Marvellous Infosystems Educating for better tomorrow";
var arr = str4.split("", 6);
console.log(arr);


var MarvellousStr:number = 112151;
console.log(MarvellousStr.toString());





























