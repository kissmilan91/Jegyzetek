import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UjpilotaComponent } from './ujpilota.component';

describe('UjpilotaComponent', () => {
  let component: UjpilotaComponent;
  let fixture: ComponentFixture<UjpilotaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UjpilotaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UjpilotaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
