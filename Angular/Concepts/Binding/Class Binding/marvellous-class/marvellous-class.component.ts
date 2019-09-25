import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-marvellous-class',
  templateUrl: './marvellous-class.component.html',
  styleUrls: ['./marvellous-class.component.css']
})
export class MarvellousClassComponent implements OnInit 
{
  public MyClass="success";
  
  public IsSet = "true";

  constructor() { }

  ngOnInit() {
  }

}
