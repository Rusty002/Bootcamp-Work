import { Component, Input, OnInit, } from '@angular/core';
import { FormControl, FormGroup, RequiredValidator, Validators, FormBuilder } from '@angular/forms';
import { SharedService } from 'src/app/service/shared.service';
import { Employee } from 'src/Models/Employee';

@Component({
  selector: 'app-add-update',
  templateUrl: './add-update.component.html',
  styleUrls: ['./add-update.component.css']
}) 
export class AddUpdateComponent implements OnInit {

  constructor(private service:SharedService, private formBuilder:FormBuilder) { }

  @Input() emp:Employee = {} as Employee;
  employeeForm!: FormGroup;
  //@Input() emp:any;
  employeeName:string="";
  employeeCity:string="";
  employeeGender:string="";
  employeeID:number=0;

  ngOnInit(): void {
    if(this.emp.EmployeeID > 0)
    {
      this.employeeName=this.emp.EmpName;
      this.employeeCity=this.emp.City;
      this.employeeGender=this.emp.Gender;
      this.employeeID=this.emp.EmployeeID;
    }
    else{
      this.employeeName=this.emp.EmpName;
      this.employeeCity=this.emp.City;
      this.employeeGender=this.emp.Gender;
    }

    this.employeeForm= this.formBuilder.group({
      name: ['', [ 
        Validators.required,
        Validators.minLength(3)
      ]],
      city: ['', [ 
        Validators.required,
        Validators.minLength(2)
      ]],
      gender: ['', [ 
        Validators.required,
        Validators.minLength(1)
      ]],
    })
  }

  addEmployee(){
    var newEmployee = {
      EmpName:this.employeeName,
      City:this.employeeCity,
      Gender:this.employeeGender,
    }
    this.service.addEmployee(newEmployee).subscribe(res =>{
      alert(res.toString());
      this.employeeName="";
      this.employeeCity="";
      this.employeeGender="";
    });
  }

  // Update Employee Function
  updateEmployee(){
    var newEmplyee = {
      EmployeeID:this.emp.EmployeeID,
      EmpName:this.employeeName,
      City:this.employeeCity,
      Gender:this.employeeGender,
    }
    this.service.updateEmployee(newEmplyee).subscribe(res =>{
      alert(res.toString());
    });
  }

  // Function Submit
  onSubmit(){
    // console.log(this.employeeForm.value);
    if(this.employeeID>0)
    {
      this.updateEmployee();
    }
    else{
      this.addEmployee();
    }
  }
}
