import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit 
{
  @Input() public ParentData;
  
  @Output() public MyEvent = new EventEmitter();

  public SendEvent()
  {
    this.MyEvent.emit("Hello From Child..");
  }
  
  constructor() { }

  ngOnInit() {
  }

}
