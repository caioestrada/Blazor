namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class SpendNote
    {
        public long NoteId { get; set; }
        public int TotalSpent { get; set; }
        public DateTime? SpentAt { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}
