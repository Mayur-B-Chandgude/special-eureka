function DisplayFactors(No:number) 
{ 
   for(var i = 0; i < No; i++)
   {
   	if((No % i) == 0)
   	{
   		console.log(i);
   	}
   }
} 

DisplayFactors(20); 

