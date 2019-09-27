import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
//import { EventEmitter } from 'events';
//import { EventEmitter } from 'protractor';


@Component({
  selector: 'app-subcomponent',
  templateUrl: './subcomponent.component.html',
  styleUrls: ['./subcomponent.component.css']
})
export class SubcomponentComponent implements OnInit 
{
  @Output() public Myevent = new EventEmitter();

  public sender()
  {
    this.Myevent.emit("Hello from child..");
  }

  constructor() { }

  ngOnInit() {
  }

}
