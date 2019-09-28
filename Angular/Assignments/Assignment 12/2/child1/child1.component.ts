import { Component, OnInit } from '@angular/core';
import { NumberService } from '../number.service';

@Component({
  selector: 'app-child1',
  templateUrl: './child1.component.html',
  styleUrls: ['./child1.component.css']
})
export class Child1Component implements OnInit 
{
  //public ret:any;
  public flag = false;

  constructor(private _NumberService:NumberService) 
  { 

  }

  ngOnInit() 
  {
    this.flag = this._NumberService.ChkPrime(6);
  }

}
