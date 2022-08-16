import { Component, OnInit, Input } from '@angular/core';
import { EmpServiceService } from 'src/app/Service/emp-service.service';
import { Employee } from 'src/app/Models/Employee';
import { map } from 'rxjs';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styleUrls: ['./emp-details.component.css']
})
export class EmpDetailsComponent implements OnInit {

  emp:Employee[]=[];
  constructor(private employeeService:EmpServiceService ) {}

  ngOnInit(): void {
    this.employeeService.GetAllEmployees().pipe(
      map((data : Employee[]) => {
        if(data!== null && data !== undefined){
          this.emp=data;
        }
      })
    );
  }
  
  @Input() tempEmployee!:Employee;

  PreviousEmployee(employee:Employee){
    let index = this.emp.indexOf(employee);
    if(index !== 0)
    {
      this.tempEmployee = this.emp[this.emp.indexOf(this.tempEmployee) - 1]    
    }
    else{
      alert("There is no previous element to the current one");
    }
  }

  NextEmployee(employee:Employee){
    let index = this.emp.indexOf(employee);
    if(index !== this.emp.length - 1)
    {
      this.tempEmployee = this.emp[this.emp.indexOf(this.tempEmployee) + 1]    
    }
    else{
      alert("There is no next element to the present one");
    }
  }
}
