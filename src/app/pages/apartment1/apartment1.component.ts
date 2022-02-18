import { Component, OnInit } from '@angular/core';
import { ApartmentService } from 'src/app/services/apartment.service';

@Component({
  selector: 'app-apartment1',
  templateUrl: './apartment1.component.html',
  styleUrls: ['./apartment1.component.css']
})
export class Apartment1Component implements OnInit {

  apartments: any = [];

  constructor(
    private readonly as:ApartmentService
  ) { }

  __getApartmentsLocal(){
    this.as.__getApartmentsLocal().subscribe((rest:any) => {
      this.apartments = rest.data;
      console.log(this.apartments);
    })
  }

  ngOnInit(): void {
    this.__getApartmentsLocal();
  }

}
