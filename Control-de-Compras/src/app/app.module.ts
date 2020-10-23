import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardJefeComponent } from './Components/dashboard-jefe/dashboard-jefe.component';
import { DashboardCompradorComponent } from './Components/dashboard-comprador/dashboard-comprador.component';
import { DashboardFinancieroComponent } from './Components/dashboard-financiero/dashboard-financiero.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardJefeComponent,
    DashboardCompradorComponent,
    DashboardFinancieroComponent,
    
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
