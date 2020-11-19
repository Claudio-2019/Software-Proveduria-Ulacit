import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from "src/app/Models/Login";
import { UsuariosModel } from './Models/Usuarios';
import { LoginServiceService } from './Services/Login/login-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Control-de-Compras';

  ngOnInit(): void {
    //this.AuthenticacionOn();
  }
  
  FormularioLogin: FormGroup;
  FormComprador:FormGroup;
  statusAgregacionfinanciero:boolean;

  auth: string = 'Autenticar';
  DeleteLogin: boolean = true;
  TestBolean: string;
  ShowAlertAuth: boolean = false;
  HideLogin: boolean = true;

  constructor(private formbuilderLogin: FormBuilder, private ruteo: Router, private ServicesLogin: LoginServiceService) {

    this.FormularioLogin = this.formbuilderLogin.group({
      GetUserName: ['', Validators.required],
      GetPassword: ['', Validators.required]
    });

    this.FormComprador = this.formbuilderLogin.group({

      FormNombreComprador: ['', Validators.required],
      FormApellidosComprador: ['', Validators.required],
      FormCorreoComprador: ['', Validators.required],
      FormContraseñaComprador: ['', Validators.required],
      FormTipoComprador: ['', Validators.required],
      FormCompradorComprador: ['', Validators.required]

    })
  }

  async CheckAuth() {


    if (this.auth === 'Autenticar') {

      const NewLogin: LoginModel = {
        correoElectronico: this.FormularioLogin.get('GetUserName').value,
        contraseña: this.FormularioLogin.get('GetPassword').value,
      };


      this.ServicesLogin.AuthenticateUser(NewLogin).subscribe(result => {

        this.TestBolean = result.toString()
 
        alert(result);

        if (this.TestBolean === "Administrador") {

          localStorage.setItem('status', JSON.stringify(result));

          alert("Inicio correcto como: "+ result);

          this.ruteo.navigate(['/Panel-Administrador']);

          this.ShowAlertAuth = false;

          this.HideLogin = false;

          return true;

        }else if (this.TestBolean === "Compradores") {

          localStorage.setItem('status', JSON.stringify(result));

          alert("Inicio correcto como: "+ result);

          this.ruteo.navigate(['/SolicitudCompras']);

          this.ShowAlertAuth = false;

          this.HideLogin = false;
         
          return true;

        } else if (this.TestBolean === "Jefe") {

          
          localStorage.setItem('status', JSON.stringify(result));

          alert("Inicio correcto como: "+result);

          this.ruteo.navigateByUrl('/SolicitudJefe')
          
          this.ShowAlertAuth = false;
          this.HideLogin = false;
          return true;

        }else if (this.TestBolean === "financiero") {

          this.ShowAlertAuth = true;

          this.HideLogin = true;

         

          return false;
        }

      })


    }
    this.ruteo.navigate(['/']);

  }

  CrearComprador(){

    const Financiero:UsuariosModel ={
      _id:"",
      nombre:this.FormComprador.get('FormNombreComprador').value,
      apellidos:this.FormComprador.get('FormApellidosComprador').value,
      correoElectronico:this.FormComprador.get('FormCorreoComprador').value,
      contrasena:this.FormComprador.get('FormContraseñaComprador').value,
      tipoUsuario:this.FormComprador.get('FormTipoComprador').value,
      nombreJefe:this.FormComprador.get('FormCompradorComprador').value,

    }

    this.ServicesLogin.CreateComprador(Financiero).subscribe(result => {

      alert("El financiero ha sido creado")
    })
    this.statusAgregacionfinanciero = true;
  }


}
