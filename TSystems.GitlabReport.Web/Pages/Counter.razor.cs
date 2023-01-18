using Radzen.Blazor;
using System.Globalization;
using TSystems.GitlabReport.Web.Core.Models.Groups;

namespace TSystems.GitlabReport.Web.Pages
{
    public partial class Counter
    {
        int currentCount = 0;
        IEnumerable<Group> Groups = new List<Group>
        {
            new Group { Name = "Infraestrutura", Path = "mercedes/infraestrutura" },
            new Group { Name = "Vendas", Path = "mercedes/t-digital/pos-vendas" },
            new Group { Name = "Logistica", Path = "mercedes/t-digital/logistica" },
            new Group { Name = "Rh", Path = "mercedes/rh" },
            new Group { Name = "Eletronica", Path = "mercedes/engenharia/eletronica-embarcada" },
            new Group { Name = "Documentacao", Path = "mercedes/t-digital/documentacao" }
        };
        IEnumerable<string> SelectedGroups = new string[] { "Vendas", "Logistica" };

        private void IncrementCount()
        {
            currentCount++;
        }

        IEnumerable<ColorScheme> colorSchemes = Enum.GetValues(typeof(ColorScheme)).Cast<ColorScheme>();
        ColorScheme colorScheme = ColorScheme.Palette;

        class DataItem
        {
            public int Year { get; set; }
            public string Quarter { get; set; }
            public double Revenue { get; set; }
        }

        string FormatAsUSD(object value)
        {
            return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
        }

        IList<DataItem> revenue = new List<DataItem>();

        protected override void OnInitialized()
        {
            var random = new Random();

            for (var year = 2013; year <= 2020; year++)
            {
                for (var quarter = 1; quarter <= 4; quarter++)
                {
                    revenue.Add(new DataItem
                    {
                        Year = year,
                        Quarter = $"Q{quarter}",
                        Revenue = random.NextDouble() * 200000
                    });
                }
            }
        }
    }
}
