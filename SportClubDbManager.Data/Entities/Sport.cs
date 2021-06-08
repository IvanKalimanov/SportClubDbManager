using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class Sport
    {
        public Sport()
        {
            Trainers = new HashSet<Trainer>();
        }

        public string Name { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
