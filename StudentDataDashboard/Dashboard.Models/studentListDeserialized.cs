using System;
using System.Xml.Serialization;

namespace PFdata.Dashboard.Models
{

    /// !!!!!!!!! PLEASE READ:
    /// 
    /// The XML report schema on which this class is based has a highly unusual format, which could not
    /// be changed for this project. This file was produced using Visual Studio's automated class creation
    /// feature - see edit > paste special > paste as classes
 
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    [XmlRoot(Namespace = "PF_MemberCombo_Main", IsNullable = false)]
    public partial class Report
    {
        /// <remarks/>
        public ReportSubreport1 Subreport1 { get; set; }

        /// <remarks/>
        public ReportSubreport4 Subreport4 { get; set; }

        /// <remarks/>
        public ReportSubreport3 Subreport3 { get; set; }

        /// <remarks/>
        public ReportSubreport5 Subreport5 { get; set; }

        /// <remarks/>
        public ReportSubreport6 Subreport6 { get; set; }

        /// <remarks/>
        public ReportSubreport2 Subreport2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1
    {
        /// <remarks/>
        public ReportSubreport1Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1Report
    {
        /// <remarks/>
        public ReportSubreport1ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox50 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            Textbox45 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            EarlyWarn_Absences { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            EarlyWarn_AttendanceType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_Absences { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AbsencesSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            EarlyWarn_AttendanceDaysInRP { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceType { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            EarlyWarn_AttendancePeriodsInDay { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendanceDaysInRP { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            AttendanceRate_BaseLine { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendancePeriodsInDay { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AttendancePeriodsInDaySpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            Textbox32 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_BaseLine { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_BaseLineSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            Textbox10 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Textbox32 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            EarlyWarn_AttendanceFrequency { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox10 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox10Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            EarlyWarn_AttendanceRPNumber { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceFrequency { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
    {
        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            MONTH_NumberOfInstructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceRPNumber { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
    {
        /// <remarks/>
        public Item MONTH_NumberOfInstructionalPeriods { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_NumberOfInstructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item
    {
        /// <remarks/>
        public Item1 MONTH_Attendance_NumberAbsent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MONTH_NumberOfInstructionalPeriods { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item1
    {
        /// <remarks/>
        public Item2 MONTH_Attendance_Reason_PeriodUnknown { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_NumberAbsent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item2
    {
        /// <remarks/>
        public Item3 AttendanceRate_Month { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodUnknown { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item3
    {
        /// <remarks/>
        public Item4 MONTH_Attendance_Reason_PeriodTardy { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_Month { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_MonthSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item4
    {
        /// <remarks/>
        public Item5 OnTimeRate_Month { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodTardy { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item5
    {
        /// <remarks/>
        public Item6 MONTH_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal OnTimeRate_Month { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item6
    {
        /// <remarks/>
        public Item7 MONTH_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item7
    {
        /// <remarks/>
        public Item8 YTD_NumberOfInstructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item8
    {
        /// <remarks/>
        public Item9 YTD_NumberOfInstructionalPeriods { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_NumberOfInstructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item9
    {
        /// <remarks/>
        public Item10 YTD_Attendance_NumberAbsent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string YTD_NumberOfInstructionalPeriods { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item10
    {
        /// <remarks/>
        public Item11 YTD_Attendance_Reason_PeriodUnknown { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_NumberAbsent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item11
    {
        /// <remarks/>
        public Item12 AttendanceRate_YTD { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodUnknown { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item12
    {
        /// <remarks/>
        public Item13 YTD_Attendance_Reason_PeriodTardy { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_YTD { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_YTDSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item13
    {
        /// <remarks/>
        public Item14 Textbox13 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodTardy { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item14
    {
        /// <remarks/>
        public Item15 YTD_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox13 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item15
    {
        /// <remarks/>
        public Item16 YTD_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item16
    {
        /// <remarks/>
        public Item17 Textbox141 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item17
    {
        /// <remarks/>
        public Item18 AttendanceName_Collection { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item18
    {
        /// <remarks/>
        public Item19 AttendanceName { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item19
    {
        /// <remarks/>
        public Item20 OutcomeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item20
    {
        /// <remarks/>
        public Item21 Textbox930 { get; set; }

        /// <remarks/>
        public Item22 Textbox933 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item21
    {
        /// <remarks/>
        [XmlAttribute()]
        public int attendance_Interventions_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item22
    {
        /// <remarks/>
        [XmlAttribute()]
        public int attendance_Interventions_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4
    {
        /// <remarks/>
        public ReportSubreport4Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4Report
    {
        /// <remarks/>
        public ReportSubreport4ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox120 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2 {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            EarlyWarn_OfficeVisits { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            Textbox29 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_OfficeVisits { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_OfficeVisitsSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            EarlyWarn_Detentions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox29 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            Textbox30 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_Detentions { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DetentionsSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            EarlyWarn_DaysSuspended { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox30 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            Textbox32 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_DaysSuspended { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DaysSuspendedSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            EarlyWarn_BehaviorFrequency { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox32 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            EarlyWarn_BehaviorRPNumber { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorFrequency { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            EarlyWarn_BehaviorDaysInRP { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorRPNumber { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            MONTH_IntructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_BehaviorDaysInRP { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
    {
        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            MONTH_PrincipleOfficeCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_IntructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
    {
        /// <remarks/>
        public Item23 Textbox83 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_PrincipleOfficeCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item23
    {
        /// <remarks/>
        public Item24 MONTH_DetentionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox83 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item24
    {
        /// <remarks/>
        public Item25 Textbox117 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_DetentionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item25
    {
        /// <remarks/>
        public Item26 MONTH_Behavior_SuspensionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox117 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item26
    {
        /// <remarks/>
        public Item27 Textbox109 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Behavior_SuspensionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item27
    {
        /// <remarks/>
        public Item28 MONTH_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox109 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item28
    {
        /// <remarks/>
        public Item29 MONTH_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item29
    {
        /// <remarks/>
        public Item30 YTD_IntructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item30
    {
        /// <remarks/>
        public Item31 YTD_PrincipleOfficeCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_IntructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item31
    {
        /// <remarks/>
        public Item32 Textbox77 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_PrincipleOfficeCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item32
    {
        /// <remarks/>
        public Item33 YTD_DetentionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox77 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item33
    {
        /// <remarks/>
        public Item34 Textbox115 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_DetentionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item34
    {
        /// <remarks/>
        public Item35 YTD_Behavior_SuspensionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox115 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item35
    {
        /// <remarks/>
        public Item36 Textbox107 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Behavior_SuspensionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item36
    {
        /// <remarks/>
        public Item37 YTD_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox107 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item37
    {
        /// <remarks/>
        public Item38 YTD_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item38
    {
        /// <remarks/>
        public Item39 Textbox141 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item39
    {
        /// <remarks/>
        [XmlArrayItem("BehaviorName", IsNullable = false)]
        public Item40[] BehaviorName_Collection { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item40
    {
        /// <remarks/>
        public Item41 OutcomeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item41
    {
        /// <remarks/>
        public Item42 Textbox930 { get; set; }

        /// <remarks/>
        public Item43 Textbox933 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string OutcomeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item42
    {
        /// <remarks/>
        [XmlAttribute()]
        public int behavior_Interventions_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item43
    {
        /// <remarks/>
        [XmlAttribute()]
        public int behavior_Interventions_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3
    {
        /// <remarks/>
        public ReportSubreport3Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3Report
    {
        /// <remarks/>
        public ReportSubreport3ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2 {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            EarlyWarn_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            EarlyWarn_AcademicScore4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AcademicScore3Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            EarlyWarn_HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AcademicScore4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            Updated_Academic_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_HomeworkCompletionScoreSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            Updated_AcademicScore1TypeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Updated_Academic_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Updated_Academic_AcademicScore3Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            Updated_DailyAcademicScoreDate3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_AcademicScore1TypeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
    {
        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3Updated_Academic_AcademicScor
            Updated_Academic_AcademicScore4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_DailyAcademicScoreDate3 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3Updated_Academic_AcademicScor
    {
        /// <remarks/>
        public Item45 Updated_AcademicScore2TypeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item45
    {
        /// <remarks/>
        public Item46 Updated_DailyAcademicScoreDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item46
    {
        /// <remarks/>
        public Item47 Total_Intervention_Instances2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item47
    {
        /// <remarks/>
        public Item48 Total_Intervention_Minutes2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Total_Intervention_Instances2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item48
    {
        /// <remarks/>
        public Item49 HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Total_Intervention_Minutes2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item49
    {
        /// <remarks/>
        public Item50 HomeworkCompletionDate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionScoreSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item50
    {
        /// <remarks/>
        public Item51 Textbox141 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime HomeworkCompletionDate { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionDateSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item51
    {
        /// <remarks/>
        [XmlArrayItem("OutcomeName1", IsNullable = false)]
        public Item52[] OutcomeName1_Collection { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item52
    {
        /// <remarks/>
        public Item53 OutcomeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item53
    {
        /// <remarks/>
        public Item54 Textbox930 { get; set; }

        /// <remarks/>
        public Item55 Textbox933 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string OutcomeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item54
    {
        /// <remarks/>
        [XmlAttribute()]
        public int academic_Interventions_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item55
    {
        /// <remarks/>
        [XmlAttribute()]
        public int academic_Interventions_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5
    {
        /// <remarks/>
        public ReportSubreport5Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5Report
    {
        /// <remarks/>
        public ReportSubreport5ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox50 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            Textbox45 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            EarlyWarn_Absences { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            EarlyWarn_AttendanceType { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_Absences { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AbsencesSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            EarlyWarn_AttendanceDaysInRP { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceType { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            EarlyWarn_AttendancePeriodsInDay { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendanceDaysInRP { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            AttendanceRate_BaseLine { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendancePeriodsInDay { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AttendancePeriodsInDaySpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            Textbox32 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_BaseLine { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_BaseLineSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            Textbox10 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int Textbox32 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            EarlyWarn_AttendanceFrequency { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox10 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox10Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            EarlyWarn_AttendanceRPNumber { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceFrequency { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
    {
        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            MONTH_NumberOfInstructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceRPNumber { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
    {
        /// <remarks/>
        public Item57 MONTH_NumberOfInstructionalPeriods { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_NumberOfInstructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item57
    {
        /// <remarks/>
        public Item58 MONTH_Attendance_NumberAbsent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MONTH_NumberOfInstructionalPeriods { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item58
    {
        /// <remarks/>
        public Item59 MONTH_Attendance_Reason_PeriodUnknown { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_NumberAbsent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item59
    {
        /// <remarks/>
        public Item60 AttendanceRate_Month { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodUnknown { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item60
    {
        /// <remarks/>
        public Item61 MONTH_Attendance_Reason_PeriodTardy { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_Month { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_MonthSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item61
    {
        /// <remarks/>
        public Item62 OnTimeRate_Month { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodTardy { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item62
    {
        /// <remarks/>
        public Item63 MONTH_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal OnTimeRate_Month { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item63
    {
        /// <remarks/>
        public Item64 MONTH_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item64
    {
        /// <remarks/>
        public Item65 YTD_NumberOfInstructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item65
    {
        /// <remarks/>
        public Item66 YTD_NumberOfInstructionalPeriods { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_NumberOfInstructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item66
    {
        /// <remarks/>
        public Item67 YTD_Attendance_NumberAbsent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string YTD_NumberOfInstructionalPeriods { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item67
    {
        /// <remarks/>
        public Item68 YTD_Attendance_Reason_PeriodUnknown { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_NumberAbsent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item68
    {
        /// <remarks/>
        public Item69 AttendanceRate_YTD { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodUnknown { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item69
    {
        /// <remarks/>
        public Item70 YTD_Attendance_Reason_PeriodTardy { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_YTD { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_YTDSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item70
    {
        /// <remarks/>
        public Item71 Textbox13 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodTardy { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item71
    {
        /// <remarks/>
        public Item72 COUNT_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox13 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item72
    {
        /// <remarks/>
        public Item73 MINUTES_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item73
    {
        /// <remarks/>
        public Item74 Textbox116 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudentSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item74
    {
        /// <remarks/>
        public Item75 Textbox141 { get; set; }

        /// <remarks/>
        public Item78 Textbox125 { get; set; }

        /// <remarks/>
        public Item81 Textbox127 { get; set; }

        /// <remarks/>
        public Item84 Textbox129 { get; set; }

        /// <remarks/>
        public Item87 Textbox131 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item75
    {
        /// <remarks/>
        public Item76 OutcomeName2 { get; set; }

        /// <remarks/>
        public Item77 Textbox6 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item76
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item77
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item78
    {
        /// <remarks/>
        public Item79 OutcomeName3 { get; set; }

        /// <remarks/>
        public Item80 Textbox19 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item79
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item80
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item81
    {
        /// <remarks/>
        public Item82 OutcomeName4 { get; set; }

        /// <remarks/>
        public Item83 Textbox28 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item82
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item83
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item84
    {
        /// <remarks/>
        public Item85 OutcomeName7 { get; set; }

        /// <remarks/>
        public Item86 Textbox39 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item85
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item86
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item87
    {
        /// <remarks/>
        public Item88 OutcomeName8 { get; set; }

        /// <remarks/>
        public Item89 Textbox35 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item88
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item89
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6
    {
        /// <remarks/>
        public ReportSubreport6Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6Report
    {
        /// <remarks/>
        public ReportSubreport6ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox120 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2 {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            EarlyWarn_OfficeVisits { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            Textbox29 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_OfficeVisits { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_OfficeVisitsSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            EarlyWarn_Detentions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox29 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            Textbox30 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_Detentions { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DetentionsSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            EarlyWarn_DaysSuspended { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox30 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            Textbox32 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_DaysSuspended { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DaysSuspendedSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            EarlyWarn_BehaviorFrequency { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox32 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            EarlyWarn_BehaviorRPNumber { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorFrequency { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            EarlyWarn_BehaviorDaysInRP { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorRPNumber { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            MONTH_IntructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_BehaviorDaysInRP { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
    {
        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            MONTH_PrincipleOfficeCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_IntructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
    {
        /// <remarks/>
        public Item90 Textbox83 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_PrincipleOfficeCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item90
    {
        /// <remarks/>
        public Item91 MONTH_DetentionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox83 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item91
    {
        /// <remarks/>
        public Item92 Textbox117 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_DetentionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item92
    {
        /// <remarks/>
        public Item93 MONTH_Behavior_SuspensionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox117 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item93
    {
        /// <remarks/>
        public Item94 Textbox109 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Behavior_SuspensionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item94
    {
        /// <remarks/>
        public Item95 MONTH_Intervention_Instances { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox109 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item95
    {
        /// <remarks/>
        public Item96 MONTH_Intervention_Minutes { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item96
    {
        /// <remarks/>
        public Item97 YTD_IntructionalDays { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item97
    {
        /// <remarks/>
        public Item98 YTD_PrincipleOfficeCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_IntructionalDays { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item98
    {
        /// <remarks/>
        public Item99 Textbox77 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_PrincipleOfficeCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item99
    {
        /// <remarks/>
        public Item100 YTD_DetentionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox77 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item100
    {
        /// <remarks/>
        public Item101 Textbox115 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_DetentionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item101
    {
        /// <remarks/>
        public Item102 YTD_Behavior_SuspensionCount { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox115 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item102
    {
        /// <remarks/>
        public Item103 Textbox107 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Behavior_SuspensionCount { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item103
    {
        /// <remarks/>
        public Item104 COUNT_TotalInterventionForThisStudent2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox107 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item104
    {
        /// <remarks/>
        public Item105 MINUTES_TotalInterventionForThisStudent2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item105
    {
        /// <remarks/>
        public Item106 Textbox118 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent2 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudent2Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item106
    {
        /// <remarks/>
        public Item107 Textbox141 { get; set; }

        /// <remarks/>
        public Item110 Textbox125 { get; set; }

        /// <remarks/>
        public Item113 Textbox127 { get; set; }

        /// <remarks/>
        public Item116 Textbox129 { get; set; }

        /// <remarks/>
        public Item119 Textbox131 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item107
    {
        /// <remarks/>
        public Item108 OutcomeName2 { get; set; }

        /// <remarks/>
        public Item109 Textbox10 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item108
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item109
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item110
    {
        /// <remarks/>
        public Item111 OutcomeName3 { get; set; }

        /// <remarks/>
        public Item112 Textbox19 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item111
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item112
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item113
    {
        /// <remarks/>
        public Item114 OutcomeName4 { get; set; }

        /// <remarks/>
        public Item115 Textbox34 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item114
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item115
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item116
    {
        /// <remarks/>
        public Item117 OutcomeName7 { get; set; }

        /// <remarks/>
        public Item118 Textbox39 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item117
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item118
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item119
    {
        /// <remarks/>
        public Item120 OutcomeName8 { get; set; }

        /// <remarks/>
        public Item121 Textbox35 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item120
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item121
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2
    {
        /// <remarks/>
        public ReportSubreport2Report Report { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2Report
    {
        /// <remarks/>
        public ReportSubreport2ReportTablix1 Tablix1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1
    {
        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection {
            get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1
    {
        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {
        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {
        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2 {
            get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            EarlyWarn_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            EarlyWarn_AcademicScore4 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AcademicScore3Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            EarlyWarn_HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AcademicScore4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            Updated_Academic_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_HomeworkCompletionScoreSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            Updated_AcademicScore1TypeName2 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Updated_Academic_AcademicScore3 { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool Updated_Academic_AcademicScore3Specified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            Updated_DailyAcademicScoreDate3 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_AcademicScore1TypeName2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScore
            HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_DailyAcademicScoreDate3 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScore
    {
        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScoreHomewo
            HomeworkCompletionDate { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int HomeworkCompletionScore { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionScoreSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScoreHomewo
    {
        /// <remarks/>
        public Item122 COUNT_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime HomeworkCompletionDate { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionDateSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item122
    {
        /// <remarks/>
        public Item123 MINUTES_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item123
    {
        /// <remarks/>
        public Item124 Textbox114 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudentSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item124
    {
        /// <remarks/>
        public Item125 Textbox141 { get; set; }

        /// <remarks/>
        public Item130 Textbox125 { get; set; }

        /// <remarks/>
        public Item135 Textbox127 { get; set; }

        /// <remarks/>
        public Item140 Textbox129 { get; set; }

        /// <remarks/>
        public Item145 Textbox131 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item125
    {
        /// <remarks/>
        public Item126 OutcomeName2 { get; set; }

        /// <remarks/>
        public Item128 Textbox4 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item126
    {
        /// <remarks/>
        public Item127 Textbox2 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item127
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item128
    {
        /// <remarks/>
        public Item129 Textbox6 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item129
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item130
    {
        /// <remarks/>
        public Item131 OutcomeName3 { get; set; }

        /// <remarks/>
        public Item133 Textbox9 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item131
    {
        /// <remarks/>
        public Item132 Textbox7 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item132
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item133
    {
        /// <remarks/>
        public Item134 Textbox12 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item134
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item135
    {
        /// <remarks/>
        public Item136 OutcomeName4 { get; set; }

        /// <remarks/>
        public Item138 Textbox19 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item136
    {
        /// <remarks/>
        public Item137 Textbox13 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item137
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item138
    {
        /// <remarks/>
        public Item139 Textbox17 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item139
    {
        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item140
    {
        /// <remarks/>
        public Item141 OutcomeName7 { get; set; }

        /// <remarks/>
        public Item143 Textbox39 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item141
    {
        /// <remarks/>
        public Item142 Textbox20 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item142
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item143
    {
        /// <remarks/>
        public Item144 Textbox21 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item144
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item145
    {
        /// <remarks/>
        public Item146 OutcomeName8 { get; set; }

        /// <remarks/>
        public Item148 Textbox35 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item146
    {
        /// <remarks/>
        public Item147 Textbox22 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item147
    {
        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item148
    {
        /// <remarks/>
        public Item149 Textbox23 { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item149
    {
        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified { get; set; }
    }



}

