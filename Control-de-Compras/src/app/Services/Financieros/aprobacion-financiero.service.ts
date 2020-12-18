import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AprobacionModel } from 'src/app/Models/Aprobacion';
import { ComprasModel } from 'src/app/Models/Compras';

@Injectable({
  providedIn: 'root'
})
export class AprobacionFinancieroService {

  ServerAPI = 'https://localhost:44366/';
  PostCompra = 'api/aprobacionPorFinanciero/CrearCompra';
  GetCompras = 'api/aprobacionPorFinanciero/GetAllAprobaciones';
  borraCompra = 'api/aprobacionPorFinanciero/DeleteAprobacion';
  InsertSolFinanciero = 'api/aprobacionPorFinanciero/InsertAprobacion'
  GetReportCompra ='api/aprobacionPorFinanciero/ReportCompra';


  constructor(private httpRequest:HttpClient) { }

  InsertarNuevaCompra(NuevaCompra: ComprasModel):Observable<ComprasModel>{

    return this.httpRequest.post<ComprasModel>(this.ServerAPI+this.PostCompra,NuevaCompra);

  }

  AprobacionesFinancierasActuales(){

    return this.httpRequest.get<ComprasModel[]>(this.ServerAPI+this.GetCompras);

  }

  BorrarSolicitud(compraBorrar: ComprasModel){
    return this.httpRequest.post(this.ServerAPI+this.borraCompra, compraBorrar)
  }

  InsertAprobacion(aprobacion: AprobacionModel){
    console.log(aprobacion)
    return this.httpRequest.post(this.ServerAPI+this.InsertSolFinanciero, aprobacion)
  }

 

}
