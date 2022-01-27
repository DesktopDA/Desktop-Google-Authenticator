import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialVisitasComponent } from './historial-visitas.component';

describe('HistorialVisitasComponent', () => {
  let component: HistorialVisitasComponent;
  let fixture: ComponentFixture<HistorialVisitasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HistorialVisitasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HistorialVisitasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
