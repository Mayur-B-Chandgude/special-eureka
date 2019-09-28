import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ArithmeticService 
{

  constructor() { }

  Add(No1:number, No2:number)
  {
    return No1 + No2;
  }

  Sub(No1:number, No2:number)
  {
    return No1 - No2;
  }

}
