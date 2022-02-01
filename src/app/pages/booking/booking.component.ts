import { Component, OnInit } from '@angular/core';

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

}


