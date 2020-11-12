import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  ServerAPI = 'https://localhost:5001/';
  GetAuthentication = 'api/Login/CrearAutenticacion';
  statusLogin:any;
 
  constructor(private httpRequest:HttpClient) { }

  AuthenticateUser(SendCredentials:LoginModel):Observable<LoginModel>{

    this.statusLogin = this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials);

    return this.httpRequest.post<LoginModel>(this.ServerAPI+this.GetAuthentication,SendCredentials);

    
  }

  IsLogguedIn(){

    return this.statusLogin;
  }
}
