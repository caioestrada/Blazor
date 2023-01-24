namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class IssueWithSpendNote
    {
        public long IssueId { get; set; }
        public string IssueTitle { get; set; }
        public string GitLabUrl { get; set; }
        public int TotalTimeSpent { get; set; }
        public IEnumerable<string> Labels { get; set; }
        public List<SpendNote> SpendHistory { get; set; }
    }
}
