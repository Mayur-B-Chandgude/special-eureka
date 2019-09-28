import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'myMult'
})
export class MyMultPipe implements PipeTransform 
{

  transform(value1: any, value2: any): any 
  {
    return value1 * value2;
  }

}
