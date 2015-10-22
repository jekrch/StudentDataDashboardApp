using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Operations;

namespace PFdata.Dashboard.Data
{

    // !!!!!!!! PLEASE READ

    // The xml report that I had to base this on was formatted poorly, with each
    // field nested within the field that came before it. This was not something 
    // that I could have changed, nor did I have access to the system that produced
    // the xml reports. The following is how I made it work with the xml schema 
    // I was given.

    public static class StudentListGenerator
    {
        public static List<Student> StudentList = new List<Student>();

        private static List<ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1> _sortedListA;
        private static List<ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1> _sortedListB;
        private static List<ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1> _sortedListC;
        private static List<ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1> _sortedListI;

        // Creates student list from deserialized xml object
        public static Task<List<Student>> CreateStudentListAsync(string filePath)
        {
            return Task.Run(() => CreateStudentList(filePath));
        }

        // Main workflow for creating list of student objects from deserialized XML report
        public static List<Student> CreateStudentList(string filePath)
        {
  
            String xData = File.ReadAllText(filePath);
            var x = new XmlSerializer(typeof (Report));


            Report dataConverted = (Report)x.Deserialize(new StringReader(xData));
    

            var studentTotal =
                dataConverted.Subreport1.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection.Length;

            // Saving the month of the report 
            var reportMonth = dataConverted.Subreport1.Report.Tablix1.Textbox50;
            reportMonth = reportMonth.Substring(0, reportMonth.IndexOf("-"));

            Application.Current.Properties["reportMonth"] = reportMonth;

            // Switch the student and member names so that the list can be sorted by student name 
            // (again, the XML report nests each field within its preceding field). 

            SwitchStudentAndMemberNames(dataConverted);

            _sortedListA =
                dataConverted.Subreport1.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection.OrderBy(
                    si => si.MemberName2.MemberName2).ToList();
            _sortedListB =
                dataConverted.Subreport4.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection.OrderBy(
                    si => si.MemberName2.MemberName2).ToList();
            _sortedListC =
                dataConverted.Subreport3.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection.OrderBy(
                    si => si.MemberName2.MemberName2).ToList();
            _sortedListI =
                dataConverted.Subreport2.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection.OrderBy(
                    si => si.MemberName2.MemberName2).ToList();

            ExtractStudentFields(studentTotal);


            foreach (Student stud in StudentList)
            {

                try
                {
                    StudentDataCalc.CalculateTotalDaysSupported(stud);
                }
                catch
                {
                    stud.TotalDays = 0;
                }

                // Calculate total intervention minutes including duplicates (one intervention can count towards several intervention categories).
                StudentDataCalc.CalculateDuplicatedIntvnMins(stud);

                // Calculate average minutes of support provided to youth per week
                StudentDataCalc.CalculateAvgMinPerWeek(stud);

                // Set bools indicating improvement
                StudentDataCalc.SetImprovementBools(stud);

                // Calculate how many missing baseline fields each student has
                StudentDataCalc.CalculateMissingBaselineTotal(stud);

            }

            return StudentList;
        }

        private static void SwitchStudentAndMemberNames(Report dataConverted)
        {
            foreach (
                var a in
                    dataConverted.Subreport1.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection)
            {
                var memberName = a.MemberName2.MemberName2;
                a.MemberName2.MemberName2 =
                    a.MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                        .StudentName2;

                a.MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.StudentName2
                    = memberName;
            }

            foreach (
                var a in
                    dataConverted.Subreport3.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection)
            {
                var memberName = a.MemberName2.MemberName2;
                a.MemberName2.MemberName2 = a.MemberName2.siteName2.StudentName2.StudentName2;

                a.MemberName2.siteName2.StudentName2.StudentName2 = memberName;
            }

            foreach (
                var a in
                    dataConverted.Subreport4.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection)
            {
                var memberName = a.MemberName2.MemberName2;

                a.MemberName2.MemberName2 = a.MemberName2.siteName2.StudentName2.StudentName2;

                a.MemberName2.siteName2.StudentName2.StudentName2 = memberName;
            }

            foreach (
                var a in
                    dataConverted.Subreport2.Report.Tablix1.MN_PromiseFellows_StudentID1_Collection)
            {
                var memberName = a.MemberName2.MemberName2;

                a.MemberName2.MemberName2 = a.MemberName2.siteName2.StudentName2.StudentName2;
                a.MemberName2.siteName2.StudentName2.StudentName2 = memberName;
            }
        }

