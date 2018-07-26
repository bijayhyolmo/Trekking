using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trekking.Models
{
    public class ContactInformation
    {
        public int ContactInformationId { get; set; }

        public string ContactType { get; set; }

        public string Number { get; set; }
    }
}