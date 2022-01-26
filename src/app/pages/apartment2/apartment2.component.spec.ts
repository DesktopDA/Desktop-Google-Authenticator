import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Apartment2Component } from './apartment2.component';

describe('Apartment2Component', () => {
  let component: Apartment2Component;
  let fixture: ComponentFixture<Apartment2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Apartment2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Apartment2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
