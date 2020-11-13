import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from 'src/app/Models/Login';
import { LoginServiceService } from 'src/app/Services/Login/login-service.service';

@Component({
  selector: 'app-dashboard-principal',
  templateUrl: './dashboard-principal.component.html',
  styleUrls: ['./dashboard-principal.component.css']
})
export class DashboardPrincipalComponent implements OnInit {
  ngOnInit() { }

  FormularioComprador: FormGroup;
  FormularioJefe: FormGroup;
  FormularioFinanciero: FormGroup;



  auth: string = 'Autenticar';
  DeleteLogin: boolean = true;
  TestBolean: any;
  ShowAlertAuth: boolean = false;
  HideLogin: boolean = true;

  constructor(private formbuilderLogin: FormBuilder, private ruteo: Router, private ServicesLogin: LoginServiceService) {

    this.FormularioComprador = this.formbuilderLogin.group({
      GetUserNameComprador: ['', Validators.required],
      GetPasswordComprador: ['', Validators.required]
    });
    this.FormularioJefe = this.formbuilderLogin.group({
      GetUserNameJefe: ['', Validators.required],
      GetPasswordJefe: ['', Validators.required]
    });
    this.FormularioFinanciero = this.formbuilderLogin.group({
      GetUserNameFinanciero: ['', Validators.required],
      GetPasswordFinanciero: ['', Validators.required]
    });
  }

  async CheckAuthComprador() {


    if (this.auth === 'Autenticar') {

      const Comprador: LoginModel = {
        Username: this.FormularioComprador.get('GetUserNameComprador').value,
        Password: this.FormularioComprador.get('GetPasswordComprador').value,
      };

      this.ServicesLogin.AuthenticateComprador(Comprador).subscribe(result => {

        this.TestBolean = result
        console.log(this.TestBolean)

        if (this.TestBolean === true) {
          localStorage.setItem('status', JSON.stringify(this.TestBolean));
          alert("Sera redirigido a la pagina de solicitud de compras!");
          this.ruteo.navigate(['/SolicitudCompras']);
          this.ShowAlertAuth = false;
          this.HideLogin = false;
          return true;
        } else if (this.TestBolean === false) {
          this.ShowAlertAuth = true;
          this.HideLogin = true;
          alert("Usuario o Contraseña incorrecto")
          return false;
        }

      });

    }
   
  }
  async CheckAuthJefe() {


    if (this.auth === 'Autenticar') {

      const NewLogin: LoginModel = {
        Username: this.FormularioJefe.get('GetUserNameJefe').value,
        Password: this.FormularioJefe.get('GetPasswordJefe').value,
      };

      this.ServicesLogin.AuthenticateJefe(NewLogin).subscribe(result => {

        this.TestBolean = result
        console.log(this.TestBolean)

        if (this.TestBolean === true) {
          localStorage.setItem('status', JSON.stringify(this.TestBolean));
          alert("Inicio Correcto Jefe");
          this.ruteo.navigate(['/Solicitud-Jefe']);
          this.ShowAlertAuth = false;
          this.HideLogin = false;
          return true;
        } else if (this.TestBolean === false) {
          this.ShowAlertAuth = true;
          this.HideLogin = true;
          alert("Usuario o Contraseña incorrecto")
          return false;
        }

      });

    }

  }
  async CheckAuthFinanciero() {


    if (this.auth === 'Autenticar') {

      const NewLogin: LoginModel = {
        Username: this.FormularioFinanciero.get('GetUserNameFinanciero').value,
        Password: this.FormularioFinanciero.get('GetPasswordFinanciero').value,
      };

      this.ServicesLogin.AuthenticateFinanciero(NewLogin).subscribe(result => {

        this.TestBolean = result
        console.log(this.TestBolean)

        if (this.TestBolean === true) {
          localStorage.setItem('status', JSON.stringify(this.TestBolean));
          alert("Inicio Correcto Financiero");
          this.ruteo.navigate(['/DashboardFinanciero']);
          this.ShowAlertAuth = false;
          this.HideLogin = false;
          return true;
        } else if (this.TestBolean === false) {
          this.ShowAlertAuth = true;
          this.HideLogin = true;
          alert("Usuario o Contraseña incorrecto")
          return false;
        }

      });


    }
  

  }
}
