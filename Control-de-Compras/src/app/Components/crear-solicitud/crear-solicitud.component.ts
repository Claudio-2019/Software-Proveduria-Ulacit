import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { window } from 'rxjs/operators';
import { ComprasModel } from 'src/app/Models/Compras';
import { ComprasService } from "src/app/Services/Compras/compras.service";
import { saveAs } from "file-saver";
import { FileSaver  } from "file-saver";
import Axios from 'axios';
@Component({
  selector: 'app-crear-solicitud',
  templateUrl: './crear-solicitud.component.html',
  styleUrls: ['./crear-solicitud.component.css']
})
export class CrearSolicitudComponent implements OnInit {
  StatusEmail: boolean = false;
  FormularioCompras: FormGroup;

  constructor(private builderForm: FormBuilder, private ComprasService_API: ComprasService) {

    this.FormularioCompras = this.builderForm.group({

      FormTitulo: ['', Validators.required],
      FormDescripcion: ['', Validators.required],
      FormCantidad: ['', Validators.required],
      FormMonto: ['', Validators.required],
      FormCorreo: ['', Validators.required],
      FormTelefono: ['', Validators.required],
      FormArticulo: ['', Validators.required],
      FormTipoArticulo: ['', Validators.required],

    });


  }

  CrearCompra() {

    const OrdenCompra: ComprasModel = {
      _id: "",
      titulo: this.FormularioCompras.get('FormTitulo').value,
      descripcion: this.FormularioCompras.get('FormDescripcion').value,
      cantidad: Number.parseInt(this.FormularioCompras.get('FormCantidad').value),
      monto: Number.parseInt(this.FormularioCompras.get('FormMonto').value),
      total: 0,
      correoElectronico: this.FormularioCompras.get('FormCorreo').value,
      telefono: Number.parseInt(this.FormularioCompras.get('FormTelefono').value),
      nombreArticulo: this.FormularioCompras.get('FormArticulo').value,
      tipoArticulo: this.FormularioCompras.get('FormTipoArticulo').value,

    }

    this.ComprasService_API.InsertarNuevaCompra(OrdenCompra).subscribe(result => {

      alert("Orden de compra creada" + result.nombreArticulo);
    })
   
    this.StatusEmail = true;
  }

  

  ngOnInit() {
  }

}
