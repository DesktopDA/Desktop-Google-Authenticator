import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppIntranetComponent } from './app-intranet.component';
import { IndexComponent } from '../intranet/index/index.component';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../app-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    AppIntranetComponent,
    IndexComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppIntranetComponent]
})
export class AppIntranetModule { }
