
class Circle
{
	radius:number = 0; PI:number = 0.0;
	
	constructor(value1:number , value2:number = 3.14)
	{
		this.radius = value1;
		this.PI = value2;
	}
	
	Area():number
	{
		var ret:number = 0;
		
		ret = this.radius * this.radius * this.PI;
		return ret;
	}
}

/***************************************************************************************/
console.log("Object 1:");
var obj1 = new Circle(5);

var ret:number = 0;

ret = obj1.Area();
console.log("Area is;" + ret);
/***************************************************************************************/
console.log("Object 2:");
var obj2 = new Circle(6);

ret = obj2.Area();
console.log("Area is:" + ret);
/***************************************************************************************/
