import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { BookingComponent } from "./pages/booking/booking.component";
import { HomeComponent } from "./pages/home/home.component";
import { LoginComponent } from "./pages/login/login.component";
import { RegistryComponent } from "./pages/registry/registry.component";
import { ForgotpassComponent } from "./pages/forgotpass/forgotpass.component";
import { RegisterComponent } from "./pages/register/register.component";
import { IndexComponent } from "./pages/index/index.component";
import { Apartment1Component } from "./pages/apartment1/apartment1.component";
import { Apartment2Component } from "./pages/apartment2/apartment2.component";
import { Comunicacion1Component } from "./pages/comunicacion1/comunicacion1.component";
import { Comunicacion2Component } from "./pages/comunicacion2/comunicacion2.component";
import { RegistroGastosComponent } from "./pages/registro-gastos/registro-gastos.component";
import { EmitirBoletaComponent } from "./pages/emitir-boleta/emitir-boleta.component";

const routes: Routes = [
{ path: 'home', component: HomeComponent },
{ path: 'login', component: LoginComponent },
{ path: 'registry', component: RegistryComponent},
{ path: 'booking', component: BookingComponent},
{ path: 'register', component: RegisterComponent},
{ path: 'forgotpass', component: ForgotpassComponent},
{ path: 'intranet/index', component: IndexComponent},
{ path: 'apartment1', component: Apartment1Component},
{ path: 'apartment2', component: Apartment2Component},
{ path: 'comunicacion1', component: Comunicacion1Component},
{ path: 'comunicacion2', component: Comunicacion2Component},
{ path: 'registro-gastos', component: RegistroGastosComponent},
{ path: 'emitir-boleta', component: EmitirBoletaComponent},
{ path: '', redirectTo:'home', pathMatch:'full' }
]

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}