import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})
export class ChartComponent implements OnInit {
  @Input() chartLabels: string[] = [];
  @Input() chartData: number[] = [];

  chartOptions = {
    responsive: true
  };

  chartDatasets = [
    {
      data: this.chartData,
      label: 'Device Status'
    }
  ];
}
