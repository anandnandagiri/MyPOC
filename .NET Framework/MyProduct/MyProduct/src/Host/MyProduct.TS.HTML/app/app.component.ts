import { Component } from '@angular/core';

@Component({
    selector: 'mp-app',
    moduleId: module.id,
    templateUrl: 'appFirst.html',
    styleUrls: ['app.bootstrap.min.css']
})

export class AppComponent {
    pageTitle: string = "Home Page";
}