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
import { SolicitudesFinancieroComponent } from './Components/solicitudes-financiero/solicitudes-financiero.component';
import { CrearSolicitudComponent } from './Components/crear-solicitud/crear-solicitud.component';
import { PanelAdministradorComponent } from './Components/panel-administrador/panel-administrador.component';

const routes: Routes = [

  {path: 'Panel-Administrador',component:PanelAdministradorComponent,canActivate:[AuthGuardGuard]},
  {path: 'DashboardComprador',component:DasboardCompradorComponent,canActivate:[CompradorGuardGuard]},
  {path: 'DashboardJefe',component:DashboardJefeComponent,canActivate:[JefeGuardGuard]},
  {path: 'SolicitudCompras',component:SolicitudesCompradorComponent,canActivate:[AuthGuardGuard]},
  {path: 'Crear-Compra',component:CrearSolicitudComponent,canActivate:[AuthGuardGuard]},
  {path: 'DashboardFinanciero',component:DashboardFinancieroComponent,canActivate:[FinancieroGuardGuard]},
  {path: 'SolicitudJefe', component:SolicitudesJefeComponent},
  {path: 'SolicitudFinanciero', component:SolicitudesFinancieroComponent },
 
  { path: '**',   redirectTo: '/' }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
