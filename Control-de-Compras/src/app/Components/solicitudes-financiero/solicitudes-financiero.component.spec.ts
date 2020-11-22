import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudesFinancieroComponent } from './solicitudes-financiero.component';

describe('SolicitudesFinancieroComponent', () => {
  let component: SolicitudesFinancieroComponent;
  let fixture: ComponentFixture<SolicitudesFinancieroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolicitudesFinancieroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudesFinancieroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
