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
import { AppIntranetModule } from './app-intranet/app-intranet.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegistryComponent,
    BookingComponent
    ForgotpassComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppIntranetModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
