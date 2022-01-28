import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialPagosComponent } from './historial-pagos.component';

describe('HistorialPagosComponent', () => {
  let component: HistorialPagosComponent;
  let fixture: ComponentFixture<HistorialPagosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HistorialPagosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HistorialPagosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
