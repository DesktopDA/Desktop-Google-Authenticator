import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { HttpClientModule } from "@angular/common/http";
import { LoginComponent } from './pages/login/login.component';
import { BookingComponent } from './pages/booking/booking.component';
import { RegisterComponent } from './pages/register/register.component';
import { ForgotpassComponent } from './pages/forgotpass/forgotpass.component';
import { Apartment1Component } from './pages/apartment1/apartment1.component';
import { Apartment2Component } from './pages/apartment2/apartment2.component';
import { Comunicacion1Component } from './pages/comunicacion1/comunicacion1.component';
import { Comunicacion2Component } from './pages/comunicacion2/comunicacion2.component';
import { RegistroGastosComponent } from './pages/registro-gastos/registro-gastos.component';
import { EmitirBoletaComponent } from './pages/emitir-boleta/emitir-boleta.component';
import { MaintenanceComponent } from './pages/maintenance/maintenance.component';
import { BookingConsultaComponent } from './pages/booking-consulta/booking-consulta.component';
import { HistorialPagosComponent } from './pages/historial-pagos/historial-pagos.component';
import { HistorialVisitasComponent } from './pages/historial-visitas/historial-visitas.component';
import { UsuarioComponent } from './pages/usuario/usuario.component';
import { UsuarioConsultaComponent } from './pages/usuario-consulta/usuario-consulta.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    BookingComponent,
    UsuarioComponent,
    UsuarioConsultaComponent,
    ForgotpassComponent,
    RegisterComponent,
    Apartment1Component,
    Apartment2Component,
    Comunicacion1Component,
    Comunicacion2Component,
    RegistroGastosComponent,
    EmitirBoletaComponent,
    MaintenanceComponent,
    BookingConsultaComponent,
    HistorialPagosComponent,
    HistorialVisitasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
