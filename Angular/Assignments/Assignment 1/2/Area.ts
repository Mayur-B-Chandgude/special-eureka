function Area(r:number, PI:number = 3.14) 
{ 
   var area = PI * r * r; 
   return area; 
} 

var iret:number;
iret = Area(5); 
console.log("Area of Circle is:" + iret);

