import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent 
{
  sarr = [];
  sname:string;

  AddStudent()
  {
    this.sarr.push(this.sname);
  }

}