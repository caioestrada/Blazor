namespace TSystems.GitlabReport.Web.Core.Models.Pipeline
{
    public class GroupReport
    {
        public string Name { get; set; }
        public List<ChartPipelineMonth> PipelinesMonth { get; set; }
    }
}
