import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginModel } from 'src/app/Models/Login';
import { UsuariosModel } from 'src/app/Models/Usuarios';
import { LoginServiceService } from 'src/app/Services/Login/login-service.service';

@Component({
  selector: 'app-panel-administrador',
  templateUrl: './panel-administrador.component.html',
  styleUrls: ['./panel-administrador.component.css']
})
export class PanelAdministradorComponent implements OnInit {

  ListaAdministradores: UsuariosModel[];
  ListaCompradores: UsuariosModel[];
  ListaJefes: UsuariosModel[];
  ListaFinancieros: UsuariosModel[];

  FormAdministrador: FormGroup;
  FormJefes: FormGroup;
  FormFinancieros: FormGroup;
  statusAgregacionAdmin:boolean;
  statusAgregacionJefe:boolean;
  statusAgregacionfinanciero:boolean;

  constructor(private API_Usuarios: LoginServiceService, private builderForm: FormBuilder) {

    this.FormAdministrador = this.builderForm.group({

      FormNombreAdmin: ['', Validators.required],
      FormApellidosAdmin: ['', Validators.required],
      FormCorreoAdmin: ['', Validators.required],
      FormContraseñanAdmin: ['', Validators.required],
      FormTipoAdmin: ['', Validators.required],
      FormJefeAdmin: ['', Validators.required]

    })
    this.FormJefes = this.builderForm.group({

      FormNombreJefes: ['', Validators.required],
      FormApellidosJefes: ['', Validators.required],
      FormCorreoJefes: ['', Validators.required],
      FormContraseñaJefes: ['', Validators.required],
      FormTipoJefes: ['', Validators.required],
      FormJefeJefes: ['', Validators.required]

    })

    this.FormFinancieros = this.builderForm.group({

      FormNombreFinancieros: ['', Validators.required],
      FormApellidosFinancieros: ['', Validators.required],
      FormCorreoFinancieros: ['', Validators.required],
      FormContraseñanFinancieros: ['', Validators.required],
      FormTipoFinancieros: ['', Validators.required],
      FormJefeFinancieros: ['', Validators.required]

    })


  }

  CrearAdministrador(){

    const Administrador:UsuariosModel ={
      _id:"",
      nombre:this.FormAdministrador.get('FormNombreAdmin').value,
      apellidos:this.FormAdministrador.get('FormApellidosAdmin').value,
      correoElectronico:this.FormAdministrador.get('FormCorreoAdmin').value,
      contrasena:this.FormAdministrador.get('FormContraseñanAdmin').value,
      tipoUsuario:this.FormAdministrador.get('FormTipoAdmin').value,
      nombreJefe:this.FormAdministrador.get('FormJefeAdmin').value,

    }

    this.API_Usuarios.CreateAdministrator(Administrador).subscribe(result => {
      this.ObtenerUsuarioAdmin();
      alert("El administrador ha sido creado")
    })

    this.statusAgregacionAdmin = true;
    
  }
  CrearJefe(){

    const Jefe:UsuariosModel ={
      _id:"",
      nombre:this.FormJefes.get('FormNombreJefes').value,
      apellidos:this.FormJefes.get('FormApellidosJefes').value,
      correoElectronico:this.FormJefes.get('FormCorreoJefes').value,
      contrasena:this.FormJefes.get('FormContraseñaJefes').value,
      tipoUsuario:this.FormJefes.get('FormTipoJefes').value,
      nombreJefe:this.FormJefes.get('FormJefeJefes').value,

    }

    this.API_Usuarios.CreateJefe(Jefe).subscribe(result => {

      alert("El Jefe ha sido creado");
     
    })
    this.statusAgregacionJefe = true;
   
  }
  CrearFinanciero(){

    const Financiero:UsuariosModel ={
      _id:"",
      nombre:this.FormFinancieros.get('FormNombreFinancieros').value,
      apellidos:this.FormFinancieros.get('FormApellidosFinancieros').value,
      correoElectronico:this.FormFinancieros.get('FormCorreoFinancieros').value,
      contrasena:this.FormFinancieros.get('FormContraseñanFinancieros').value,
      tipoUsuario:this.FormFinancieros.get('FormTipoFinancieros').value,
      nombreJefe:this.FormFinancieros.get('FormJefeFinancieros').value,

    }

    this.API_Usuarios.CreateFinanciero(Financiero).subscribe(result => {

      alert("El financiero ha sido creado")
    })
    this.statusAgregacionfinanciero = true;
  }

  ObtenerUsuarioAdmin(){

    this.API_Usuarios.LoadAdministrator().subscribe(result => {

      this.ListaAdministradores = result;

    })
  }
  ObtenerUsuarioJefes(){

    this.API_Usuarios.LoadJefes().subscribe(result => {

      this.ListaJefes = result;

    })
  }

  ObtenerUsuarioFinancieros(){

    this.API_Usuarios.LoadFinancieros().subscribe(result => {

      this.ListaFinancieros = result;

    })
  }

  ObtenerUsuarioCompradores(){

    this.API_Usuarios.LoadCompradores().subscribe(result => {

      this.ListaCompradores = result;

    })
  }


  ngOnInit() {

    this.ObtenerUsuarioAdmin();
    this.ObtenerUsuarioCompradores();
    this.ObtenerUsuarioFinancieros();
    this.ObtenerUsuarioJefes();
  }

}