
using PFdata.Dashboard.Models.RowItemStats;

namespace PFdata.Dashboard.Models
{
    public class RowItem
    {
        public int TotalDays { get; set; }
        public int TotalInstructDays { get; set; }

        public int InterventionTotal { get; set; }
        public double AvgIntvMin { get; set; }

        public int MissingBaselineCount { get; set; }

        public Improvement Improvement { get; set; } = new Improvement();
        public int ImproveOverallCount { get; set; }

        public Profile Profile { get; set; } = new Profile();
    }
}