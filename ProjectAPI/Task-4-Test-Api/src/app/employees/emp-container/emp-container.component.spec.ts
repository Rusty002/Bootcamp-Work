import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpContainerComponent } from './emp-container.component';

describe('EmpContainerComponent', () => {
  let component: EmpContainerComponent;
  let fixture: ComponentFixture<EmpContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpContainerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmpContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
