import { Component, OnInit } from '@angular/core';
import { TaskService } from '../shared/task.service';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styles: []
})
export class TaskComponent implements OnInit {

  public TaskGroups = [];

  constructor(private _task: TaskService) { }

  ngOnInit() {
    this.TaskGroups = this._task.getTaskGroupItems();
  }

}
