import { Component, OnInit } from '@angular/core';
import { NumberService } from '../number.service';
import { StringService } from '../string.service';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit 
{
  public flag = false;
  public ret;

  constructor(private _NumberService:NumberService , private _StringService:StringService) 
  { 

  }

  ngOnInit() 
  {
    this.flag = this._NumberService.ChkPrime(9);

    this.ret = this._StringService.CountCapital("ABC");
  }

}
