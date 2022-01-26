import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroGastosComponent } from './registro-gastos.component';

describe('RegistroGastosComponent', () => {
  let component: RegistroGastosComponent;
  let fixture: ComponentFixture<RegistroGastosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistroGastosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistroGastosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
