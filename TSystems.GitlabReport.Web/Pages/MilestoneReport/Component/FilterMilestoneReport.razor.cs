using Microsoft.AspNetCore.Components;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;
using TSystems.GitlabReport.Web.Core.Models.Groups;

namespace TSystems.GitlabReport.Web.Pages.MilestoneReport.Component
{
    public partial class FilterMilestoneReport
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public MilestoneFilter AuthorFilter { get; set; } = new MilestoneFilter();
        private bool hideLoader = true;

        [Parameter]
        public EventCallback<MilestoneFilter> OnFilterSearch { get; set; }

        [Inject]
        private IGroupService _groupService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Groups = (await _groupService.GetAllWithId()).ToList();
        }

        private async Task Search()
        {
            hideLoader = false;
            await OnFilterSearch.InvokeAsync(AuthorFilter);
            hideLoader = true;
        }
    }
}
