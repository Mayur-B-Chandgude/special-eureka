import { Pipe, PipeTransform } from '@angular/core';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';

@Pipe({
  name: 'marvellousPipe'
})
export class MarvellousPipePipe implements PipeTransform 
{

  transform(value: any, ...args: any[]): any 
  {
    let str = value;

    if(args[0] == "Marvellous")
    {
      str += "Educting for better tomorrow"
    }

    return str;
  }
}
