namespace PFdata.Dashboard.Models.StudentStats
{
    public class DataPeriod
    {
        public Academics Acad { get; set; } = new Academics();

        public Attendance Attend { get; set; } = new Attendance();

        public Behavior Behav { get; set; } = new Behavior();

        public int InstructDays { get; set; }
        public string InstructPeriods { get; set; } //month

        public Change Change { get; set; } = new Change();

    }
}
