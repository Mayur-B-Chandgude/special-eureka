import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-subcomponent',
  templateUrl: './subcomponent.component.html',
  styleUrls: ['./subcomponent.component.css']
})
export class SubcomponentComponent implements OnInit 
{
  @Input() public ParentData;
  
  constructor() { }

  ngOnInit() {
  }

}
