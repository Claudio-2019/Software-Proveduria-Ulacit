import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  ServerAPI = 'https://localhost:44366/';
  GetAuthentication = 'api/Login/CrearAutenticacion';
  GetAuthenticationJefe = 'api/Login/AutenticacionJefe';
  GetAuthenticationComprador = 'api/Login/AutenticacionComprador';
  GetAuthenticationFinanciero = 'api/Login/AutenticacionFinanciero';
  statusLogin:any;
  statusJefe:any;
  statusComprador:any;
  statusFinanciero:any;
 
  constructor(private httpRequest:HttpClient) { }

  AuthenticateUser(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusLogin = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials);

    
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

  IsLogguedIn(){

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
}
