using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingGrid.API.Data;
using BettingGrid.API.DTOs;
using BettingGrid.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BettingGrid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }

        [HttpPost]
        public Event AddNewEvent()
        {
            var newEvent = new Event()
            {
                StartDate = DateTime.Today.AddDays(1).AddMinutes(-1)
            };

            _context.Events.Add(newEvent);
            _context.SaveChanges();

            return newEvent;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEvent(int id, EventDTO eventDTO)
        {
            if (id != eventDTO.Id)
            {
                return BadRequest();
            }

            var eventToUpdate = _context.Events.Find(id);
            if (eventToUpdate == null)
            {
                return NotFound();
            }

            eventToUpdate.EventName = eventDTO.EventName;
            eventToUpdate.HomeSideOdds = eventDTO.HomeSideOdds;
            eventToUpdate.DrawOdds = eventDTO.DrawOdds;
            eventToUpdate.AwaySideOdds = eventDTO.AwaySideOdds;
            eventToUpdate.StartDate = eventDTO.StartDate;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException) when (!EventsExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            var eventToDelete = _context.Events.Find(id);

            if (eventToDelete == null)
            {
                return NotFound();
            }

            _context.Events.Remove(eventToDelete);
            _context.SaveChanges();

            return NoContent();
        }

        private bool EventsExists(int id) =>
         _context.Events.Any(e => e.Id == id);
    }
}