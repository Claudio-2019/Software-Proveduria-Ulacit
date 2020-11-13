import { TestBed } from '@angular/core/testing';

import { JefeGuardGuard } from './jefe-guard.guard';

describe('JefeGuardGuard', () => {
  let guard: JefeGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(JefeGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
