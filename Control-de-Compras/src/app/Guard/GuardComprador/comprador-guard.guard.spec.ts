import { TestBed } from '@angular/core/testing';

import { CompradorGuardGuard } from './comprador-guard.guard';

describe('CompradorGuardGuard', () => {
  let guard: CompradorGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(CompradorGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
