import { Component, OnInit } from '@angular/core';
import {MarvelData} from 'src/app/marvel-data';
@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.css']
})
export class ContactDetailsComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  obj = new MarvelData('Mayur B Chandgude', 'Excellent');
}