        // This extracts data from deserialized objects and enters them into appropriate fields for 
        // each student object in the new list
        private static void ExtractStudentFields(int studentTotal)
        {

            for (int i = 0; i < studentTotal; i++)
            {
   
                var stud = new Student();


                stud.Profile.Fellow = _sortedListB[i].MemberName2.siteName2.StudentName2.StudentName2 ?? "null";

                stud.Profile.Site = _sortedListA[i].MemberName2.siteName2.siteName2 ?? "null";

                stud.Profile.Name = _sortedListA[i].MemberName2.MemberName2 ?? "null";

                stud.Profile.Status = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.MN_MathStudentStatusName2 ?? "null";

                stud.Grade = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.MN_MathGradeName2 ?? "null";

                stud.Program = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.programName2 ?? "null";

                stud.SupportDates.Start1 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.StartDate4 ?? "null";

                stud.SupportDates.End1 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.EndDate2 ?? "null";

                stud.SupportDates.Start2 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox817 ?? "null";

                stud.SupportDates.End2 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox11 ?? "null";

                stud.SupportDates.Start3 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox8 ?? "null";

                stud.SupportDates.End3 = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox827 ?? "null";

                stud.Intvns.Needed.AcadReading = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox45 ?? "null";

                stud.Intvns.Needed.AcadMath = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox51 ?? "null";

                stud.Intvns.Needed.AcadOther = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox52 ?? "null";

                stud.Intvns.Needed.Behav = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox53 ?? "null";

                stud.Intvns.Needed.Attend = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.Textbox55 ?? "null";
                
                stud.CheckEwField.Absences = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AbsencesSpecified;

                stud.CheckEwField.Tardies = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox32Specified;

                stud.CheckEwField.OfficeRefs = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.EarlyWarn_OfficeVisitsSpecified;

                stud.CheckEwField.Suspensions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.EarlyWarn_DaysSuspendedSpecified;

                stud.CheckEwField.Detentions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .EarlyWarn_DetentionsSpecified;

                stud.Bl.Attend.Absences = Convert.ToDouble(
                    _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                        .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                        .MN_MathStudentStatusName2
                        .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                        .Textbox52.Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_Absences);

                stud.Bl.Attend.Rate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                            .AttendanceRate_BaseLine), 4);

                stud.Bl.Attend.Tardies = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox32;

