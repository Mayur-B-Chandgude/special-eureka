import { Component, OnInit } from '@angular/core';
import { BatchService } from '../batch.service';

@Component({
  selector: 'app-batch-details',
  templateUrl: './batch-details.component.html',
  styleUrls: ['./batch-details.component.css']
})
export class BatchDetailsComponent implements OnInit 
{
  public batches = [];

  constructor(private _batchservice:BatchService)
  {

  }

  ngOnInit()
  {
    this.batches = this._batchservice.GetBatchDetails();
  }

}
