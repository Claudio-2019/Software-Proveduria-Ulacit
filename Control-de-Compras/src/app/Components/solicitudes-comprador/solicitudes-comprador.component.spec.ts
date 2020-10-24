import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudesCompradorComponent } from './solicitudes-comprador.component';

describe('SolicitudesCompradorComponent', () => {
  let component: SolicitudesCompradorComponent;
  let fixture: ComponentFixture<SolicitudesCompradorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SolicitudesCompradorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudesCompradorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
