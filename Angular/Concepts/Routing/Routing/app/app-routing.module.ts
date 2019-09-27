import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { componentFactoryName } from '@angular/compiler';

import { BatchesComponent } from './batches/batches.component';
import { SubjectsComponent } from './subjects/subjects.component';


const routes: Routes = [
  {path : 'batches', component:BatchesComponent},
  {path : 'subjects', component:SubjectsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
