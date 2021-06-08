using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class PreviousTrainer
    {
        public decimal? Trainer { get; set; }
        public decimal? Sportsman { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Sportsman SportsmanNavigation { get; set; }
        public virtual Trainer TrainerNavigation { get; set; }
    }
}
