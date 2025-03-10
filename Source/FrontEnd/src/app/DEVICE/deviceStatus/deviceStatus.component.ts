import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-deviceStatus',
  templateUrl: './deviceStatus.component.html',
  styleUrls: ['./deviceStatus.component.css']
})
export class DeviceStatusComponent implements OnInit {
  @Input() data: any;
  Status: boolean = true;
  DeviceName: string = "Device1";
  StatusTime : Date = new Date();

  constructor() { }

  ngOnInit() {
  }

}
