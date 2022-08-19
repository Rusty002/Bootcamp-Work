import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/service/shared.service';
import { Employee } from 'src/Models/Employee';
import {AfterViewInit, ViewChild} from '@angular/core';
// import {MatPaginator} from '@angular/material/paginator';
// import {MatTableDataSource} from '@angular/material/table';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {

  constructor(private service:SharedService) { }

  //Declaration of variables to be used by component
  employeeList:any=[];
  modalTitle:string="";
  ActivateAddEditEmployee:boolean=false;
  activateDetails:boolean=false;
  tempEmp:any;

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  refreshEmployeeList(){
    this.service.getEmpList().subscribe(data =>{
      this.employeeList=data;
    });
  }

  addEmployee(){
    this.tempEmp={
      EmpName:"",
      City:"",
      Gender:""
    }
    this.modalTitle="Add Employee";
    
    this.ActivateAddEditEmployee=true;
  }

  closeClick(){
    this.ActivateAddEditEmployee=false;
    this.activateDetails=false;
    this.refreshEmployeeList();
  }

  editEmployee(emp:Employee){
    this.tempEmp=emp;
    this.modalTitle="Edit Employee";
    this.ActivateAddEditEmployee=true;
  }

  deleteEmployee(emp:Employee){
   if(confirm('Are you Sure?')){
    this.service.deleteEmployee(emp.EmployeeID).subscribe(data =>{
      alert(data.toString());
      this.refreshEmployeeList();
    });
   } 
  }

  viewEmployee(emp:Employee){
    this.tempEmp=emp;
    this.modalTitle="Details of Employee";
    this.activateDetails=true;
  }
}
