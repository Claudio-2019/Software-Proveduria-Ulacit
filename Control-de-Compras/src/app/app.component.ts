import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from "src/app/Models/Login";
import { LoginServiceService } from './Services/Login/login-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Control-de-Compras';

  ngOnInit(): void {
    this.AuthenticacionOn();
  }
  FormularioLogin: FormGroup;


  auth: string = 'Autenticar';
  DeleteLogin: boolean = true;
  TestBolean: any;
  ShowAlertAuth: boolean = false;
  HideLogin: boolean = true;

  constructor(private formbuilderLogin: FormBuilder, private ruteo: Router, private ServicesLogin: LoginServiceService) {

    this.FormularioLogin = this.formbuilderLogin.group({
      GetUserName: ['', Validators.required],
      GetPassword: ['', Validators.required]
    });
  }

  async CheckAuth() {


    if (this.auth === 'Autenticar') {

      const NewLogin: LoginModel = {
        Username: this.FormularioLogin.get('GetUserName').value,
        Password: this.FormularioLogin.get('GetPassword').value,
      };

    
      this.ServicesLogin.AuthenticateUser(NewLogin).subscribe(result => {

        this.TestBolean = result
        console.log(this.TestBolean)

        if (this.TestBolean === true) {
          localStorage.setItem('status', JSON.stringify(this.TestBolean));
          alert("Inicio correcto!");
          this.ruteo.navigate(['/Dashboard-Principal']);
          this.ShowAlertAuth = false;
         this.HideLogin= false;
          return true;
        } else if (this.TestBolean === false) {
          this.ShowAlertAuth = true;
          this.HideLogin = true;
          alert("Usuario o Contraseña incorrecto")
          return false;
        }

      });


    }
    this.ruteo.navigate(['/']);

  }

  AuthenticacionOn(): boolean {

    if (this.TestBolean === true) {
      return true;
    } else {
      return false;
    }
  }


}
