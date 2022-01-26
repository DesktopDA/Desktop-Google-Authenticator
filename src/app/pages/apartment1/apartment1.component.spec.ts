import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Apartment1Component } from './apartment1.component';

describe('Apartment1Component', () => {
  let component: Apartment1Component;
  let fixture: ComponentFixture<Apartment1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Apartment1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Apartment1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
