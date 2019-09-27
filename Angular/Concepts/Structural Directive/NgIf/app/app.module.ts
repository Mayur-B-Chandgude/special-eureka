import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NgIfDemoComponent } from './ng-if-demo/ng-if-demo.component';

@NgModule({
  declarations: [
    AppComponent,
    NgIfDemoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
