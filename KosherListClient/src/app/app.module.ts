import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule} from "@angular/router";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { MatSelectModule,MatRadioModule } from '@angular/material';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule,MatIconModule, MatDatepickerModule, MatNativeDateModule } from '@angular/material';
import { UpdatesComponent } from './updates/updates.component';
import { HttpClientModule } from '@angular/common/http';
import { RegisterComponent } from './register/register.component';
import { StoreComponent } from './store/store.component';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { TimetableComponent } from './timetable/timetable.component';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { CommonModule } from '@angular/common';
import { FlatpickrModule } from 'angularx-flatpickr';
import { EntranceComponent } from './entrance/entrance.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    UpdatesComponent,
    RegisterComponent,
    StoreComponent,
    TimetableComponent,
    EntranceComponent,
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSelectModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule,
    FormsModule,
    MatRadioModule,
 MatDatepickerModule, 
  MatNativeDateModule,
  ReactiveFormsModule,
  NgbModalModule,
  RouterModule,
  FlatpickrModule.forRoot(),

  CommonModule,
  CalendarModule.forRoot({ provide: DateAdapter, useFactory: adapterFactory })
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
