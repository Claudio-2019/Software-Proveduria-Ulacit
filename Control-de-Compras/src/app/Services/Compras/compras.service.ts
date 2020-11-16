import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ComprasModel } from "src/app/Models/Compras";
@Injectable({
  providedIn: 'root'
})
export class ComprasService {

  ServerAPI = 'https://localhost:44366/';
  PostCompra = 'api/Compras/CrearCompra';
  GetCompras = 'api/Compras/ObtenerComprasActuales';

  constructor(private httpRequest:HttpClient) { }

  InsertarNuevaCompra(NuevaCompra:ComprasModel):Observable<ComprasModel>{

    return this.httpRequest.post<ComprasModel>(this.ServerAPI+this.PostCompra,NuevaCompra);

  }

  ComprasActuales(){

    return this.httpRequest.get<ComprasModel[]>(this.ServerAPI+this.GetCompras);

  }
}
