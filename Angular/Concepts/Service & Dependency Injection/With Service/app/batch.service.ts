import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BatchService 
{

  constructor() { }

  GetBatchDetails()
  {
  return [
    {"Name":"PPA", "Fees":9000, "Duration":"4 Months"},
    {"Name":"LB", "Fees":7500, "Duration":"4 Months"},
    {"Name":"WEB", "Fees":2500, "Duration":"3 Months"},
    {"Name":"Project", "Fees":4000, "Duration":"3 Months"},
        ];
  }
}
