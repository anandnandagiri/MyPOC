import { Component, OnInit } from '@angular/core';
import { TaskService } from '../../shared/task.service';
import { faEdit, faTrashAlt } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styles: []
})
export class TaskListComponent implements OnInit {

  public TaskList = [];
  public faEdit = faEdit;
  public faTrashAlt = faTrashAlt;

  constructor(private _task: TaskService) { }

  ngOnInit() {
    this.TaskList = this._task.getTaskItems();
  }

}
