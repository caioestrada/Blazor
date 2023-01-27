using TSystems.GitlabReport.Web.Core.Models.Pipeline;

namespace TSystems.GitlabReport.Web.Core.Interfaces
{
    public interface IPipelineService
    {
        Task<IEnumerable<GroupReport>> GetAllByYear(int year);
    }
}
