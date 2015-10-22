using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PFdata.Dashboard.Models;

namespace PFdata.Dashboard.Operations
{
    public class TotalsCalc
    {
        // Calculates student total data to be inserted into the totals boxes 
        public static Task CalculateStudentTotalsAsync(List<Student> filteredStudentList)
        {
            return Task.Run(() => MainWindow.Totals = CalculateStudentTotals(filteredStudentList));
        }

        public static StudentTotals CalculateStudentTotals(List<Student> sortedStudentList)
        {
            // Calculate totals

            var totals = new StudentTotals
            {
                MissingBaseline = (sortedStudentList.Where(student => student.MissingBaselineCount > 0)
                    .Select(student => student.MissingBaselineCount))
                    .Count(),

                CaringAdultsmin = (sortedStudentList.Select(student => student.Intvns.CareMin))
                    .Sum(),

                ServiceMins = (sortedStudentList.Select(student => student.Intvns.ServMin))
                    .Sum(),

                SupportMins = (sortedStudentList.Select(student => student.Intvns.HighQualTotalMin))
                    .Sum(),

                InSchoolSupportMins = (sortedStudentList.Select(student => student.Intvns.HighQualInSchoolMin))
                    .Sum(),

                OutSchoolSupportMins = (sortedStudentList.Select(student => student.Intvns.HighQualOutOfSchoolMin))
                    .Sum(),

                InterventionMins = (sortedStudentList.Select(student => student.Intvns.DuplicatedTotalMins))
                    .Sum(),

                ReportDays = (sortedStudentList.Select(student => student.Ytd.InstructDays))
                    .Sum(),

                ImproveOverall = sortedStudentList.Count(student => student.Improvement.Any)
            };

            return totals;
        }
    }
}
