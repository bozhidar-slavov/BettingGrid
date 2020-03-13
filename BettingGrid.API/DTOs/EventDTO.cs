using System;
using System.ComponentModel.DataAnnotations;

namespace BettingGrid.API.DTOs
{
    public class EventDTO
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        public string EventName { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid coefficient")]
        public decimal HomeSideOdds { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid coefficient")]
        public decimal DrawOdds { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid coefficient")]
        public decimal AwaySideOdds { get; set; }
        
        public DateTime StartDate { get; set; }
    }
}