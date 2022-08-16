import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { EmpServiceService } from 'src/app/Service/emp-service.service';
import { Employee } from 'src/app/Models/Employee';
import { map } from 'rxjs';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent implements OnInit {
  employee : Employee[]=[];
  @Output() ShowEmployee:EventEmitter<Employee>=new EventEmitter();

  constructor(private employeeService:EmpServiceService) {
     
  }

  ngOnInit(): void {
    this.employeeService.GetAllEmployees().pipe(
      map((data : Employee[]) => {
        if(data!== null && data !== undefined){
          this.employee=data;
        }
      })
    );
  }

  //selectedEmployee?: Employee;
  onSelect(emp:Employee){
    this.ShowEmployee.emit(emp);
  }
}
