import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NumberService 
{

  constructor() { }

  ChkPrime(No:number)
  {
    if((No % 2) == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
