import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmitirBoletaComponent } from './emitir-boleta.component';

describe('EmitirBoletaComponent', () => {
  let component: EmitirBoletaComponent;
  let fixture: ComponentFixture<EmitirBoletaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmitirBoletaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmitirBoletaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
