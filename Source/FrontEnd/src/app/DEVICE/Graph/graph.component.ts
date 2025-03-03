import { Component, OnInit } from '@angular/core';
import { ViewChild } from "@angular/core";
import { DeviceStatusComponent } from '../deviceStatus/deviceStatus.component';


// export type ChartOptions = {
//   series: ApexAxisChartSeries;
//   chart: ApexChart;
//   xaxis: ApexXAxis;
//   dataLabels: ApexDataLabels;
//   grid: ApexGrid;
//   stroke: ApexStroke;
//   title: ApexTitleSubtitle;
// };

@Component({
  selector: 'app-graph',
  templateUrl: './graph.component.html',
  styleUrls: ['./graph.component.css'],
  imports: [DeviceStatusComponent]
})
export class GraphComponent {

     
  constructor() {
 

}
}
