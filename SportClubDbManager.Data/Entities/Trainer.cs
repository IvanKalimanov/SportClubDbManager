using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class Trainer
    {
        public Trainer()
        {
            Sportsmen = new HashSet<Sportsman>();
        }

        public decimal Id { get; set; }
        public string Fio { get; set; }
        public string SportName { get; set; }
        public string Level { get; set; }
        public decimal? Rating { get; set; }

        public virtual Sport SportNameNavigation { get; set; }
        public virtual ICollection<Sportsman> Sportsmen { get; set; }
    }
}
