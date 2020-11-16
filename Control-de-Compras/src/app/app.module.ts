import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from '@angular/core';
import { ReactiveFormsModule,FormsModule } from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardJefeComponent } from './Components/dashboard-jefe/dashboard-jefe.component';
import { DashboardFinancieroComponent } from './Components/dashboard-financiero/dashboard-financiero.component';
import { DasboardCompradorComponent } from './Components/dasboard-comprador/dasboard-comprador.component';
import { SolicitudesCompradorComponent } from './Components/solicitudes-comprador/solicitudes-comprador.component';
import { SolicitudesJefeComponent } from './Components/solicitudes-jefe/solicitudes-jefe.component';
import { CrearSolicitudComponent } from './Components/crear-solicitud/crear-solicitud.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardJefeComponent,
    DashboardFinancieroComponent,
    DasboardCompradorComponent,
    SolicitudesCompradorComponent,
    SolicitudesJefeComponent,
    CrearSolicitudComponent,
    
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
