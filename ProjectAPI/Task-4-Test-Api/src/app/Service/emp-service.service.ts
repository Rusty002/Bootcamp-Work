import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Models/Employee';

@Injectable({
  providedIn: 'root'
})
export class EmpServiceService {

  readonly APIUrl="http://localhost:11836/";
  constructor(private http:HttpClient) { }

  GetEmployee(val:any):Observable<any[]>{
    return this.http.get<any>(this.APIUrl+"GetEmployee/"+val);
  }

  // addEmployee(val:any){
  //   return this.http.post(this.APIUrl+"",val);
  // }

  // updateEmployee(val:any){
  //   return this.http.put(this.APIUrl,val);
  // }

  // deleteEmployee(val:any){
  //   return this.http.delete(this.APIUrl+""+val);
  // }

  GetAllEmployees():Observable<any[]>{
    return this.http.get<Employee[]>(this.APIUrl+"GetEmployees");
  }
}
