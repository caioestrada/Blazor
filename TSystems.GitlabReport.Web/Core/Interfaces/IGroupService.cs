using TSystems.GitlabReport.Web.Core.Models;

namespace TSystems.GitlabReport.Web.Core.Interfaces
{
    public interface IGroupService
    {
        Task<Dictionary<string, string>> GetAll();
    }
}
