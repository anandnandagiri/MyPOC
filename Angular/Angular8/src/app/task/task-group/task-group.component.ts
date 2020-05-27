import { Component, OnInit } from '@angular/core';
import { TaskService } from '../../shared/task.service';

@Component({
  selector: 'app-task-group',
  templateUrl: './task-group.component.html',
  styles: []
})
export class TaskGroupComponent implements OnInit {

  public TaskGroups = [];


  constructor(private _task: TaskService) { }

  ngOnInit() {
    this.TaskGroups = this._task.getTaskGroupItems();
  }
}
