import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-marvellous-style',
  templateUrl: './marvellous-style.component.html',
  styleUrls: ['./marvellous-style.component.css']
})
export class MarvellousStyleComponent implements OnInit 
{
  public IsSet=true;
  public MyColor="Orange";
  
  constructor() { }

  ngOnInit() {
  }

}
