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

        [Inject]
        private IAuthorService _authorService { get; set; }

        protected override async Task OnInitializedAsync()
        {
        }

        private async Task Search(AuthorsFilter authorsFilter) 
        {
            Authors = (await _authorService.Search(authorsFilter)).ToList();
        }

        private async Task FindMilestonesByAuthor(DataGridCellMouseEventArgs<AuthorWithMilestone> args)
        {
            MilestonesByAuthor = args.Data.Milestones;
        }
    }
}
