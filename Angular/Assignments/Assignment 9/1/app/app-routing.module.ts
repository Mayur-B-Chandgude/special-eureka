import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TechnologiesComponent } from './technologies/technologies.component';
import { BooksComponent } from './books/books.component';
import { DefaultPageComponent } from './default-page/default-page.component';
import { InvalidPageComponent } from './invalid-page/invalid-page.component';


const routes: Routes = [
  {path : 'Technologies', component:TechnologiesComponent},
  {path : 'Books', component:BooksComponent},
  {path : '', component:DefaultPageComponent},
  {path : '**', component:InvalidPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
