import { TestBed } from '@angular/core/testing';

import { AprobacionFinancieroService } from './aprobacion-financiero.service';

describe('AprobacionFinancieroService', () => {
  let service: AprobacionFinancieroService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AprobacionFinancieroService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
