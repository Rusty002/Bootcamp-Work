import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { MasterService } from 'src/app/Services/master.service';
import { Employee } from 'src/app/Services/master.service';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent implements OnInit {
  employee : Employee[]=[];

  @Output() ShowEmployee:EventEmitter<Employee>=new EventEmitter();

  constructor(private employeeService:MasterService) {
     
  }

  ngOnInit(): void {
    this.employee=this.employeeService.GetEmployee();
  }

  //selectedEmployee?: Employee;
  onSelect(emp:Employee){
    this.ShowEmployee.emit(emp);
  }
}
