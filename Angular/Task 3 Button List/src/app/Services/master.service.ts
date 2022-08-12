import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MasterService {

  employee: Employee[] =[]
  constructor() { 
    this.employee=  [{id:1,name:"Engr. Zryab",role:"Developer",gender:"male"},
    {id:2,name:"Engr. kashif",role:"Developer",gender:"male"},
    {id:3,name:"Dr. Ali",role:"Consultant",gender:"male"},
    {id:4,name:"Advocate Rana",role:"Legal Advisor",gender:"male"},
    {id:5,name:"Nadeem Ilyas",role:"Security Manager",gender:"male"},
    {id:6,name:"Prof. Ramzan",role:"Lecturer",gender:"male"},
    {id:7,name:"Shoaib Iftikhar",role:"Manager",gender:"male"},
    {id:8,name:"Najeeb Ghori",role:"Internee",gender:"male"},
    {id:9,name:"Kim jong un",role:"Chairman",gender:"male"},
    {id:10,name:"Biden",role:"Vice President",gender:"male"}]
  }

  GetEmployee(){
    return this.employee;
  }
}

export class Employee{
  id!:number;
  name!:string;
  role!:string;
  gender!:string;
}