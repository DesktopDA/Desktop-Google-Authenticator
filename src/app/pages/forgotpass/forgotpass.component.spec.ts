import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForgotpassComponent } from './forgotpass.component';

describe('ForgotpassComponent', () => {
  let component: ForgotpassComponent;
  let fixture: ComponentFixture<ForgotpassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ForgotpassComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ForgotpassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
