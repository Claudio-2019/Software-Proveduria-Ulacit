import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DasboardCompradorComponent } from "./Components/dasboard-comprador/dasboard-comprador.component";
import { AuthGuardGuard } from "src/app/Guard/auth-guard.guard";
import { CompradorGuardGuard  } from "src/app/Guard/GuardComprador/comprador-guard.guard";
import { JefeGuardGuard } from "src/app/Guard/GuardJefe/jefe-guard.guard";
import { FinancieroGuardGuard } from "src/app/Guard/GuardFinanciero/financiero-guard.guard";
import { DashboardFinancieroComponent } from './Components/dashboard-financiero/dashboard-financiero.component';
import { DashboardJefeComponent } from './Components/dashboard-jefe/dashboard-jefe.component';
import { SolicitudesCompradorComponent } from './Components/solicitudes-comprador/solicitudes-comprador.component';
import { SolicitudesJefeComponent } from './Components/solicitudes-jefe/solicitudes-jefe.component';
import { DashboardPrincipalComponent } from './Components/dashboard-principal/dashboard-principal.component';

const routes: Routes = [

  {path: 'DashboardComprador',component:DasboardCompradorComponent,canActivate:[AuthGuardGuard]},
  {path: 'DashboardFinanciero',component:DashboardFinancieroComponent,canActivate:[FinancieroGuardGuard]},
  {path: 'DashboardJefe',component:DashboardJefeComponent,canActivate:[AuthGuardGuard]},
  {path: 'SolicitudCompras',component:SolicitudesCompradorComponent,canActivate:[CompradorGuardGuard]},
  {path: 'Solicitud-Jefe',component:SolicitudesJefeComponent,canActivate:[JefeGuardGuard]},
  {path: 'Dashboard-Principal',component:DashboardPrincipalComponent,canActivate:[AuthGuardGuard]},
  { path: '**',   redirectTo: '/' }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
