using System;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Models.RowItemStats;

namespace PFdata.Dashboard.Operations
{
    public class StudentDataCalc
    {
        public static DateTime TodayDate = DateTime.Now;

        // Calculate how many missing baseline fields a student currently has
        public static void CalculateMissingBaselineTotal(Student stud)
        {
            if (!stud.CheckEwField.Absences) stud.MissingBaselineCount++;
            if (!stud.CheckEwField.Tardies) stud.MissingBaselineCount++;
            if (!stud.Bl.Acad.ScoreCheck) stud.MissingBaselineCount++;
            if (!stud.CheckEwField.Detentions) stud.MissingBaselineCount++;
            if (!stud.CheckEwField.OfficeRefs) stud.MissingBaselineCount++;
            if (!stud.CheckEwField.Suspensions) stud.MissingBaselineCount++;
            if (!stud.Bl.Acad.HomeworkCompletionScoreCheck) stud.MissingBaselineCount++;
            if (stud.EwAttendReportPeriodNum == "") stud.MissingBaselineCount++;
            if (stud.EwBehavReportPeriodNum == "") stud.MissingBaselineCount++;
        }

        // Using any start and end dates recorded for the student, this calculates total time in the program.
        public static void CalculateTotalDaysSupported(Student stud)
        {
            if (!string.IsNullOrEmpty(stud.SupportDates.End3))
            {
                stud.SupportDates.Span3 = DateTime.Parse(stud.SupportDates.End3) - DateTime.Parse(stud.SupportDates.Start3);
                stud.SupportDates.Span2 = DateTime.Parse(stud.SupportDates.End2) - DateTime.Parse(stud.SupportDates.Start2);
                stud.SupportDates.Span1 = DateTime.Parse(stud.SupportDates.End1) - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days + stud.SupportDates.Span2.Days + stud.SupportDates.Span3.Days;
            }
            else if (!string.IsNullOrEmpty(stud.SupportDates.Start3))
            {
                stud.SupportDates.Span3 = TodayDate - DateTime.Parse(stud.SupportDates.Start3);
                stud.SupportDates.Span2 = DateTime.Parse(stud.SupportDates.End2) - DateTime.Parse(stud.SupportDates.Start2);
                stud.SupportDates.Span1 = DateTime.Parse(stud.SupportDates.End1) - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days + stud.SupportDates.Span2.Days + stud.SupportDates.Span3.Days;
            }
            else if (!string.IsNullOrEmpty(stud.SupportDates.End2))
            {
                stud.SupportDates.Span2 = DateTime.Parse(stud.SupportDates.End2) - DateTime.Parse(stud.SupportDates.Start2);
                stud.SupportDates.Span1 = DateTime.Parse(stud.SupportDates.End1) - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days + stud.SupportDates.Span2.Days;
            }
            else if (!string.IsNullOrEmpty(stud.SupportDates.Start2))
            {
                stud.SupportDates.Span2 = TodayDate - DateTime.Parse(stud.SupportDates.Start2);
                stud.SupportDates.Span1 = DateTime.Parse(stud.SupportDates.End1) - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days + stud.SupportDates.Span2.Days;
            }
            else if (!string.IsNullOrEmpty(stud.SupportDates.End1))
            {
                stud.SupportDates.Span1 = DateTime.Parse(stud.SupportDates.End1) - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days;
            }
            else
            {
                stud.SupportDates.Span1 = TodayDate - DateTime.Parse(stud.SupportDates.Start1);
                stud.TotalDays = stud.SupportDates.Span1.Days;
            }
        }

        // Sets bools indicating whether student has improvement in specific areas (relative to a baseline rate/score).
        public static void SetImprovementBools(Student stud)
        {
            stud.Improvement = new Improvement
            {
                Attend = stud.CheckEwField.Absences && stud.Bl.Attend.Rate < stud.Ytd.Attend.Rate,
                Deten = stud.CheckEwField.Detentions &&
                        stud.Bl.Behav.DetenRate >= stud.Ytd.Behav.DetenRate,
                OfficeRefs = stud.CheckEwField.OfficeRefs &&
                             stud.Bl.Behav.OfficeRate >= stud.Ytd.Behav.OfficeRate,
                Suspend = stud.CheckEwField.Suspensions &&
                          stud.Bl.Behav.SuspendRate >= stud.Ytd.Behav.SuspendRate,
                Acad = stud.Bl.Acad.ScoreCheck && stud.Bl.Acad.Score < stud.Mo.Acad.Score,
              
            };

            // Improvement Any = true if student has improved in at least one of the ABC areas
            stud.Improvement.Any = stud.Improvement.Acad || (stud.Improvement.Deten && stud.Improvement.OfficeRefs &&
                                  stud.Improvement.Suspend) || stud.Improvement.Attend;

            // Improvement All = true if student has improved in each of the ABC areas
            stud.Improvement.All = stud.Improvement.Acad && (stud.Improvement.Deten && stud.Improvement.OfficeRefs &&
                                  stud.Improvement.Suspend) && stud.Improvement.Attend;
        }

