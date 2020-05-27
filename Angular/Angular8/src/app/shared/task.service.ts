import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor() { }

  public getTaskGroupItems() {
    return [
      { "id": "1", "Title": "S" },
      { "id": "2", "Title": "P1" },
      { "id": "3", "Title": ".NET Core" },
      { "id": "4", "Title": "VAapps" }
    ];
  }

  public getTaskItems() {
    return [
      { "id": "1", "Title": "This s1" },
      { "id": "2", "Title": "This s2" },
      { "id": "3", "Title": "This s3" },
      { "id": "4", "Title": "VAapps" }
    ];
  }


}
