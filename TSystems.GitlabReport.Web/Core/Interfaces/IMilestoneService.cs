using TSystems.GitlabReport.Web.Core.Models.AuthorReport;
using TSystems.GitlabReport.Web.Core.Models.Milestone;

namespace TSystems.GitlabReport.Web.Core.Interfaces
{
    public interface IMilestoneService
    {
        Task<IEnumerable<Milestone>> Search(MilestoneFilter authorsFilter);
    }
}
