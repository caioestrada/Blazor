using Radzen.Blazor;
using Microsoft.AspNetCore.Components;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Pages.UserReport.Component
{
    public partial class FilterUserReport
    {
        public List<Author> Authors { get; set; } = new List<Author>();
        public Dictionary<string, string> Groups { get; set; } = new Dictionary<string, string>();
        public AuthorsFilter AuthorFilter { get; set; } = new AuthorsFilter();
        private bool hideLoader = true;

        [Parameter]
        public EventCallback<AuthorsFilter> OnFilterSearch { get; set; }

        [Inject]
        private IAuthorService _authorService { get; set; }
        [Inject]
        private IGroupService _groupService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Authors = (await _authorService.GetAll()).ToList();
            Groups = await _groupService.GetAll();
        }

        private async Task Search()
        {
            hideLoader = false;
            await OnFilterSearch.InvokeAsync(AuthorFilter);
            hideLoader = true;
        }
    }
}
