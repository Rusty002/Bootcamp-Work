import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Country } from '../../Models/Country';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

    readonly apiUrl = "https://localhost:44313/";
    constructor(private http: HttpClient) { }

    getCountries(): Observable<Country> {
        return this.http.get<Country>(this.apiUrl+"api/Country");
    }

    getHolidays(): Observable<any> {
        return this.http.get<any>(this.apiUrl+'api/Holiday');
    }

    penalty(val: any) {
        return this.http.post(this.apiUrl + 'api/Penalty', val);
    }
}
