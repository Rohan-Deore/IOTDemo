import { Component, OnInit } from '@angular/core';
import { ViewChild } from "@angular/core";
import { DeviceStatusComponent } from '../deviceStatus/deviceStatus.component';
import { timestamp } from 'rxjs';


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
export class GraphComponent  {
  DataPoints = [
    {
      deviceName: 'DeviceA',
      status:true,
      timestamp: new Date() 
    },
    {
      deviceName: 'DeviceB',
      status:false,
      timestamp:new Date()
    }
  ];


  getChartData() {
    return {
      labels: this.DataPoints.map(dp=> dp.deviceName),
      data: this.DataPoints.map(dp => dp.status ? 1 : 0)
    };
  }
}

     
  
