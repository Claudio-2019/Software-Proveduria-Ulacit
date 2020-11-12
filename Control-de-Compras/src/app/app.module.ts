import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardJefeComponent } from './Components/dashboard-jefe/dashboard-jefe.component';
import { DashboardFinancieroComponent } from './Components/dashboard-financiero/dashboard-financiero.component';
import { DasboardCompradorComponent } from './Components/dasboard-comprador/dasboard-comprador.component';
import { SolicitudesCompradorComponent } from './Components/solicitudes-comprador/solicitudes-comprador.component';
import { SolicitudesJefeComponent } from './Components/solicitudes-jefe/solicitudes-jefe.component';
import { DashboardPrincipalComponent } from './Components/dashboard-principal/dashboard-principal.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardJefeComponent,
    DashboardFinancieroComponent,
    DasboardCompradorComponent,
    SolicitudesCompradorComponent,
    SolicitudesJefeComponent,
    DashboardPrincipalComponent,
    
  
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
