
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

class CircleX extends Circle
{
	Circumference():number
	{
		var ret:number = 0;
		
		ret = 2 * this.PI * this.radius;
		return ret;
	}
}

/*****************************************************************************************/
var obj1 = new CircleX(5);

var ret:number;

ret = obj1.Area();
console.log("Area of Circle is:" + ret);

var obj2 = new CircleX(5);

var ret:number;

ret = obj2.Circumference();
console.log("Circumference of Circle is:" + ret);
/*****************************************************************************************/