                stud.Bl.Attend.OnTimeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                            .Textbox10), 4);

                stud.EwAttendReportPeriodNum = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51.Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .EarlyWarn_AttendanceRPNumber;

                stud.Mo.InstructPeriods = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51.Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_NumberOfInstructionalPeriods;
              
                stud.Mo.Attend.Absences = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_NumberAbsent;

                stud.Mo.Attend.Unknowns = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .MONTH_Attendance_Reason_PeriodUnknown;

                stud.Mo.Attend.Rate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                            .EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                            .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                            .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_Month.AttendanceRate_Month), 4);

                stud.Mo.Attend.Tardies = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.MONTH_Attendance_Reason_PeriodTardy;

                stud.Mo.Attend.OnTimeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                            .EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                            .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                            .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_Month.MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month
                            .OnTimeRate_Month), 4);

                stud.Ytd.InstructDays = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                    .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                    .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                    .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                    .EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .AttendanceRate_Month.MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month
                    .MONTH_Intervention_Instances.MONTH_Intervention_Minutes
                    .YTD_NumberOfInstructionalDays.YTD_NumberOfInstructionalDays;

                stud.TotalInstructDays = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51.Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown.AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_NumberOfInstructionalDays.YTD_NumberOfInstructionalDays;

                stud.Ytd.InstructPeriods = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51.Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown.AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_NumberOfInstructionalDays.YTD_NumberOfInstructionalPeriods
                    .YTD_NumberOfInstructionalPeriods;

                stud.Ytd.Attend.Absences = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_NumberOfInstructionalDays
                    .YTD_NumberOfInstructionalPeriods
                    .YTD_Attendance_NumberAbsent.YTD_Attendance_NumberAbsent;

                stud.Ytd.Attend.Unknowns = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_NumberOfInstructionalDays
                    .YTD_NumberOfInstructionalPeriods
                    .YTD_Attendance_NumberAbsent.YTD_Attendance_Reason_PeriodUnknown
                    .YTD_Attendance_Reason_PeriodUnknown;

                stud.Ytd.Attend.Rate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                            .EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                            .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                            .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_Month.MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month
                            .MONTH_Intervention_Instances.MONTH_Intervention_Minutes
                            .YTD_NumberOfInstructionalDays.YTD_NumberOfInstructionalPeriods
                            .YTD_Attendance_NumberAbsent.YTD_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_YTD
                            .AttendanceRate_YTD), 4);

                stud.Ytd.Attend.Tardies = _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                    .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2.MN_MathStudentStatusName2
                    .StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827.Textbox45.Textbox51
                    .Textbox52
                    .Textbox53.Textbox55.EarlyWarn_Absences.EarlyWarn_AttendanceType
                    .EarlyWarn_AttendanceDaysInRP.EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine
                    .Textbox32.Textbox10.EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                    .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                    .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                    .AttendanceRate_Month
                    .MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_NumberOfInstructionalDays
                    .YTD_NumberOfInstructionalPeriods
                    .YTD_Attendance_NumberAbsent.YTD_Attendance_Reason_PeriodUnknown.AttendanceRate_YTD
                    .YTD_Attendance_Reason_PeriodTardy.YTD_Attendance_Reason_PeriodTardy;

                stud.Ytd.Attend.OnTimeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListA[i].MemberName2.siteName2.MN_PromiseFellows_StudentID_Collection
                            .MN_PromiseFellows_StudentID.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_Absences
                            .EarlyWarn_AttendanceType.EarlyWarn_AttendanceDaysInRP
                            .EarlyWarn_AttendancePeriodsInDay.AttendanceRate_BaseLine.Textbox32.Textbox10
                            .EarlyWarn_AttendanceFrequency.EarlyWarn_AttendanceRPNumber
                            .MONTH_NumberOfInstructionalDays.MONTH_NumberOfInstructionalPeriods
                            .MONTH_Attendance_NumberAbsent.MONTH_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_Month.MONTH_Attendance_Reason_PeriodTardy.OnTimeRate_Month
                            .MONTH_Intervention_Instances.MONTH_Intervention_Minutes
                            .YTD_NumberOfInstructionalDays.YTD_NumberOfInstructionalPeriods
                            .YTD_Attendance_NumberAbsent.YTD_Attendance_Reason_PeriodUnknown
                            .AttendanceRate_YTD
                            .YTD_Attendance_Reason_PeriodTardy.Textbox13.Textbox13), 4);
      
                stud.Bl.Behav.OfficeRefs = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.EarlyWarn_OfficeVisits;

                stud.Bl.Behav.OfficeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .Textbox29), 4);

                stud.Bl.Behav.Detentions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .EarlyWarn_Detentions;

                stud.Bl.Behav.DetenRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.Textbox30), 4);

                stud.Bl.Behav.Suspensions = Convert.ToInt16(
                    _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                        .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                        .Textbox827
                        .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45
                        .Textbox51
                        .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                        .Textbox30.EarlyWarn_DaysSuspended.EarlyWarn_DaysSuspended);

                stud.Bl.Behav.SuspendRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32.Textbox32), 4);
           
                stud.EwBehavReportPeriodNum = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorRPNumber;

                stud.Mo.InstructDays = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_IntructionalDays;

                stud.Mo.Behav.OfficeRefs = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.MONTH_PrincipleOfficeCount;

                stud.Mo.Behav.OfficeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83.Textbox83), 4);

                stud.Mo.Behav.Detentions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.Textbox83.MONTH_DetentionCount.MONTH_DetentionCount;

                stud.Mo.Behav.DetenRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83
                            .MONTH_DetentionCount
                            .Textbox117.Textbox117), 4);

                stud.Mo.Behav.Suspensions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.Textbox83.MONTH_DetentionCount.Textbox117
                    .MONTH_Behavior_SuspensionCount.MONTH_Behavior_SuspensionCount;

                stud.Mo.Behav.SuspendRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83
                            .MONTH_DetentionCount
                            .Textbox117.MONTH_Behavior_SuspensionCount.Textbox109.Textbox109), 4);
               
                stud.Ytd.Behav.OfficeRefs = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.Textbox83.MONTH_DetentionCount.Textbox117
                    .MONTH_Behavior_SuspensionCount.Textbox109.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount
                    .YTD_PrincipleOfficeCount;

                stud.Ytd.Behav.OfficeRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83
                            .MONTH_DetentionCount
                            .Textbox117.MONTH_Behavior_SuspensionCount.Textbox109
                            .MONTH_Intervention_Instances
                            .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount
                            .Textbox77
                            .Textbox77), 4);

                stud.Ytd.Behav.Detentions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.Textbox83.MONTH_DetentionCount.Textbox117
                    .MONTH_Behavior_SuspensionCount.Textbox109.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount.Textbox77
                    .YTD_DetentionCount.YTD_DetentionCount;

                stud.Ytd.Behav.DetenRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83
                            .MONTH_DetentionCount
                            .Textbox117.MONTH_Behavior_SuspensionCount.Textbox109
                            .MONTH_Intervention_Instances
                            .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount
                            .Textbox77
                            .YTD_DetentionCount.Textbox115.Textbox115), 4);

                stud.Ytd.Behav.Suspensions = _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits.Textbox29.EarlyWarn_Detentions
                    .Textbox30.EarlyWarn_DaysSuspended.Textbox32.EarlyWarn_BehaviorFrequency
                    .EarlyWarn_BehaviorRPNumber.EarlyWarn_BehaviorDaysInRP.MONTH_IntructionalDays
                    .MONTH_PrincipleOfficeCount.Textbox83.MONTH_DetentionCount.Textbox117
                    .MONTH_Behavior_SuspensionCount.Textbox109.MONTH_Intervention_Instances
                    .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount.Textbox77
                    .YTD_DetentionCount.Textbox115.YTD_Behavior_SuspensionCount.YTD_Behavior_SuspensionCount;

                stud.Ytd.Behav.SuspendRate = Math.Round(
                    Convert.ToDouble(
                        _sortedListB[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                            .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8
                            .Textbox827.MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID
                            .Textbox45.Textbox51.Textbox52.Textbox53.Textbox55.EarlyWarn_OfficeVisits
                            .Textbox29
                            .EarlyWarn_Detentions.Textbox30.EarlyWarn_DaysSuspended.Textbox32
                            .EarlyWarn_BehaviorFrequency.EarlyWarn_BehaviorRPNumber
                            .EarlyWarn_BehaviorDaysInRP
                            .MONTH_IntructionalDays.MONTH_PrincipleOfficeCount.Textbox83
                            .MONTH_DetentionCount
                            .Textbox117.MONTH_Behavior_SuspensionCount.Textbox109
                            .MONTH_Intervention_Instances
                            .MONTH_Intervention_Minutes.YTD_IntructionalDays.YTD_PrincipleOfficeCount
                            .Textbox77
                            .YTD_DetentionCount.Textbox115.YTD_Behavior_SuspensionCount.Textbox107
                            .Textbox107),
                    4);
              
                stud.Bl.Acad.Score = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore3;

                stud.Bl.Acad.ScoreCheck = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3
                    .EarlyWarn_AcademicScore3Specified;

                stud.Bl.Acad.ScoreType = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_AcademicScore4;

                stud.Bl.Acad.HomeworkCompletionScore = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.EarlyWarn_HomeworkCompletionScore;

                stud.Bl.Acad.HomeworkCompletionScoreCheck = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.EarlyWarn_HomeworkCompletionScoreSpecified;
             
                stud.Mo.Acad.Score = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_Academic_AcademicScore3;

                stud.Mo.Acad.ScoreCheck = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_Academic_AcademicScore3Specified;

                stud.Mo.Acad.ScoreDate = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3
                    .Updated_DailyAcademicScoreDate3;

                stud.Mo.Acad.HomeworkCompletionScore = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3
                    .Updated_Academic_AcademicScore4.Updated_AcademicScore2TypeName2
                    .Updated_DailyAcademicScoreDate4.Total_Intervention_Instances2
                    .Total_Intervention_Minutes2
                    .HomeworkCompletionScore.HomeworkCompletionScore;

                stud.Mo.Acad.HomeworkCompletionScoreCheck = _sortedListC[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3
                    .Updated_Academic_AcademicScore4.Updated_AcademicScore2TypeName2
                    .Updated_DailyAcademicScoreDate4.Total_Intervention_Instances2
                    .Total_Intervention_Minutes2
                    .HomeworkCompletionScore.HomeworkCompletionScoreSpecified;

                stud.InterventionTotal = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent;
              
                stud.Intvns.ServNum = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox141.OutcomeName2.Textbox2.COUNT_IsTypeServiceAndOrLeadership;

                stud.Intvns.ServMin = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox141.Textbox4.Textbox6.MINUTES_IsTypeServiceAndOrLeadership;

                stud.Intvns.CareNum = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox125.OutcomeName3.Textbox7.COUNT_IsTypeCaringAdult;

                stud.Intvns.CareMin = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox125.Textbox9.Textbox12.MINUTES_IsTypeCaringAdult;

                stud.Intvns.HighQualTotalNum = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox127.OutcomeName4.Textbox13.COUNT_IsTypeHighQualitySupport;

                stud.Intvns.HighQualTotalMin = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox127.Textbox19.Textbox17.MINUTES_IsTypeHighQualitySupport;

                stud.Intvns.HighQualInSchoolNum = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox129.OutcomeName7.Textbox20.COUNT_In_School_Time;

                stud.Intvns.HighQualInSchoolMin = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox129.Textbox39.Textbox21.MINUTES_In_School_Time;

                stud.Intvns.HighQualOutOfSchoolNum = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox131.OutcomeName8.Textbox22.COUNT_Out_Of_School_Time;

                stud.Intvns.HighQualOutOfSchoolMin = _sortedListI[i].MemberName2.siteName2.StudentName2.MN_MathGradeName2.programName2
                    .MN_MathStudentStatusName2.StartDate4.EndDate2.Textbox817.Textbox11.Textbox8.Textbox827
                    .MN_PromiseFellows_StudentID_Collection.MN_PromiseFellows_StudentID.Textbox45.Textbox51
                    .Textbox52.Textbox53.Textbox55.EarlyWarn_AcademicScore3.EarlyWarn_AcademicScore4
                    .EarlyWarn_HomeworkCompletionScore.Updated_Academic_AcademicScore3
                    .Updated_AcademicScore1TypeName2.Updated_DailyAcademicScoreDate3.HomeworkCompletionScore
                    .HomeworkCompletionDate.COUNT_TotalInterventionForThisStudent
                    .MINUTES_TotalInterventionForThisStudent
                    .Textbox114.Textbox131.Textbox35.Textbox23.MINUTES_Out_Of_School_Time;

                StudentList.Add(stud); 
            }
        }
    }
}

