import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/service/shared.service';
import { Employee } from 'src/Models/Employee';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {

  @Input() emp:Employee = {} as Employee;
  empList:any=[];
  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  refreshEmployeeList(){
    this.service.getEmpList().subscribe(data =>{
      this.empList=data;
    });
  }

  nextEmployee(){
    let index = this.empList.map((object: { EmployeeID: number; }) => object.EmployeeID).indexOf(this.emp.EmployeeID);
    if(index !== this.empList.length - 1)
    {
      this.emp = this.empList[index + 1]    
    }
    else{
      alert("You have reached the end of List")
    }
  }

  previousEmployee(){
    let index = this.empList.map((object: { EmployeeID: number; }) => object.EmployeeID).indexOf(this.emp.EmployeeID);
    if(index !== 0)
    {
      this.emp = this.empList[index - 1];
    }
    else{
      alert("There is no previous element to the present one");
    }
  }
  
}
