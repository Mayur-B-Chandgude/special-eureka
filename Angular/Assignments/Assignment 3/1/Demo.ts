
class Arithmatic
{
	public No1:number = 0;
	public No2:number = 0;
	public ret:number = 0;
	
	constructor(value1:number, value2:number)
	{
		this.No1 = value1;
		this.No2 = value2;
	}
	
	Addition():number
	{
		ret = this.No1 + this.No2;
		return ret;
	}
	
	Substraction():number
	{
		ret = this.No1 - this.No2;
		return ret;
	}
	
	Multiplication():number
	{
		ret = this.No1 * this.No2;
		return ret;
	}
	
	Division():number
	{
		ret = this.No1 / this.No2;
		return ret;
	}
}

/*********************************************************************/
console.log("Object 1:");
var obj1 = new Arithmatic(10 , 5);

var ret:number;

ret = obj1.Addition();
console.log("Addition is:" + ret);

ret = obj1.Substraction();
console.log("Substraction is:" + ret);

ret = obj1.Multiplication();
console.log("Multiplication is:" + ret);

ret = obj1.Division();
console.log("Division is:" + ret);
/*********************************************************************/

console.log("Object 2:");
var obj2 = new Arithmatic(20 , 5);

ret = obj2.Addition();
console.log("Addition is:" + ret);

ret = obj2.Substraction();
console.log("Substraction is:" + ret);

ret = obj2.Multiplication();
console.log("Multiplication is:" + ret);

ret = obj2.Division();
console.log("Division is:" + ret);
/*********************************************************************/

