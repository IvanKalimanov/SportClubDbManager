using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class SportsmenWithoutMove
    {
        public decimal? CertNum { get; set; }
        public string Fio { get; set; }
        public DateTime? BirthDate { get; set; }
        public char? Sex { get; set; }
        public string Level { get; set; }
        public decimal? Trainer { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Partner { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime? StartDate { get; set; }

        public override string ToString()
        {
            return Fio + " номер сертииката: " + CertNum.ToString() + "\tзанимается с " + StartDate.ToString();
        }
    }
}
