import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StaffRoutingModule } from './staff-routing.module';
import { StaffComponent } from './staff.component';
import { StaffDashboardComponent } from './staff-dashboard/staff-dashboard.component';


@NgModule({
  declarations: [StaffComponent, StaffDashboardComponent],
  imports: [
    CommonModule,
    StaffRoutingModule
  ]
})
export class StaffModule { }
