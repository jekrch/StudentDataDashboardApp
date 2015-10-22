using System.Collections.Generic;
using System.Linq;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Models.RowItemStats;

namespace PFdata.Dashboard.Operations
{
    public class FellowData
    {
        // Creates a list of promise fellows with all of their displayed fields representing 
        //the sum of each of their youths' totals
        public static List<PromiseFellow> CreatePromiseFellowList(List<Student> studentList)
        {
            var fellowNameList = studentList.Select(student => student.Profile.Fellow).Distinct();

            return fellowNameList.Select(fellow => new PromiseFellow
            {
                Profile = new Profile()
                {
                    Name = fellow,
                    Site = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.Profile.Site)).First()
                },
                
                TotalDays = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.TotalDays)).Sum(),

                InterventionTotal = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.InterventionTotal)).Sum(),

                AvgIntvMin = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.AvgIntvMin)).Sum(),

                MissingBaselineCount = (studentList
                    .Where(student => student.Profile.Fellow == fellow && student.MissingBaselineCount > 0)).Count(),

                ImproveOverallCount = (studentList
                    .Where(student => student.Profile.Fellow == fellow && student.Improvement.Any)).Count(),

                TotalInstructDays = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.TotalInstructDays)).Sum(),

            }).ToList();
        }
    }
}
