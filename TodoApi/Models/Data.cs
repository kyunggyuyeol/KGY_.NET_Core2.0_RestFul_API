using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Data
    {
        public long ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public double PayRate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
