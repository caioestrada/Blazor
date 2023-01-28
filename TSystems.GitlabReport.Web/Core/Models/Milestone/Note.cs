using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Core.Models.Milestone
{
    public class Note
    {
        public long Id { get; set; }
        public string Body { get; set; }
        public Author Author { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool System { get; set; }
        public long? NoteableId { get; set; }
        public string NoteableType { get; set; }
        public bool Resolvable { get; set; }
        public bool Confidential { get; set; }
        public long NoteableIid { get; set; }
        public int TimeSpend { get; set; }
        public bool TimeSpendType { get; private set; }
        public bool AddTimeSpend { get; set; }
        public bool SubtractTimeSpend { get; set; }
    }
}
