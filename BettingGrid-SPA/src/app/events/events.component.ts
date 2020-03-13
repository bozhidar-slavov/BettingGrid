import { Component, OnInit, EventEmitter } from '@angular/core';
import { EventService } from 'src/_services/event.service';
import { Event } from 'src/_models/event';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {
  events: Event[];
  passed: string;
  modeButtonValue: string;
  editMode: string;
  contentEditable: string;

  constructor(private eventService: EventService) { }

  ngOnInit() {
    this.eventService.refreshNeeded
      .subscribe(() => {
        this.loadEvents();
      });

    this.loadEvents();

    this.modeButtonValue = 'Edit mode';
    this.editMode = 'non-editable';
    this.contentEditable = 'false';
  }

  loadEvents() {
    this.eventService.getEvents().subscribe((events: Event[]) => {
      this.events = events;
    }, error => {
      console.log(error);
    });
  }

  addNewEvent() {
    this.eventService.addNewEvent().subscribe(data => {
      alert('New event added successfully');
    }, error => {
      alert('Failed while adding new event');
    });
  }

  updateEvent(id: number, event: Event) {
    this.eventService.updateEvent(id, event).subscribe(next => {
      console.log(event);
      console.log('updates successfully');
    }, error => {
      console.log('error');
    });
  }

  deleteEvent(id: number) {
    if (confirm('Are you sure you want to delete element with id ' + id + '?')) {
      this.eventService.deleteEvent(id).subscribe(data => {
        console.log(data);
      }, error => {
        console.log(error);
      });
    }
  }

  onBlur(eventElement: Event, event: any) {
    const newText = event.target.innerText;
    event.target.innerText = '';
    eventElement.eventName = newText;
    event.target.innerText = newText;
  }

  onSaveClick(event: Event) {
    this.updateEvent(event.id, event);
  }

  onOddClick(event: any, id: number) {
    if (this.contentEditable === 'false' && event.target.classList.contains('printable')) {
      let oddValue = '';
      if (event.target.classList.contains('home-side-odds')) {
        oddValue = 'HomeSideOdds';
      }

      if (event.target.classList.contains('draw-odds')) {
        oddValue = 'DrawOdds';
      }

      if (event.target.classList.contains('away-side-odds')) {
        oddValue = 'AwaySideOdds';
      }

      console.log(`ID:${id} Type:${oddValue} Coefficient:${event.target.innerHTML}`);
    }
  }

  onModeButtonClick() {
    this.modeButtonValue === 'Edit mode' ? this.modeButtonValue = 'Preview mode' : this.modeButtonValue = 'Edit mode';
    this.editMode === 'editable' ? this.editMode = 'non-editable' : this.editMode = 'editable';
    this.contentEditable === 'false' ? this.contentEditable = 'true' : this.contentEditable = 'false';
  }

  isEventPassed(event: Event): string {
    const now = new Date();
    const eventDate = new Date(event.startDate);
    if (now >= eventDate) {
      return this.passed = 'passed-event-date';
    }

    return this.passed = 'event-details';
  }
}
