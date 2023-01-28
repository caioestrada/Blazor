using System.Text.Json.Serialization;

namespace TSystems.GitlabReport.Web.Core.Models.Milestone
{
    public class Milestone
    {

        public long Id { get; set; }
        public long Iid { get; set; }
        public long GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? Expired { get; set; }
        public Uri WebUrl { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
    }
}
