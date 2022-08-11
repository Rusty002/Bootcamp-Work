import { Component, OnInit, Input } from '@angular/core';
import { Employee } from '../employees.module';

@Component({
  selector: 'app-emp-details',
  templateUrl: './emp-details.component.html',
  styleUrls: ['./emp-details.component.css']
})
export class EmpDetailsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
  @Input() tempEmployee!:Employee;
  // onSelect(emp:Employee){
  //   this.selectedEmployee=emp;
  // }
}
