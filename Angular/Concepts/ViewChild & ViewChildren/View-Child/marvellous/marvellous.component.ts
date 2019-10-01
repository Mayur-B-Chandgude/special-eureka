import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-marvellous',
  templateUrl: './marvellous.component.html',
  styleUrls: ['./marvellous.component.css']
})
export class MarvellousComponent implements OnInit 
{

  constructor() 
  { 

  }

  ngOnInit() 
  {

  }

  @ViewChild("myref",{static : false}) myvalue:ElementRef;

  ngAfterViewInit()
  {
    console.log(this.myvalue);
    this.myvalue.nativeElement.focus();
  }
}
