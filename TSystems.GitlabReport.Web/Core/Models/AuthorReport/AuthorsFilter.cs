namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class AuthorsFilter
    {
        public List<string> GroupsPath { get; set; } = new List<string>();
        public List<long> Authors { get; set; } = new List<long>();
        public DateTime StartAt { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DateTime EndAt { get; set; } = DateTime.Now;
    }
}
