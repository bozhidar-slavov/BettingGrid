import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Event } from 'src/_models/event';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseUrl = environment.apiUrl;

constructor(private http: HttpClient) { }

  private _refreshNeeded = new Subject<void>();

  get refreshNeeded() {
    return this._refreshNeeded;
  }

  getEvents(): Observable<Event[]> {
    return this.http.get<Event[]>(this.baseUrl + 'events');
  }

  addNewEvent() {
    return this.http.post(this.baseUrl + 'events', {})
      .pipe(
        tap(() => {
          this.refreshNeeded.next();
        })
      );
  }

  updateEvent(id: number, event: Event) {
    return this.http.put(this.baseUrl + 'events/' + id, event);
  }

  deleteEvent(id) {
    return this.http.delete(this.baseUrl + 'events/' + id)
      .pipe(
        tap(() => {
          this.refreshNeeded.next();
        })
      );
  }
}
