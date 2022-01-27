import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookingConsultaComponent } from './booking-consulta.component';

describe('BookingConsultaComponent', () => {
  let component: BookingConsultaComponent;
  let fixture: ComponentFixture<BookingConsultaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BookingConsultaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BookingConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
