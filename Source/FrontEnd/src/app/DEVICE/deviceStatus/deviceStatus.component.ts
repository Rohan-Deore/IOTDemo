import { Component, OnInit } from '@angular/core';
import { GraphComponent } from "../Graph/graph.component";

@Component({
  selector: 'app-deviceStatus',
  templateUrl: './deviceStatus.component.html',
  styleUrls: ['./deviceStatus.component.css'],
  imports: [GraphComponent]
})
export class DeviceStatusComponent  {
  @Input() deviceName: string = '';
  @Input() status: boolean = false;
  
}
