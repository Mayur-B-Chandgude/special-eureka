
var ChkString = ()=>
 {    
    var str:string = "Pune Kothrud Marvellous Infosystems";
    var search = /Marvellous/i;
    
    if(search.test(str))
    {
	return true;
    }
    else
    {
    	return false;
    }
 } 

var iret:boolean;
iret = ChkString();
if(iret == true)
{
	console.log("String contains Marvellous in it");
}
else
{
	console.log("No such String..");
}
