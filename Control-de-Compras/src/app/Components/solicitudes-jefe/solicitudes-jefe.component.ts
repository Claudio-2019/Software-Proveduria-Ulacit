import { Component, OnInit, Input} from '@angular/core';

@Component({
  selector: 'app-solicitudes-jefe',
  templateUrl: './solicitudes-jefe.component.html',
  styleUrls: ['./solicitudes-jefe.component.css']
})
export class SolicitudesJefeComponent implements OnInit {

  @Input() correo: string
  
  constructor() { }

  ngOnInit() {
    
  }

}
