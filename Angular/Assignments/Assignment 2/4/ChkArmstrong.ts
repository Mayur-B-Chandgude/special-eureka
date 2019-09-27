var ChkArmstrong = (No:number)=>
 {    
 	var digit:number , total:number , cnt:number , i:number = 0;
	var power:number = 1;

	var temp:number = 0;
	temp = No;

	while(temp != 0)
	{
		cnt++;
		temp = temp / 10;
	}

	temp = No;

	while(temp != 0)
	{
		digit = temp % 10;
		for(i = 1 ; i <= cnt ; i++)
		{
			power = power * digit;
		}
		total = total + power;
		power = 1;	
		temp = temp / 10;
	}

	if(total == No)	
	{
		return true;
	}
	else
	{
		return false;
	}
 } 
 
 var iret:boolean;
 iret = ChkArmstrong(153);
 if(iret == true)
 {
 	console.log("Number is not Armstrong..");
 }
 else
 {
 	console.log("Number is Armstrong..");
 }
 
