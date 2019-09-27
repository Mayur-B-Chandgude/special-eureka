import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-marvellous-comp',
  templateUrl: './marvellous-comp.component.html',
  styleUrls: ['./marvellous-comp.component.css']
})
export class MarvellousCompComponent implements OnInit 
{
  bname : string;
  str : string;

  flag : boolean = false;

  public gun()
  {
    this.str = "You Entered batch name is " + this.bname;
  }

  public fun(event : any)
  {
    this.flag = true;
    this.bname = (<HTMLInputElement>event.target).value;
  }

  ngOnInit()
  {

  }

}
