import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent 
{
  favoriteSeason: string;
  modesarr: string[] = ['Cash ', 'Chaque ', 'Paytm ', 'DD '];
}
