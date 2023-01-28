using TSystems.GitlabReport.Web.Core.Models;
using TSystems.GitlabReport.Web.Core.Models.Groups;

namespace TSystems.GitlabReport.Web.Core.Interfaces
{
    public interface IGroupService
    {
        Task<Dictionary<string, string>> GetAll();
        Task<List<Group>> GetAllWithId();
    }
}
