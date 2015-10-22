namespace PFdata.Dashboard.Models.RowItemStats
{
    public class Improvement
    {
        public bool Deten { get; set; }
        public bool OfficeRefs { get; set; }
        public bool Suspend { get; set; }
        public bool Attend { get; set; }
        public bool Acad { get; set;}
        public bool Homework { get; set; }
        public bool Tardies { get; set; }

        public bool Any { get; set; }
        public bool All { get; set; }

    }
}