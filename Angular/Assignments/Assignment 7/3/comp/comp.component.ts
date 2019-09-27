import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit
{
  //public flag = true;
  public str="";
  public Name;

  constructor() 
  { 

  }

  ngOnInit() 
  {

  }

  public fun()
  {
    return this.Name = "Marvellous Infosystems";
  }
  
  public MarvellousNewEvent()
  {
    this.str="Educating for Better tomorrow"; 
  }
}
