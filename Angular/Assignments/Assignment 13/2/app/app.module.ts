import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MyAddPipe } from './my-add.pipe';
import { MyMultPipe } from './my-mult.pipe';

@NgModule({
  declarations: [
    AppComponent,
    MyAddPipe,
    MyMultPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
