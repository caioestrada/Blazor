using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System.Text.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Pages.UserReport.Component
{
    public partial class FilterUserReport
    {
        private bool hideLoader = true;

        public List<Author> Authors { get; set; } = new List<Author>();
        public Dictionary<string, string> Groups { get; set; } = new Dictionary<string, string>();
        public AuthorsFilter AuthorFilter { get; set; } = new AuthorsFilter();

        [Parameter]
        public EventCallback<AuthorsFilter> OnFilterSearch { get; set; }

        [Inject]
        private IAuthorService _authorService { get; set; }
        [Inject]
        private IGroupService _groupService { get; set; }
        [Inject]
        public ILocalStorageService _localStorage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Authors = (await _authorService.GetAll()).ToList();
            Groups = await _groupService.GetAll();

            await _localStorage.SetItemAsync("JwtToken", "Token");
        }

        private async Task Search()
        {
            hideLoader = false;
            await _localStorage.SetItemAsync("userReportFilter", JsonSerializer.Serialize(AuthorFilter));
            await OnFilterSearch.InvokeAsync(AuthorFilter);
            hideLoader = true;
        }
    }
}
