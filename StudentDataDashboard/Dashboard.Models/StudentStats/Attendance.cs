namespace PFdata.Dashboard.Models.StudentStats
{
    public class Attendance
    {
        public double Absences { get; set; }
        public double Rate { get; set; }
        public int Unknowns { get; set; }
        public int Tardies { get; set; }
        public double OnTimeRate { get; set; }
    }
}