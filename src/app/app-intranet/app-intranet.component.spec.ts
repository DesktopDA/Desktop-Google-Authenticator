import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppIntranetComponent } from './app-intranet.component';

describe('AppIntranetComponent', () => {
  let component: AppIntranetComponent;
  let fixture: ComponentFixture<AppIntranetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppIntranetComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppIntranetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
