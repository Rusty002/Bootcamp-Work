import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly apiUrl="http://localhost:11836/";
  constructor(private http:HttpClient) { }


  getEmpList():Observable<any[]>{
    return this.http.get<any>(this.apiUrl+'/GetEmployees');
  }

  addEmployee(val:any){
    return this.http.post(this.apiUrl+'/AddEmployee',val);
  }

  updateEmployee(val:any){
    return this.http.put(this.apiUrl+'/UpdateEmployee',val);
  }

  deleteEmployee(val:any){
    return this.http.delete(this.apiUrl+'/DeleteEmployee/'+val);
  }
  
}
