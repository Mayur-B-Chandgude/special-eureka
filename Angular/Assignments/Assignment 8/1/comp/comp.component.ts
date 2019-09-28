import { Component, OnInit, Output, Input, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit 
{
  @Output() public MyEvent = new EventEmitter();

  public SendEvent(value)
  {
    this.MyEvent.emit(value);
  }

  constructor() { }

  ngOnInit() {
  }

}
