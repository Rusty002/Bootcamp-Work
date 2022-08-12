import { Component, OnInit } from '@angular/core';
import { Employee } from '../employees.module';


@Component({
  selector: 'app-container',
  templateUrl: './container.component.html',
  styleUrls: ['./container.component.css']
})
export class ContainerComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  EmployeeDetials!:Employee;

  selectedEmployee(emp:Employee){
    this.EmployeeDetials=emp;
  }  
}
