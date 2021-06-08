using System;
using System.Collections.Generic;

#nullable disable

namespace SportClubDbManager.Data
{
    public partial class PairedSportError
    {
        public decimal? CertNum { get; set; }
        public string Fio { get; set; }


        public override string ToString()
        {
            return Fio + " номер сертииката: " + CertNum.ToString();
        }
    }
}
