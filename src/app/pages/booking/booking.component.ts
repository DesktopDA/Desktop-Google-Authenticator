import { getLocaleTimeFormat } from '@angular/common';
import { Component, Input, OnChanges, OnInit, SimpleChange, ɵsetCurrentInjector } from '@angular/core';
import { FormBuilder, FormControl, NgSelectOption } from '@angular/forms';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {
   bookingForm = this.fb.group ({
      area:[''],
      zona:[''],
      fecha_reserva:[''],
      hora_reserva:[''],
      check_invitado:[''],
      nombre_invitado:[''],
      documento_invitado:['']
   })

  constructor(
     private fb: FormBuilder
  ) { }

  ngOnInit(): void {
     
  }


selectedValue = null;
nombre_zona = null;

  /* isChecked = 0; */
isChecked: boolean = false;



fecha_min_a = new Date().toLocaleDateString('en-ca').slice(0, 10);
fecha_min_b = new Date(new Date().setDate(new Date().getDate() + 1)).toLocaleDateString('en-ca').slice(0, 10);

fecha_base = this.selectedValue==0?this.fecha_min_a:this.fecha_min_b;



/* fecha_min = this.selectedValue == 0? new Date().toLocaleDateString('en-ca').slice(0, 10):new Date(new Date().setDate(new Date().getDate() + 1)).toLocaleDateString('en-ca').slice(0, 10);
preguntar como hago para que sea una sola variable */

/* fecha_min = new Date(new Date().setDate(new Date().getDate() + 1)).toLocaleDateString('en-ca').slice(0, 10); fecha MAÑANA
   fecha_min = new Date().toLocaleDateString('en-ca').slice(0, 10); fecha HOY funciona bien sin crear array*/
/* fecha_min = new Date().toLocaleDateString('en-ca').substring(0, 10);   funciona bien no hora utc sino local
   fecha_min = new Date(Date.now()).toISOString().substring(0, 10)  funciona bien hora UTC */
/* fecha_min = new Date().toISOString().split("T")[0];  */    
/* fecha_min = this.selectedValue == 0? new Date().toISOString().substring(0, 10):new Date(Date.now()+1).toISOString().substring(0, 10); NO FUNCIONA*/


/* test = new Date().getHours() + new Date().getMinutes()/60>6?new Date(new Date(new Date().setMinutes(0)).setHours(new Date(new Date().setMinutes(0)).getHours()+1)).toLocaleString('sv-SE').split(" ")[1].slice(0,5):"06:00";  */

/* test=new Date().getHours() + new Date().getMinutes()/60>1?new Date(new Date().setTime(new Date().getTime() + 1)).toLocaleString('sv-SE').split(" ")[1].slice(0,5):"01:00"; */
/* test = new Date().getHours()+ new Date().getMinutes()/60>1?"si":"no"; */
/* test = new Date(new Date(new Date().setMinutes(0)).setHours(new Date(new Date().setMinutes(0)).getHours()+1)).toLocaleString('sv-SE'); */
/* test = new Date(new Date().setHours(new Date().getHours() + 1 ) ).toLocaleString('sv-SE'); */
/* hora_test = "06:00"; */


hora_min = new Date().getHours() + new Date().getMinutes()/60>6? new Date(new Date(new Date().setMinutes(0)).setHours(new Date(new Date().setMinutes(0)).getHours()+1)).toLocaleString('sv-SE').split(" ")[1].slice(0,5) : "06:00";
hora = "06:00";

/* hora_min = new Date().getHours() + new Date().getMinutes()/60>1?new Date().toLocaleString('sv-SE').split(" ")[1].slice(0,5):"01:00"; */
/* test = new Date().toLocaleString('sv-SE').split(" ")[1].slice(0,5); FUNCIONA MEJOR FORMATO 24HRS */
/* test = new Date().toLocaleString('en-ca').split(",")[1].substring(1,6); FUNCIONA*/
/* document.getElementById("hora_test").innerHTML = new Date().toLocaleDateString('en-ca').slice(1, 5); */

qwer = (<HTMLInputElement>document.getElementById("inputFecha_reserva"));
dateq = new Date();
test5 = new FormControl(new Date()) /* new Date().toLocaleString('en-GB').split(" ")[0].slice(0,10).toString(); */




}

