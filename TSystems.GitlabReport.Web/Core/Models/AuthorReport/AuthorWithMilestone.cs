namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class AuthorWithMilestone
    {
        public long AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AvatarUrl { get; set; }
        public int TotalTimeSpent { get; set; }
        public List<MilestoneWithIssue> Milestones { get; set; }
    }
}
