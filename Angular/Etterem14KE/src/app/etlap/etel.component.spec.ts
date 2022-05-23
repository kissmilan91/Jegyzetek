import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EtelComponent } from './etel.component';

describe('EtelComponent', () => {
  let component: EtelComponent;
  let fixture: ComponentFixture<EtelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EtelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EtelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
