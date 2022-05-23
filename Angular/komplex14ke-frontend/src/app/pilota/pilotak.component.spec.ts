import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PilotakComponent } from './pilotak.component';

describe('PilotakComponent', () => {
  let component: PilotakComponent;
  let fixture: ComponentFixture<PilotakComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PilotakComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PilotakComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
