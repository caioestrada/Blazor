using Microsoft.AspNetCore.Components;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Pages.UserReport
{
    public partial class User
    {
        public List<AuthorMilestoneReportItem> AuthorsByGroup { get; set; } = new List<AuthorMilestoneReportItem>();

        [Inject]
        private IAuthorService _authorService { get; set; }

        protected override async Task OnInitializedAsync()
        {
        }

        private async Task Search(AuthorsFilter authorsFilter) 
        {
            AuthorsByGroup = (await _authorService.Search(authorsFilter.Groups.FirstOrDefault().ToLower())).ToList();
        }
    }
}
