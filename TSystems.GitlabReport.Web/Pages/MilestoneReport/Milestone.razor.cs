using Microsoft.AspNetCore.Components;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Pages.MilestoneReport
{
    public partial class Milestone
    {
        public List<Core.Models.Milestone.Milestone> Milestones { get; set; } = new List<Core.Models.Milestone.Milestone>();

        [Inject]
        private IMilestoneService _milestoneService { get; set; }

        private async Task Search(MilestoneFilter authorsFilter)
        {
            Milestones = (await _milestoneService.Search(authorsFilter)).ToList();
        }
    }
}
