using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class SportsmenMove
    {
        public string SportsmanName { get; set; }
        public string TrainerName { get; set; }
        public string SportName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return SportsmanName + " занимался(ется) у " + TrainerName + " c " + StartDate.ToString() + 
                " по " + EndDate.ToString();
        }
    }
}
