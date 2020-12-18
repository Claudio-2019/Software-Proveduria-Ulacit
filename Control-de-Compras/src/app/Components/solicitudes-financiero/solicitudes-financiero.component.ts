import { Component, OnInit,  Input, ɵɵqueryRefresh } from '@angular/core';
import {ComprasModel} from 'src/app/Models/Compras'
import {AprobacionFinancieroService} from 'src/app/Services/Financieros/aprobacion-financiero.service'
import {UsuariosModel} from 'src/app/Models/Usuarios'
import {AprobacionModel} from 'src/app/Models/Aprobacion'
import {LoginServiceService} from 'src/app/Services/Login/login-service.service'


@Component({
  selector: 'app-solicitudes-financiero',
  templateUrl: './solicitudes-financiero.component.html',
  styleUrls: ['./solicitudes-financiero.component.css']
})
export class SolicitudesFinancieroComponent implements OnInit {


  solicitudes: ComprasModel[]
  usuarios: UsuariosModel[]

  constructor( private comprasAPI: AprobacionFinancieroService) { }


  cargaSolicitudes(){
    this.comprasAPI.AprobacionesFinancierasActuales().subscribe(resul =>{
      this.solicitudes = resul
    })
  }

  borrarCompras(compra: ComprasModel){
    this.comprasAPI.BorrarSolicitud(compra).subscribe(val=>{
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





