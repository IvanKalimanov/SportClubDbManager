using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.Core.DTO
{
    public class SportsmanDto
    {
        public decimal CertNum { get; set; }
        public string Fio { get; set; }
        public DateTime BirthDate { get; set; }
        public char? Sex { get; set; }
        public string Level { get; set; }
        public decimal? TrainerId { get; set; }
        public string TrainerFio { get; set; }
        public decimal? Rating { get; set; }
        public decimal? PartnerCertNum { get; set; }
        public string PartnerFio { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
