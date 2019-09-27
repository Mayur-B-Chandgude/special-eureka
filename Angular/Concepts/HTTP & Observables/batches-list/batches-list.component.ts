import { Component, OnInit } from '@angular/core';
import { BatchService } from '../batch.service';

@Component({
  selector: 'app-batches-list',
  templateUrl: './batches-list.component.html',
  styleUrls: ['./batches-list.component.css']
})
export class BatchesListComponent implements OnInit
 {
  public batches = [];

  constructor(private _batchservice:BatchService) 
  { 

  }

  ngOnInit() 
  {
    this._batchservice.GetBatchesDetails().subscribe(data=>this.batches=data);
  }

}
