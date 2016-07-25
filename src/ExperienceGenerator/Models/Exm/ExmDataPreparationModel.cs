using System.Collections.Generic;

namespace ExperienceGenerator.Models.Exm
{
    public class ExmDataPreparationModel
    {
        public bool RebuildMasterIndex { get; set; }

        public int NumContacts { get; set; }

        public decimal ContactGrowth { get; set; }

        public List<ExmSpecificList> SpecificLists { get; set; }

        public List<ExmSpecificCampaign> SpecificCampaigns { get; set; }

        public ExmRandomCampaignsDefinition RandomCampaigns { get; set; }

        public ExmRandomListsDefinition RandomLists { get; set; }

        public List<ExmGoal> Goals { get; set; }

        public Dictionary<int, double> EventDayDistribution { get; set; }

        public ExmJob Job { get; set; }
    }
}