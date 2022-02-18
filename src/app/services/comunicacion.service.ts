import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ComunicacionService {

  constructor(
    private readonly http: HttpClient 
  ) { }

  __getMensajesLocal(){
    return this.http.get('https://localhost:44309/api/mensaje/getmensajes');
  }
}
