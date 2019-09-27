function Fibonacci(No:number)
{ 
    var i:number = 1, a:number = 1 , b:number;

	while(i <= No)
	{
		console.log(i);
		b = i + a;
		i = a;
		a = b;
	}
} 

Fibonacci(21); 

