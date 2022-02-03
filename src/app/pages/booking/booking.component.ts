import { getLocaleTimeFormat } from '@angular/common';
import { Component, OnInit, ɵsetCurrentInjector } from '@angular/core';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {

  

  constructor() { }

  ngOnInit(): void {
  }


  selectedValue = 0;

  /* isChecked = 0; */
 isChecked: boolean = false;

 /* fecha_reserva = new Date().toISOString().split("T")[0];  */ 

fecha_min = new Date().toISOString().substring(0, 10);

/* hora_min = (locale, with "HH:mm"); */

}


