using Microsoft.AspNetCore.Components;
using Radzen;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Pages.UserReport
{
    public partial class User
    {
        public List<AuthorWithMilestone> Authors { get; set; } = new List<AuthorWithMilestone>();
        public List<MilestoneWithIssue> MilestonesByAuthor { get; set; } = new List<MilestoneWithIssue>();
        public List<IssueWithSpendNote> IssuesByMilestone { get; set; } = new List<IssueWithSpendNote>();

        IList<AuthorWithMilestone> selectedAuthors;
        IList<MilestoneWithIssue> selectedMilestones;

        [Inject]
        private IAuthorService _authorService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            selectedAuthors = new List<AuthorWithMilestone>();
            selectedMilestones = new List<MilestoneWithIssue>();
        }

        private async Task Search(AuthorsFilter authorsFilter)
        {
            Authors = (await _authorService.Search(authorsFilter)).ToList();
        }

        private async Task FindMilestonesByAuthor(DataGridCellMouseEventArgs<AuthorWithMilestone> authorWithMilestone)
        {
            IssuesByMilestone = new List<IssueWithSpendNote>();
            selectedAuthors = new List<AuthorWithMilestone>() { authorWithMilestone.Data };
            MilestonesByAuthor = authorWithMilestone.Data.Milestones;
        }

        private async Task FindIssuesByMilestones(DataGridCellMouseEventArgs<MilestoneWithIssue> milestoneWithIssue)
        {
            selectedMilestones = new List<MilestoneWithIssue>() { milestoneWithIssue.Data };
            IssuesByMilestone = milestoneWithIssue.Data.Issues;
        }
    }
}
