import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ComprasModel } from 'src/app/Models/Compras';
import { ComprasService } from "src/app/Services/Compras/compras.service";
@Component({
  selector: 'app-crear-solicitud',
  templateUrl: './crear-solicitud.component.html',
  styleUrls: ['./crear-solicitud.component.css']
})
export class CrearSolicitudComponent implements OnInit {

  FormularioCompras:FormGroup;

  constructor(private builderForm:FormBuilder,private ComprasService_API:ComprasService) {

    this.FormularioCompras = this.builderForm.group({

      FormTitulo:['',Validators.required],
      FormDescripcion:['',Validators.required],
      FormCantidad:['',Validators.required],
      FormMonto:['',Validators.required],
      FormCorreo:['',Validators.required],
      FormTelefono:['',Validators.required],
      FormArticulo:['',Validators.required],
      FormTipoArticulo:['',Validators.required],
      


    });


   }

   CrearCompra(){

    const OrdenCompra:ComprasModel={
      titulo: this.FormularioCompras.get('FormTitulo').value,
      descripcion: this.FormularioCompras.get('FormDescripcion').value,
      cantidad: Number.parseInt(this.FormularioCompras.get('FormCantidad').value),
      monto: Number.parseInt(this.FormularioCompras.get('FormMonto').value),
      correoElectronico: this.FormularioCompras.get('FormCorreo').value,
      telefono:Number.parseInt( this.FormularioCompras.get('FormTelefono').value),
      nombreArticulo: this.FormularioCompras.get('FormArticulo').value,
      tipoArticulo: this.FormularioCompras.get('FormTipoArticulo').value,
     
    }

    this.ComprasService_API.InsertarNuevaCompra(OrdenCompra).subscribe(result => {

      alert("Orden de compra creada" + result.nombreArticulo);
    })

   }


  ngOnInit() {
  }

}
