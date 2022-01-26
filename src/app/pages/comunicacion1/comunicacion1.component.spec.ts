import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Comunicacion1Component } from './comunicacion1.component';

describe('Comunicacion1Component', () => {
  let component: Comunicacion1Component;
  let fixture: ComponentFixture<Comunicacion1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Comunicacion1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Comunicacion1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
