import { Component, OnInit } from '@angular/core';
import { ComprasModel } from 'src/app/Models/Compras';
import { ComprasService } from 'src/app/Services/Compras/compras.service';

@Component({
  selector: 'app-solicitudes-comprador',
  templateUrl: './solicitudes-comprador.component.html',
  styleUrls: ['./solicitudes-comprador.component.css']
})
export class SolicitudesCompradorComponent implements OnInit {

  listaSolicitudes: ComprasModel[];


  constructor(private ComprasService_API:ComprasService) { }

  CargarSolicitudes(){

    this.ComprasService_API.ComprasActuales().subscribe(result => {

      this.listaSolicitudes = result;

    })

  }

  ngOnInit() {

    this.CargarSolicitudes();
  }

}
