import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MarvellousPipePipe } from './marvellous-pipe.pipe';

@NgModule({
  declarations: [
    AppComponent,
    MarvellousPipePipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
