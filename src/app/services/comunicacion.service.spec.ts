import { TestBed } from '@angular/core/testing';

import { ComunicacionService } from './comunicacion.service';

describe('ComunicacionService', () => {
  let service: ComunicacionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComunicacionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
