import { Component, OnInit } from '@angular/core';
import { ArithmeticService } from '../arithmetic.service';

@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit 
{
  public result;
  public cnt;

  constructor(private _ArithmeticService:ArithmeticService) 
  { 

  }

  ngOnInit() 
  {
    this.result = this._ArithmeticService.Add(10, 20);
    //console.log(this.result);

    this.cnt = this._ArithmeticService.Sub(20, 10);
  }

}
