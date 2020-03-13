using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BettingGrid.API.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string EventName { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal HomeSideOdds { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DrawOdds { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AwaySideOdds { get; set; }

        public DateTime StartDate { get; set; }
    }
}