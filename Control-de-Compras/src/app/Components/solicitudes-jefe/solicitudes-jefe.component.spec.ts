import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudesJefeComponent } from './solicitudes-jefe.component';

describe('SolicitudesJefeComponent', () => {
  let component: SolicitudesJefeComponent;
  let fixture: ComponentFixture<SolicitudesJefeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SolicitudesJefeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudesJefeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
