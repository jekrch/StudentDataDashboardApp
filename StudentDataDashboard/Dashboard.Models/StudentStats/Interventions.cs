namespace PFdata.Dashboard.Models.StudentStats
{
    public class Interventions
    {
        public IntvsNeeded Needed { get; set; } = new IntvsNeeded();

        public int ServNum { get; set; }
        public int ServMin { get; set; }

        public int CareNum { get; set; }
        public int CareMin { get; set; }

        public int HighQualInSchoolNum { get; set; }
        public int HighQualInSchoolMin { get; set; }

        public int HighQualOutOfSchoolNum { get; set; }
        public int HighQualOutOfSchoolMin { get; set; }

        public int HighQualTotalNum { get; set; }
        public int HighQualTotalMin { get; set; }

        public int DuplicatedTotalMins { get; set; }
    }
}