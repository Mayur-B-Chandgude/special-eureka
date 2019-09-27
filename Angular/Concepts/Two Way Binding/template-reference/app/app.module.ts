import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MarvellousTemplateComponent } from './marvellous-template/marvellous-template.component';

@NgModule({
  declarations: [
    AppComponent,
    MarvellousTemplateComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
