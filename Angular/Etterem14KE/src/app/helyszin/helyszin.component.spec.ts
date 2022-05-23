import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelyszinComponent } from './helyszin.component';

describe('HelyszinComponent', () => {
  let component: HelyszinComponent;
  let fixture: ComponentFixture<HelyszinComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HelyszinComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HelyszinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
