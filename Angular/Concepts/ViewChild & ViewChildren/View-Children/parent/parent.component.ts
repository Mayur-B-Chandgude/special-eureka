import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';
import { ChildComponent } from '../child/child.component';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent
{
  @ViewChildren(ChildComponent) myvalue:QueryList<ChildComponent>;

  ngAfterViewInit()
  {
    console.log(this.myvalue.toArray());
  }
}

//Uncomment the following code when you want to use viewchildren
 //export class FirstComponent implements OnInit {

//   @ViewChildren(ClockComponent) myValue:QueryList<ClockComponent>;

//   constructor() { 
//     console.log(this.myValue);
//   }

//   ngAfterViewInit(){
//     console.log(this.myValue.toArray());
//   }

//   ngOnInit() {
//   }

// }