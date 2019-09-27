
function Summation():number 
{  
    var Arr:number[] = [23, 6, 7, 4, 5, 7];
    var add:number = 0;
    
    for(var i = 0; i < Arr.length; i++)
    {
    	add = add + Arr[i];
    }
    
    return add; 
} 


var iret:number;
iret = Summation();
console.log("Addition is:" + iret);

