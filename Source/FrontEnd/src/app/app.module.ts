import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GraphComponent } from "./DEVICE/Graph/graph.component";
import { DeviceStatusComponent } from "./DEVICE/deviceStatus/deviceStatus.component";
import { NgApexchartsModule } from "ng-apexcharts";

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DeviceStatusComponent, GraphComponent,NgApexchartsModule
],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
