using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class Sportsman
    {
        public Sportsman()
        {
            InversePartnerNavigation = new HashSet<Sportsman>();
        }

        public decimal CertNum { get; set; }
        public string Fio { get; set; }
        public DateTime BirthDate { get; set; }
        public char? Sex { get; set; }
        public string Level { get; set; }
        public decimal? Trainer { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Partner { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual Sportsman PartnerNavigation { get; set; }
        public virtual Trainer TrainerNavigation { get; set; }
        public virtual ICollection<Sportsman> InversePartnerNavigation { get; set; }
    }
}
