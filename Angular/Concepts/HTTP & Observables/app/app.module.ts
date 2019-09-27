import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BatchDetailsComponent } from './batch-details/batch-details.component';
import { BatchesListComponent } from './batches-list/batches-list.component';

import { BatchService } from './batch.service';

import {HttpClientModule} from '@angular/common/http'
//import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    BatchDetailsComponent,
    BatchesListComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [BatchService],
  bootstrap: [AppComponent]
})
export class AppModule { }
