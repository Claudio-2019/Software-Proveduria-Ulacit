import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-solicitudes-financiero',
  templateUrl: './solicitudes-financiero.component.html',
  styleUrls: ['./solicitudes-financiero.component.css']
})
export class SolicitudesFinancieroComponent implements OnInit {

  @Input() correo: string
  
  constructor() { }

  ngOnInit() {
    
  }

}
