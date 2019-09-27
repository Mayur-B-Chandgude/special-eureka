import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit 
{
  public str: string;

  constructor() 
  { 

  }

  ngOnInit() 
  {

  }

  public fun()
  {
    return this.str = "Marvellous Infosystems !";
  }
}
