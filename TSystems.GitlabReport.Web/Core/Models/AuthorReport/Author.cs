namespace TSystems.GitlabReport.Web.Core.Models.AuthorReport
{
    public class Author
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }


        public string State { get; set; }

        public Uri AvatarUrl { get; set; }

        public Uri WebUrl { get; set; }

        public DateTime? LastActivityOn { get; set; }
    }
}
