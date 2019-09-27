import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BatchDetailsComponent } from './batch-details/batch-details.component';
import { BatchesListComponent } from './batches-list/batches-list.component';

@NgModule({
  declarations: [
    AppComponent,
    BatchDetailsComponent,
    BatchesListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
