import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardFinancieroComponent } from './dashboard-financiero.component';

describe('DashboardFinancieroComponent', () => {
  let component: DashboardFinancieroComponent;
  let fixture: ComponentFixture<DashboardFinancieroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DashboardFinancieroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardFinancieroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
