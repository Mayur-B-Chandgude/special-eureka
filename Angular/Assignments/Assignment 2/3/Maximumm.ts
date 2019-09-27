
function Maximum():number 
{  
    var Arr:number[] = [23, 89, 6, 29, 56, 45, 77, 32];
    var max:number = 0;
    var secondmax:number = 0;
    
    for(var i = 0; i < Arr.length; i++)
    {
	if(Arr[i] > max)
	{
		secondmax = max;
		max = Arr[i];	
	}
	else if((Arr[i] > secondmax) && (max != Arr[i]))
	{
		secondmax = Arr[i];
	}
    }
    return secondmax;
} 


var iret:number;
iret = Maximum();
console.log("Second Maximum Number is:" + iret);

