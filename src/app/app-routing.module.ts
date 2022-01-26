import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { IndexComponent } from "./intranet/index/index.component";
import { ForgotpassComponent } from "./pages/forgotpass/forgotpass.component";
import { HomeComponent } from "./pages/home/home.component";
import { LoginComponent } from "./pages/login/login.component";
import { RegisterComponent } from "./pages/register/register.component";

const routes: Routes = [
{ path: 'home', component: HomeComponent },
{ path: 'login', component: LoginComponent },
{ path: 'register', component: RegisterComponent},
{ path: 'forgotpass', component: ForgotpassComponent},
{ path: 'intranet/index', component: IndexComponent},
{ path: '', redirectTo:'home', pathMatch:'full' }
]

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}