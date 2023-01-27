using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.Pipeline;

namespace TSystems.GitlabReport.Web.Pages.PipelineReport
{
    public partial class Pipeline
    {
        public List<GroupReport> Groups { get; set; } = new List<GroupReport>();

        bool smooth = false;
        bool showDataLabels = false;
        private bool hideLoader = true;
        List<int> years = new List<int>();
        IEnumerable<ColorScheme> colorSchemes = Enum.GetValues(typeof(ColorScheme)).Cast<ColorScheme>();
        ColorScheme colorScheme = ColorScheme.Palette;

        [Inject]
        private IPipelineService _pipelineService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            LoadPeriods();

            Groups = (await _pipelineService.GetAllByYear(DateTime.Now.Year)).ToList();
        }

        private void LoadPeriods()
        {
            for (int year = DateTime.Now.Year; year >= 2020; year--)
                years.Add(year);
        }

        protected async Task UpdateChart(object year)
        {
            hideLoader = false;
            year = Convert.ToInt32(year) == 0 ? DateTime.Now.Year : year;
            Groups = (await _pipelineService.GetAllByYear(Convert.ToInt32(year))).ToList();
            hideLoader = true;
        }

        string FormatAsMonth(object value)
        {
            if (value != null)
                return Convert.ToDateTime(value).ToString("MMM");

            return string.Empty;
        }
    }
}
