import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBatches } from './batches';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class BatchService 
{

  constructor(private http:HttpClient) 
  {

  }

  private _url:string = "/assets/Data/batches.json";
  
  GetBatchesDetails():Observable<IBatches[]>
  {
    return this.http.get<IBatches[]>(this._url);
  }
}
