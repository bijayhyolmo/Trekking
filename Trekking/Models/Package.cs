using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trekking.Models
{
    public class Package
    {
        public int Packageid { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public decimal Cost { get; set; }

        public string Currency { get; set; }

        public string Duration { get; set; }

        public string ImagePath { get; set; }

        public int ProductHighlightId { get; set; }

        public string Price { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public string Difficulty { get; set; }

        public string MaxElevation { get; set; }

        public string Meal { get; set; }

        public string Accomodation { get; set; }

        public string Transportation { get; set; }

        public string BestMonth { get; set; }

        public int GroupSize { get; set; }

        public string Overview { get; set; }

        public string Itinerary { get; set; }

        public string DetailItinerary { get; set; }

        public string TripIncEnc { get; set; }
    }
}