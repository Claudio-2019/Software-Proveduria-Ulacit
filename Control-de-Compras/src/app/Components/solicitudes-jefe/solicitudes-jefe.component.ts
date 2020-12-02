import { Component, OnInit, Input, ɵɵqueryRefresh} from '@angular/core';
import {ComprasModel} from 'src/app/Models/Compras'
import {ComprasService} from 'src/app/Services/Compras/compras.service'
import {UsuariosModel} from 'src/app/Models/Usuarios'
import {AprobacionModel} from 'src/app/Models/Aprobacion'
import {LoginServiceService} from 'src/app/Services/Login/login-service.service'

@Component({
  selector: 'app-solicitudes-jefe',
  templateUrl: './solicitudes-jefe.component.html',
  styleUrls: ['./solicitudes-jefe.component.css']
})
export class SolicitudesJefeComponent implements OnInit {
  
  solicitudes: ComprasModel[]
  usuarios: UsuariosModel[]

  constructor( private comprasAPI: ComprasService, private usuariosAPI: LoginServiceService) { }

  // cargaUsuarios(){
  //   this.usuariosAPI.LoadCompradores().subscribe(val =>{
  //     this.usuarios = val
  //     console.log(val)
  //   })
  // }

  cargaSolicitudes(){
    this.comprasAPI.ComprasActuales().subscribe(resul =>{
      this.solicitudes = resul
    })
  }

  borrarCompras(compra: ComprasModel){
    this.comprasAPI.BorrarCompra(compra).subscribe(val=>{
        console.log(val)
        
    })
  }

  aprobarSolic(compra){
    let aprob = this.refactorAprob(compra)
    
    this.comprasAPI.InsertAprobacion(aprob).subscribe(val=>{
      console.log(val)
    })

  }

  refactorAprob(compra){
    let compraMod = compra
    delete compraMod.tipoArticulo
    delete compraMod._id
    compraMod['estadoActual'] = true
    //console.log(compra)
    let aprobacion = compraMod
    
    //console.log(aprobacion)
    return aprobacion
  }

  ngOnInit() {
    this.cargaSolicitudes()
    //this.cargaUsuarios()
  }

}
