import { Component, OnInit } from '@angular/core';
import {  ComunicacionService } from 'src/app/services/comunicacion.service';

@Component({
  selector: 'app-comunicacion1',
  templateUrl: './comunicacion1.component.html',
  styleUrls: ['./comunicacion1.component.css']
})
export class Comunicacion1Component implements OnInit {

  mensajes: any = [];

  constructor(
    private readonly as:ComunicacionService
  ) { }

  __getMensajesLocal(){
    this.as.__getMensajesLocal().subscribe((rest:any) => {
      this.mensajes = rest.data;
      console.log(this.mensajes);
    })
  }
  
  ngOnInit(): void {
    this.__getMensajesLocal();
  }

}
