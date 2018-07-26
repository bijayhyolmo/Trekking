using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trekking.Models
{
    public class Departure
    {
        public int DepartureId { get; set; }

        public string TripName { get; set; }

        public DateTime TripDate { get; set; }

        public decimal MarketPrice { get; set; }

        public decimal OfferPrice { get; set; }

        public int SeatsLeft { get; set; }
    }
}