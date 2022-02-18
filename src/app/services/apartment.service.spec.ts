import { TestBed } from '@angular/core/testing';

import { ApartmentService } from './apartment.service';

describe('ApartmentService', () => {
  let service: ApartmentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ApartmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
