using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Core.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAll();
        Task<IEnumerable<AuthorWithMilestone>> Search(AuthorsFilter authorsFilter);
    }
}
