import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmpListComponent } from './emp-list/emp-list.component';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { ContainerComponent } from './container/container.component';



@NgModule({
  declarations: [
    EmpListComponent,
    EmpDetailsComponent,
    ContainerComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    EmpDetailsComponent,
    EmpListComponent,
    ContainerComponent
  ]
})


export class EmployeesModule { 
  selectedEmployee(emp:Employee){
    console.log(emp);
  } 
}

export class Employee{
  id!:number;
  name!:string;
  role!:string;
  gender!:string;
}
