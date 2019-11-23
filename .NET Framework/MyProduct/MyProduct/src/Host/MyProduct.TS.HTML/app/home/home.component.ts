import { Component } from '@angular/core';

@Component({
    selector: 'mp-home',
    templateUrl: 'app/home/home.html',
    styleUrls: ['app/app.bootstrap.min.css']
})

export class HomeComponent {
    pageTitle: string = "Home Page";
}