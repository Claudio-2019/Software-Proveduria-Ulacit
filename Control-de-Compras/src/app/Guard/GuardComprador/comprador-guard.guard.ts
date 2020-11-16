import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginServiceService } from 'src/app/Services/Login/login-service.service';

@Injectable({
  providedIn: 'root'
})
export class CompradorGuardGuard implements CanActivate {
  constructor(private autenticacion:LoginServiceService ,private rutoe:Router){

  }
  result:string;

  canActivate(): boolean  {
   
   if(this.autenticacion.IsLogguedInComprador() === "Compradores"){

     return true;
    
   }else{
     return false;
   }

  }
}
