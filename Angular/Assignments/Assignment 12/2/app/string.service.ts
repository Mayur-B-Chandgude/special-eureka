import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StringService 
{

  constructor() { }

  CountCapital(str:String)
  {
    //var i: number;
    var cnt = 0;

    for(var i = 0; i < str.length; i++)
    {
      if((str[i] >= 'A') && (str[i] <= 'Z'))
      {
        cnt++;
      }
    }

    return cnt;
  }
}
