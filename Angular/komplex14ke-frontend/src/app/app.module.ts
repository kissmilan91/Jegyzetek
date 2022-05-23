import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PilotaComponent } from './pilota/pilota.component';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { PilotakComponent } from './pilota/pilotak.component';
import { FormsModule } from '@angular/forms';
import { UjpilotaComponent } from './ujpilota/ujpilota.component';
import {CalendarModule} from 'primeng/calendar';
import { InputTextModule} from 'primeng/inputtext';
import {InputNumberModule} from 'primeng/inputnumber';
import {DropdownModule} from 'primeng/dropdown';
import {DataViewModule} from 'primeng/dataview';



@NgModule({
  declarations: [
    AppComponent,
    PilotaComponent,
    PilotakComponent,
    UjpilotaComponent
  ],
  imports: [
    RouterModule,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    InputTextModule,CalendarModule,InputNumberModule,DropdownModule,DataViewModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
