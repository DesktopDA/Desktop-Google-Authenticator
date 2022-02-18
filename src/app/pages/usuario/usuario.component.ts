import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {
  userForm = this.fb.group ({
    nombres:[''],
    apellidos:[''],
    tipo_doc:[''],
    num_doc:[''],
    num_tel:[''],
    email:[''],
    tipo_user:[''],
    user_id:['']
 })


  constructor(
    private fb: FormBuilder
  ) { }

  ngOnInit(): void {
  }

}
