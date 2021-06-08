using System;

namespace SportClubDbManager.Core.DTO
{
    public class PreviousTrainerDto
    {
        public decimal? TrainerId { get; set; }
        public string  TrainerFio { get; set; }
        public decimal? SportsmanCertNum { get; set; }
        public string SportsmanFio { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
