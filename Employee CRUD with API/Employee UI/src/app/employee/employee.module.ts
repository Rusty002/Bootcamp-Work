import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main/main.component';
import { ShowComponent } from './show/show.component';
import { AddUpdateComponent } from './add-update/add-update.component';
import { DetailComponent } from './detail/detail.component';




@NgModule({
  declarations: [
    MainComponent,
    ShowComponent,
    AddUpdateComponent,
    DetailComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports:[
    MainComponent,
    ShowComponent,
    AddUpdateComponent
  ]
})
export class EmployeeModule { }
