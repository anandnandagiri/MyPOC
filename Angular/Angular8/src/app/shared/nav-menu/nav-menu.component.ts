import { Component, OnInit } from '@angular/core';
import { faCoffee, faHome, faTasks, faList, faSignOutAlt } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styles: []
})
export class NavMenuComponent implements OnInit {

  faCoffee = faCoffee;
  faHome = faHome;
  faTasks = faTasks;
  faList = faList;
  faSignOutAlt = faSignOutAlt;

  constructor() { }

  ngOnInit() {
  }

}
