using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Core.Models.Milestone
{
    public class Issue
    {
        public long Id { get; set; }
        public long Iid { get; set; }
        public long ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
        public Author ClosedBy { get; set; }
        public IEnumerable<string> Labels { get; set; }
        public Milestone Milestone { get; set; }
        public Author[] Assignees { get; set; }
        public Author Author { get; set; }
        public string Type { get; set; }
        public Author Assignee { get; set; }
        public DateTime? DueDate { get; set; }
        public string IssueType { get; set; }
        public Uri WebUrl { get; set; }
        public long GroupId { get; set; }

        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
