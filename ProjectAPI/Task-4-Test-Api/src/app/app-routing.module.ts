import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmpContainerComponent } from './employees/emp-container/emp-container.component';
// import { EmpListComponent } from './employees/emp-list/emp-list.component';
// import { EmpDetailsComponent } from './employees/emp-details/emp-details.component';

const routes: Routes = [
  {path:"employees",component:EmpContainerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
