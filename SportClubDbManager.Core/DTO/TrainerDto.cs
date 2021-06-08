namespace SportClubDbManager.Core.DTO
{
    public class TrainerDto
    {
        public decimal Id { get; set; }
        public string Fio { get; set; }
        public string SportName { get; set; }
        public string Level { get; set; }
        public decimal? Rating { get; set; }
    }
}
