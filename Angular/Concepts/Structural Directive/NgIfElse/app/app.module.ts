import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MarvellousCompComponent } from './marvellous-comp/marvellous-comp.component';

@NgModule({
  declarations: [
    AppComponent,
    MarvellousCompComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
