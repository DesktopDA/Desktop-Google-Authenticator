import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { HttpClientModule } from "@angular/common/http";
import { LoginComponent } from './pages/login/login.component';
import { RegistryComponent } from './pages/registry/registry.component';
import { BookingComponent } from './pages/booking/booking.component';
import { RegisterComponent } from './pages/register/register.component';
import { ForgotpassComponent } from './pages/forgotpass/forgotpass.component';
import { Apartment1Component } from './pages/apartment1/apartment1.component';
import { Apartment2Component } from './pages/apartment2/apartment2.component';
import { Comunicacion1Component } from './pages/comunicacion1/comunicacion1.component';
import { Comunicacion2Component } from './pages/comunicacion2/comunicacion2.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegistryComponent,
    BookingComponent,
    ForgotpassComponent,
    RegisterComponent,
    Apartment1Component,
    Apartment2Component,
    Comunicacion1Component,
    Comunicacion2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
