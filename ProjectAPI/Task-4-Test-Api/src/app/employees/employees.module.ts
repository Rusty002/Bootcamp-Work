import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmpContainerComponent } from './emp-container/emp-container.component';
import { EmpListComponent } from './emp-list/emp-list.component';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { Employee } from '../Models/Employee';



@NgModule({
  declarations: [
    EmpContainerComponent,
    EmpListComponent,
    EmpDetailsComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    EmpContainerComponent,
    EmpListComponent,
    EmpDetailsComponent
  ]
})
export class EmployeesModule { }
