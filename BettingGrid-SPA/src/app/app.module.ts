import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { EventService } from 'src/_services/event.service';
import { EventsComponent } from './events/events.component';

@NgModule({
   declarations: [
      AppComponent,
      EventsComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule
   ],
   providers: [
      EventService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
