import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompComponent } from './comp/comp.component';

import { ArithmeticService } from './arithmetic.service';
  import { from } from 'rxjs';
 
@NgModule({
  declarations: [
    AppComponent,
    CompComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [ArithmeticService],
  bootstrap: [AppComponent]
})
export class AppModule { }
