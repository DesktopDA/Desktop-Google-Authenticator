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
    NroDepartamento : ['']
  });

  constructor(
    private fb:FormBuilder
  ) { }

  ngOnInit(): void {
  }

}
