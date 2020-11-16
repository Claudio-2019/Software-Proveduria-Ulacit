import { Component, OnInit } from '@angular/core';
import { ComprasModel } from 'src/app/Models/Compras';
import { ComprasService } from 'src/app/Services/Compras/compras.service';

@Component({
  selector: 'app-dashboard-jefe',
  templateUrl: './dashboard-jefe.component.html',
  styleUrls: ['./dashboard-jefe.component.css']
})
export class DashboardJefeComponent implements OnInit {

  listaSolicitudes:ComprasModel[];

  constructor(private ComprasAPI:ComprasService) { }

  CargarSolicitudes(){

    this.ComprasAPI.ComprasActuales().subscribe(result => {

      this.listaSolicitudes = result;

    })

  }

  ngOnInit() {

    this.CargarSolicitudes();
  }

}
