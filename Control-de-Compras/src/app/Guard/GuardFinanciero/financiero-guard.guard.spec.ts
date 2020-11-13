import { TestBed } from '@angular/core/testing';

import { FinancieroGuardGuard } from './financiero-guard.guard';

describe('FinancieroGuardGuard', () => {
  let guard: FinancieroGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(FinancieroGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
