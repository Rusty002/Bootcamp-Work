import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/Employee';
import { EmpServiceService } from 'src/app/Service/emp-service.service';

@Component({
  selector: 'app-emp-container',
  templateUrl: './emp-container.component.html',
  styleUrls: ['./emp-container.component.css']
})
export class EmpContainerComponent implements OnInit {

  constructor(private service:EmpServiceService) { }

  EmployeeList:Employee[]=[];
  ngOnInit(): void {
    this.refreshEmpList();
  }

  refreshEmpList(){
    this.service.GetAllEmployees().subscribe(data =>{
      this.EmployeeList=data;
    });
  }

  EmployeeDetials!:Employee;

  selectedEmployee(emp:Employee){
    this.EmployeeDetials=emp;
  } 
}
