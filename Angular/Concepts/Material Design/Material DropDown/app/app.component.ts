import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent 
{
Batches =  [
  {name: 'Pre-Placement Activity', Fees:9000},
  {name: 'Logic Building', Fees:7500},
  {name: 'Web Development', Fees:4000},
  {name: 'Industrial Project', Fees:4000},
  {name: 'Linux System Programming', Fees:6000}
];

selectedValue:string;
}
