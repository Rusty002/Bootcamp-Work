import { Component, OnInit, Input } from '@angular/core';
import { MasterService } from 'src/app/Services/master.service';
import { Employee } from 'src/app/Services/master.service';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styleUrls: ['./emp-details.component.css']
})
export class EmpDetailsComponent implements OnInit {

  emp:Employee[]=[];
  constructor(private employeeService:MasterService ) {}

  ngOnInit(): void {
    this.emp =this.employeeService.GetEmployee();
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
