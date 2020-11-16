import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login';
import { UsuariosModel } from "src/app/Models/Usuarios";
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  ServerAPI = 'https://localhost:44366/';
  GetAuthentication = 'api/Login/CrearAutenticacion';
  GetAuthenticationJefe = 'api/Login/AutenticacionJefe';
  GetAuthenticationComprador = 'api/Login/AutenticacionComprador';
  GetAuthenticationFinanciero = 'api/Login/AutenticacionFinanciero';

  InsertNewAdministrator = 'api/creacionLogin/InsertarUsuario';

  GetListAdmins = 'api/creacionLogin/ListaAdministradores';
  GetListCompradores = 'api/creacionLogin/ListaCompradores';
  GetListJefes = 'api/creacionLogin/ListaJefes';
  GetListFinanciero = 'api/creacionLogin/ListaFinancieros';

  statusLogin:any;
  statusJefe:any;
  statusComprador:any;
  statusFinanciero:any;
 
  constructor(private httpRequest:HttpClient) { }

  AuthenticateUser(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusLogin = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials)
    
  }
  AuthenticateJefe(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusJefe = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationJefe,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationJefe,SendCredentials);

    
  }
  AuthenticateComprador(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusComprador = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationComprador,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationComprador,SendCredentials);

  }
  AuthenticateFinanciero(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusFinanciero = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationFinanciero,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthenticationFinanciero,SendCredentials);

  }
  CreateAdministrator(NewAdmin:UsuariosModel):Observable<UsuariosModel>{

    return this.httpRequest.post<UsuariosModel>(this.ServerAPI+this.InsertNewAdministrator,NewAdmin);

  }
  CreateJefe(NewAdmin:UsuariosModel):Observable<UsuariosModel>{

    return this.httpRequest.post<UsuariosModel>(this.ServerAPI+this.InsertNewAdministrator,NewAdmin);

  }
  CreateFinanciero(NewAdmin:UsuariosModel):Observable<UsuariosModel>{

    return this.httpRequest.post<UsuariosModel>(this.ServerAPI+this.InsertNewAdministrator,NewAdmin);

  }
  CreateComprador(NewAdmin:UsuariosModel):Observable<UsuariosModel>{

    return this.httpRequest.post<UsuariosModel>(this.ServerAPI+this.InsertNewAdministrator,NewAdmin);

  }
 
  LoadAdministrator(){

    return this.httpRequest.get<UsuariosModel[]>(this.ServerAPI+this.GetListAdmins)
  }
  LoadCompradores(){

    return this.httpRequest.get<UsuariosModel[]>(this.ServerAPI+this.GetListCompradores)
  }
  LoadJefes(){

    return this.httpRequest.get<UsuariosModel[]>(this.ServerAPI+this.GetListJefes)
  }
  LoadFinancieros(){

    return this.httpRequest.get<UsuariosModel[]>(this.ServerAPI+this.GetListFinanciero)
  }







  IsLogguedInAdminisitrador(){

    return this.statusLogin;
  }
  
  IsLogguedInComprador(){

    return this.statusComprador;
  }
  
  IsLogguedInJefe(){

    return this.statusJefe;
  }
  
  IsLogguedInFinanciero(){

    return this.statusFinanciero;
  }

  handleError(error:HttpErrorResponse){

    return console.log(throwError(error));
    
  }
}
