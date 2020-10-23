import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DasboardCompradorComponent } from './dasboard-comprador.component';

describe('DasboardCompradorComponent', () => {
  let component: DasboardCompradorComponent;
  let fixture: ComponentFixture<DasboardCompradorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DasboardCompradorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DasboardCompradorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
