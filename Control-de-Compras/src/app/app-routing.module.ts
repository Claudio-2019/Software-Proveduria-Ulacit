import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardCompradorComponent } from './Components/dashboard-comprador/dashboard-comprador.component';
import { AuthGuardGuard } from "src/app/Guard/auth-guard.guard";

const routes: Routes = [

  {path: 'DashboardComprador',component:DashboardCompradorComponent,canActivate:[AuthGuardGuard]}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
