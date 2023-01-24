namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class MilestoneWithIssue
    {
        public long MilestoneId { get; set; }
        public string MilestoneTitle { get; set; }
        public string GitLabUrl { get; set; }
        public int TotalTimeSpent { get; set; }
        public List<IssueWithSpendNote> Issues { get; set; }
    }
}
