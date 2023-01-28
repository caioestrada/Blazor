namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class MilestoneFilter
    {
        public List<long> Groups { get; set; } = new List<long>();
        public DateTime StartAt { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime EndAt { get; set; } = DateTime.Now;
    }
}