        // Calculate average minutes of support provided to youth per week
        public static void CalculateAvgMinPerWeek(Student stud)
        {
            stud.AvgIntvMin = stud.InterventionTotal != 0
                ? Math.Round((Convert.ToDouble(stud.InterventionTotal) / (Convert.ToDouble(stud.TotalDays) / 7)),
                    1)
                : 0;
        }


        // Calculate total intervention minutes including duplicates (one intervention can count towards several intervention categories).
        public static void CalculateDuplicatedIntvnMins(Student stud)
        {

            stud.Intvns.DuplicatedTotalMins = stud.Intvns.CareMin + stud.Intvns.ServMin + stud.Intvns.HighQualInSchoolMin +
                                               stud.Intvns.HighQualOutOfSchoolMin;
        }

        // Set rate of changes for baseline vs current ABC rates
        public static void SetRateChanges(Student stud)
        {

            stud.Mo.Change.AttendRate = stud.CheckEwField.Absences
                ? PercentChange(stud.Bl.Attend.Rate, stud.Mo.Attend.Rate)
                : 0;
            stud.Mo.Change.DetenRate = stud.CheckEwField.Detentions
                ? PercentChange(stud.Bl.Behav.DetenRate, stud.Mo.Behav.DetenRate)
                : 0;
            stud.Mo.Change.OfficeRate = stud.CheckEwField.OfficeRefs
                ? PercentChange(stud.Bl.Behav.OfficeRate, stud.Mo.Behav.OfficeRate)
                : 0;
            stud.Mo.Change.SuspendRate = stud.CheckEwField.Suspensions
                ? PercentChange(stud.Bl.Behav.SuspendRate, stud.Mo.Behav.SuspendRate)
                : 0;
            stud.Mo.Change.HomeworkScore = stud.Bl.Acad.HomeworkCompletionScoreCheck
                ? PercentChangeAcad(stud.Bl.Acad.HomeworkCompletionScore, stud.Mo.Acad.HomeworkCompletionScore)
                : 0;
            stud.Mo.Change.AcadScore = stud.Bl.Acad.ScoreCheck
                ? PercentChangeAcad((double) stud.Bl.Acad.Score, (double) stud.Mo.Acad.Score)
                : 0;

            stud.Ytd.Change.AttendRate = stud.CheckEwField.Absences
                ? PercentChange(stud.Bl.Attend.Rate, stud.Ytd.Attend.Rate)
                : 0;
            stud.Ytd.Change.DetenRate = stud.CheckEwField.Detentions
                ? PercentChange(stud.Bl.Behav.DetenRate, stud.Ytd.Behav.DetenRate)
                : 0;
            stud.Ytd.Change.OfficeRate = stud.CheckEwField.OfficeRefs
                ? PercentChange(stud.Bl.Behav.OfficeRate, stud.Ytd.Behav.OfficeRate)
                : 0;
            stud.Ytd.Change.SuspendRate = stud.CheckEwField.Suspensions
                ? PercentChange(stud.Bl.Behav.SuspendRate, stud.Ytd.Behav.SuspendRate)
                : 0;
            stud.Ytd.Change.HomeworkScore = stud.Bl.Acad.HomeworkCompletionScoreCheck
                ? PercentChangeAcad(stud.Bl.Acad.HomeworkCompletionScore, stud.Mo.Acad.HomeworkCompletionScore)
                : 0;
            stud.Ytd.Change.AcadScore = stud.Bl.Acad.ScoreCheck
                ? PercentChangeAcad((double) stud.Bl.Acad.Score, (double) stud.Mo.Acad.Score)
                : 0;
        }

       

        private static double PercentChange(double baseline, double current)
        {
            if (baseline == 0)
                return 0;

            var change = (double.IsNaN(current) ? 0 : current) - baseline;
            return Math.Round((Math.Round(change,3) / Math.Round(baseline,3) ), 2);
        }


        private static double PercentChangeAcad(double baseline, double current)
        {
            if (baseline == 0)
                return 0;

            var change = current - baseline;
            return Math.Round((change / baseline), 2);
        }

    }
}
