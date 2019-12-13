import { Component, OnInit } from '@angular/core';
declare var require: any;

@Component({
  selector: 'app-appversioninfo',
  templateUrl: './appversioninfo.component.html',
  styles: []
})
export class AppversionInfoComponent implements OnInit {

  appversion: string = require('../../../package.json').version;
  appbuildversion: string = require('../../../package.json').buildversion;
  constructor() { }

  ngOnInit() {
  }

}
