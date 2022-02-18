import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ApartmentService {

  constructor(
    private readonly http: HttpClient 
  ) { }

  // __getApartmentsLocal(){
  //   return this.http.get('/api/apartment/GetApartments');
  // }


  __getApartmentsLocal(){
    return this.http.get('https://localhost:44309/api/apartment/getapartments');
  }
}


