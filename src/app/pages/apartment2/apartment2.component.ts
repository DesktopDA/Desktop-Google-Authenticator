import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-apartment2',
  templateUrl: './apartment2.component.html',
  styleUrls: ['./apartment2.component.css']
})
export class Apartment2Component implements OnInit {

  apartment2Form = this.fb.group({
    Condominio : [''] ,
    AreaCondominio : [''],
    DNIPropietario : [''],
    DNIHabitante : [''],
    NroDepartamento : [''],
    Area : [''],
    Piso : [''],
    TipoDepartamento : [''],
    CantHabitaciones : [''],
    CantBanios : ['']
  });

  constructor(
    private fb:FormBuilder
  ) { }

  __onSubmit(){
    alert("Mensaje de Prueba")
  }

  ngOnInit(): void {
  }

}
