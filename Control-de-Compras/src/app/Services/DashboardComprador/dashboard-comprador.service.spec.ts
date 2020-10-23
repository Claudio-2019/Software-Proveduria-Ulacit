import { TestBed } from '@angular/core/testing';

import { DashboardCompradorService } from './dashboard-comprador.service';

describe('DashboardCompradorService', () => {
  let service: DashboardCompradorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DashboardCompradorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
