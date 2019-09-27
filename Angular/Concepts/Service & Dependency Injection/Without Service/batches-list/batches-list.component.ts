import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-batches-list',
  templateUrl: './batches-list.component.html',
  styleUrls: ['./batches-list.component.css']
})
export class BatchesListComponent implements OnInit {

  constructor() { }

  public batches = 
  [
    {"Name":"PPA", "Fees":9000, "Duration":"4 Months"},
    {"Name":"LB", "Fees":7500, "Duration":"4 Months"},
    {"Name":"WEB", "Fees":2500, "Duration":"3 Months"},
    {"Name":"Project", "Fees":4000, "Duration":"3 Months"},
  ];

  ngOnInit() {
  }

}
