using PFdata.Dashboard.Models.StudentStats;

namespace PFdata.Dashboard.Models 
{
    public class Student : RowItem
    {
       
        public string Program { get; set; }
        public string Grade { get; set; }

        public string EwAttendReportPeriodNum { get; set; }
        public string EwBehavReportPeriodNum { get; set; }

        public Interventions Intvns { get; set; } = new Interventions() ;
        
        public SupportDates SupportDates { get; set; } = new SupportDates();

        // Baseline data / Early Warning fields
        public DataPeriod Bl { get; set; } = new DataPeriod();

        // Month data
        public DataPeriod Mo { get; set; } = new DataPeriod();

        // Year-To-Date data
        public DataPeriod Ytd { get; set; } = new DataPeriod();

        public CheckEwField CheckEwField { get; set; } = new CheckEwField();
    }
}
