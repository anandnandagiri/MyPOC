import { Component, OnInit } from '@angular/core';
import { DeviceDetectorService } from 'ngx-device-detector';


@Component({
  selector: 'app-user-device-info',
  templateUrl: './user-device-info.component.html',
  styles: []
})
export class UserDeviceInfoComponent implements OnInit {
  deviceInfo = null;
  isMobile = null;
  isTablet = null;
  isDesktopDevice = null;

  constructor( private deviceService: DeviceDetectorService) {
    this.userDeviceInfo();
  }

  ngOnInit() {
  }

  userDeviceInfo() {
    console.log('hello `Home` component');
    this.deviceInfo = this.deviceService.getDeviceInfo();
    this.isMobile = this.deviceService.isMobile();
    this.isTablet = this.deviceService.isTablet();
    this.isDesktopDevice = this.deviceService.isDesktop();
    console.log(this.deviceInfo);
    console.log(this.isMobile);  // returns if the device is a mobile device (android / iPhone / windows-phone etc)
    console.log(this.isTablet);  // returns if the device us a tablet (iPad etc)
    console.log(this.isDesktopDevice); // returns if the app is running on a Desktop browser.
  }

}
