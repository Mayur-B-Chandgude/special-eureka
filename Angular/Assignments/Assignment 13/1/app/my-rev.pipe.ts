import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'myRev'
})
export class MyRevPipe implements PipeTransform 
{

  transform(value : String)
  {
    var temp : String = "";

    for(var i = value.length - 1; i >= 0; i--)
    {
      temp = temp + value.charAt(i);
    }

    return temp;
  }

}
