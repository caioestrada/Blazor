namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class AuthorsFilter
    {
        public List<string> Groups { get; set; } = new List<string>();
        public long AuthorId { get; set; }
        public DateTime StartAt { get; set; } = DateTime.Now.AddDays(-5);
        public DateTime EndAt { get; set; } = DateTime.Now;
    }
}
