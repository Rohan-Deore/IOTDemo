import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-deviceStatus',
  templateUrl: './deviceStatus.component.html',
  styleUrls: ['./deviceStatus.component.css'],
  imports: []
})
export class DeviceStatusComponent  {
  @Input() deviceName: string = '';
  @Input() status: boolean = false;
  
}
