using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.Core.Models
{
    public class SportsmanSearchModel
    {
        public string Fio { get; set; }
        public DateTime? BirthDate { get; set; }
        public char? Sex { get; set; }
        public string Level { get; set; }
        public string Address { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
