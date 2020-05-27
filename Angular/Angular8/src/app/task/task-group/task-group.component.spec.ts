import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskGroupComponent } from './task-group.component';

describe('TaskGroupComponent', () => {
  let component: TaskGroupComponent;
  let fixture: ComponentFixture<TaskGroupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TaskGroupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskGroupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
