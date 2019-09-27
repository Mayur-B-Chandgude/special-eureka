import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-batch-details',
  templateUrl: './batch-details.component.html',
  styleUrls: ['./batch-details.component.css']
})
export class BatchDetailsComponent implements OnInit {

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
