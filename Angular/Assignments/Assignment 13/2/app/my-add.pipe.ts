import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'myAdd'
})
export class MyAddPipe implements PipeTransform 
{

  transform(value1: any, value2: any): any 
  {
    return value1 + value2;
  }

}
