import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ComprasModel } from "src/app/Models/Compras";
import {AprobacionModel} from 'src/app/Models/Aprobacion'
@Injectable({
  providedIn: 'root'
})
export class ComprasService {

  ServerAPI = 'https://localhost:44366/';
  PostCompra = 'api/Compras/CrearCompra';
  GetCompras = 'api/Compras/ObtenerComprasActuales';
  borraCompra = 'api/Compras/DeleteCompras';
  InsertSolFinanciero = 'api/aprobacionPorFinanciero/InsertAprobacion'

  constructor(private httpRequest:HttpClient) { }

  InsertarNuevaCompra(NuevaCompra: ComprasModel):Observable<ComprasModel>{

    return this.httpRequest.post<ComprasModel>(this.ServerAPI+this.PostCompra,NuevaCompra);

  }

  ComprasActuales(){

    return this.httpRequest.get<ComprasModel[]>(this.ServerAPI+this.GetCompras);

  }

  BorrarCompra(compraBorrar: ComprasModel){
    return this.httpRequest.post(this.ServerAPI+this.borraCompra, compraBorrar)
  }

  InsertAprobacion(aprobacion: AprobacionModel){
    console.log(aprobacion)
    return this.httpRequest.post(this.ServerAPI+this.InsertSolFinanciero, aprobacion)
  }

}
