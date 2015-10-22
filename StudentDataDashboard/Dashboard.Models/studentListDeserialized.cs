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


        private ReportSubreport1 subreport1Field;

        private ReportSubreport4 subreport4Field;

        private ReportSubreport3 subreport3Field;

        private ReportSubreport5 subreport5Field;

        private ReportSubreport6 subreport6Field;

        private ReportSubreport2 subreport2Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport1 Subreport1
        {
            get { return this.subreport1Field; }
            set { this.subreport1Field = value; }
        }

        /// <remarks/>
        public ReportSubreport4 Subreport4
        {
            get { return this.subreport4Field; }
            set { this.subreport4Field = value; }
        }

        /// <remarks/>
        public ReportSubreport3 Subreport3
        {
            get { return this.subreport3Field; }
            set { this.subreport3Field = value; }
        }

        /// <remarks/>
        public ReportSubreport5 Subreport5
        {
            get { return this.subreport5Field; }
            set { this.subreport5Field = value; }
        }

        /// <remarks/>
        public ReportSubreport6 Subreport6
        {
            get { return this.subreport6Field; }
            set { this.subreport6Field = value; }
        }

        /// <remarks/>
        public ReportSubreport2 Subreport2
        {
            get { return this.subreport2Field; }
            set { this.subreport2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1
    {

        private ReportSubreport1Report reportField;

        /// <remarks/>
        public ReportSubreport1Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1Report
    {

        private ReportSubreport1ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport1ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1
    {

        private ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        private string textbox50Field;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox50
        {
            get { return this.textbox50Field; }
            set { this.textbox50Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string siteName2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            textbox45Field;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            earlyWarn_AbsencesField;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            EarlyWarn_Absences
        {
            get { return this.earlyWarn_AbsencesField; }
            set { this.earlyWarn_AbsencesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            earlyWarn_AttendanceTypeField;

        private decimal earlyWarn_AbsencesField;

        private bool earlyWarn_AbsencesFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            EarlyWarn_AttendanceType
        {
            get { return this.earlyWarn_AttendanceTypeField; }
            set { this.earlyWarn_AttendanceTypeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_Absences
        {
            get { return this.earlyWarn_AbsencesField; }
            set { this.earlyWarn_AbsencesField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AbsencesSpecified
        {
            get { return this.earlyWarn_AbsencesFieldSpecified; }
            set { this.earlyWarn_AbsencesFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            earlyWarn_AttendanceDaysInRPField;

        private string earlyWarn_AttendanceTypeField;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            EarlyWarn_AttendanceDaysInRP
        {
            get { return this.earlyWarn_AttendanceDaysInRPField; }
            set { this.earlyWarn_AttendanceDaysInRPField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceType
        {
            get { return this.earlyWarn_AttendanceTypeField; }
            set { this.earlyWarn_AttendanceTypeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            earlyWarn_AttendancePeriodsInDayField;

        private int earlyWarn_AttendanceDaysInRPField;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            EarlyWarn_AttendancePeriodsInDay
        {
            get { return this.earlyWarn_AttendancePeriodsInDayField; }
            set { this.earlyWarn_AttendancePeriodsInDayField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendanceDaysInRP
        {
            get { return this.earlyWarn_AttendanceDaysInRPField; }
            set { this.earlyWarn_AttendanceDaysInRPField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            attendanceRate_BaseLineField;

        private int earlyWarn_AttendancePeriodsInDayField;

        private bool earlyWarn_AttendancePeriodsInDayFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            AttendanceRate_BaseLine
        {
            get { return this.attendanceRate_BaseLineField; }
            set { this.attendanceRate_BaseLineField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendancePeriodsInDay
        {
            get { return this.earlyWarn_AttendancePeriodsInDayField; }
            set { this.earlyWarn_AttendancePeriodsInDayField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AttendancePeriodsInDaySpecified
        {
            get { return this.earlyWarn_AttendancePeriodsInDayFieldSpecified; }
            set { this.earlyWarn_AttendancePeriodsInDayFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            textbox32Field;

        private decimal attendanceRate_BaseLineField;

        private bool attendanceRate_BaseLineFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_BaseLine
        {
            get { return this.attendanceRate_BaseLineField; }
            set { this.attendanceRate_BaseLineField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_BaseLineSpecified
        {
            get { return this.attendanceRate_BaseLineFieldSpecified; }
            set { this.attendanceRate_BaseLineFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            textbox10Field;

        private int textbox32Field;

        private bool textbox32FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            Textbox10
        {
            get { return this.textbox10Field; }
            set { this.textbox10Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified
        {
            get { return this.textbox32FieldSpecified; }
            set { this.textbox32FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            earlyWarn_AttendanceFrequencyField;

        private decimal textbox10Field;

        private bool textbox10FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            EarlyWarn_AttendanceFrequency
        {
            get { return this.earlyWarn_AttendanceFrequencyField; }
            set { this.earlyWarn_AttendanceFrequencyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox10
        {
            get { return this.textbox10Field; }
            set { this.textbox10Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox10Specified
        {
            get { return this.textbox10FieldSpecified; }
            set { this.textbox10FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            earlyWarn_AttendanceRPNumberField;

        private string earlyWarn_AttendanceFrequencyField;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            EarlyWarn_AttendanceRPNumber
        {
            get { return this.earlyWarn_AttendanceRPNumberField; }
            set { this.earlyWarn_AttendanceRPNumberField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceFrequency
        {
            get { return this.earlyWarn_AttendanceFrequencyField; }
            set { this.earlyWarn_AttendanceFrequencyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
    {

        private
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            mONTH_NumberOfInstructionalDaysField;

        private string earlyWarn_AttendanceRPNumberField;

        /// <remarks/>
        public
            ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            MONTH_NumberOfInstructionalDays
        {
            get { return this.mONTH_NumberOfInstructionalDaysField; }
            set { this.mONTH_NumberOfInstructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceRPNumber
        {
            get { return this.earlyWarn_AttendanceRPNumberField; }
            set { this.earlyWarn_AttendanceRPNumberField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport1ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
    {

        private Item mONTH_NumberOfInstructionalPeriodsField;

        private int mONTH_NumberOfInstructionalDaysField;

        /// <remarks/>
        public Item MONTH_NumberOfInstructionalPeriods
        {
            get { return this.mONTH_NumberOfInstructionalPeriodsField; }
            set { this.mONTH_NumberOfInstructionalPeriodsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_NumberOfInstructionalDays
        {
            get { return this.mONTH_NumberOfInstructionalDaysField; }
            set { this.mONTH_NumberOfInstructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item
    {

        private Item1 mONTH_Attendance_NumberAbsentField;

        private string mONTH_NumberOfInstructionalPeriodsField;

        /// <remarks/>
        public Item1 MONTH_Attendance_NumberAbsent
        {
            get { return this.mONTH_Attendance_NumberAbsentField; }
            set { this.mONTH_Attendance_NumberAbsentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MONTH_NumberOfInstructionalPeriods
        {
            get { return this.mONTH_NumberOfInstructionalPeriodsField; }
            set { this.mONTH_NumberOfInstructionalPeriodsField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item1
    {

        private Item2 mONTH_Attendance_Reason_PeriodUnknownField;

        private int mONTH_Attendance_NumberAbsentField;

        /// <remarks/>
        public Item2 MONTH_Attendance_Reason_PeriodUnknown
        {
            get { return this.mONTH_Attendance_Reason_PeriodUnknownField; }
            set { this.mONTH_Attendance_Reason_PeriodUnknownField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_NumberAbsent
        {
            get { return this.mONTH_Attendance_NumberAbsentField; }
            set { this.mONTH_Attendance_NumberAbsentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item2
    {

        private Item3 attendanceRate_MonthField;

        private int mONTH_Attendance_Reason_PeriodUnknownField;

        /// <remarks/>
        public Item3 AttendanceRate_Month
        {
            get { return this.attendanceRate_MonthField; }
            set { this.attendanceRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodUnknown
        {
            get { return this.mONTH_Attendance_Reason_PeriodUnknownField; }
            set { this.mONTH_Attendance_Reason_PeriodUnknownField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item3
    {

        private Item4 mONTH_Attendance_Reason_PeriodTardyField;

        private decimal attendanceRate_MonthField;

        private bool attendanceRate_MonthFieldSpecified;

        /// <remarks/>
        public Item4 MONTH_Attendance_Reason_PeriodTardy
        {
            get { return this.mONTH_Attendance_Reason_PeriodTardyField; }
            set { this.mONTH_Attendance_Reason_PeriodTardyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_Month
        {
            get { return this.attendanceRate_MonthField; }
            set { this.attendanceRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_MonthSpecified
        {
            get { return this.attendanceRate_MonthFieldSpecified; }
            set { this.attendanceRate_MonthFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item4
    {

        private Item5 onTimeRate_MonthField;

        private int mONTH_Attendance_Reason_PeriodTardyField;

        /// <remarks/>
        public Item5 OnTimeRate_Month
        {
            get { return this.onTimeRate_MonthField; }
            set { this.onTimeRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodTardy
        {
            get { return this.mONTH_Attendance_Reason_PeriodTardyField; }
            set { this.mONTH_Attendance_Reason_PeriodTardyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item5
    {

        private Item6 mONTH_Intervention_InstancesField;

        private decimal onTimeRate_MonthField;

        /// <remarks/>
        public Item6 MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal OnTimeRate_Month
        {
            get { return this.onTimeRate_MonthField; }
            set { this.onTimeRate_MonthField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item6
    {

        private Item7 mONTH_Intervention_MinutesField;

        private int mONTH_Intervention_InstancesField;

        /// <remarks/>
        public Item7 MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item7
    {

        private Item8 yTD_NumberOfInstructionalDaysField;

        private int mONTH_Intervention_MinutesField;

        /// <remarks/>
        public Item8 YTD_NumberOfInstructionalDays
        {
            get { return this.yTD_NumberOfInstructionalDaysField; }
            set { this.yTD_NumberOfInstructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item8
    {

        private Item9 yTD_NumberOfInstructionalPeriodsField;

        private int yTD_NumberOfInstructionalDaysField;

        /// <remarks/>
        public Item9 YTD_NumberOfInstructionalPeriods
        {
            get { return this.yTD_NumberOfInstructionalPeriodsField; }
            set { this.yTD_NumberOfInstructionalPeriodsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_NumberOfInstructionalDays
        {
            get { return this.yTD_NumberOfInstructionalDaysField; }
            set { this.yTD_NumberOfInstructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item9
    {

        private Item10 yTD_Attendance_NumberAbsentField;

        private string yTD_NumberOfInstructionalPeriodsField;

        /// <remarks/>
        public Item10 YTD_Attendance_NumberAbsent
        {
            get { return this.yTD_Attendance_NumberAbsentField; }
            set { this.yTD_Attendance_NumberAbsentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string YTD_NumberOfInstructionalPeriods
        {
            get { return this.yTD_NumberOfInstructionalPeriodsField; }
            set { this.yTD_NumberOfInstructionalPeriodsField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item10
    {

        private Item11 yTD_Attendance_Reason_PeriodUnknownField;

        private int yTD_Attendance_NumberAbsentField;

        /// <remarks/>
        public Item11 YTD_Attendance_Reason_PeriodUnknown
        {
            get { return this.yTD_Attendance_Reason_PeriodUnknownField; }
            set { this.yTD_Attendance_Reason_PeriodUnknownField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_NumberAbsent
        {
            get { return this.yTD_Attendance_NumberAbsentField; }
            set { this.yTD_Attendance_NumberAbsentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item11
    {

        private Item12 attendanceRate_YTDField;

        private int yTD_Attendance_Reason_PeriodUnknownField;

        /// <remarks/>
        public Item12 AttendanceRate_YTD
        {
            get { return this.attendanceRate_YTDField; }
            set { this.attendanceRate_YTDField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodUnknown
        {
            get { return this.yTD_Attendance_Reason_PeriodUnknownField; }
            set { this.yTD_Attendance_Reason_PeriodUnknownField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item12
    {

        private Item13 yTD_Attendance_Reason_PeriodTardyField;

        private decimal attendanceRate_YTDField;

        private bool attendanceRate_YTDFieldSpecified;

        /// <remarks/>
        public Item13 YTD_Attendance_Reason_PeriodTardy
        {
            get { return this.yTD_Attendance_Reason_PeriodTardyField; }
            set { this.yTD_Attendance_Reason_PeriodTardyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_YTD
        {
            get { return this.attendanceRate_YTDField; }
            set { this.attendanceRate_YTDField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_YTDSpecified
        {
            get { return this.attendanceRate_YTDFieldSpecified; }
            set { this.attendanceRate_YTDFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item13
    {

        private Item14 textbox13Field;

        private int yTD_Attendance_Reason_PeriodTardyField;

        /// <remarks/>
        public Item14 Textbox13
        {
            get { return this.textbox13Field; }
            set { this.textbox13Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodTardy
        {
            get { return this.yTD_Attendance_Reason_PeriodTardyField; }
            set { this.yTD_Attendance_Reason_PeriodTardyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item14
    {

        private Item15 yTD_Intervention_InstancesField;

        private decimal textbox13Field;

        /// <remarks/>
        public Item15 YTD_Intervention_Instances
        {
            get { return this.yTD_Intervention_InstancesField; }
            set { this.yTD_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox13
        {
            get { return this.textbox13Field; }
            set { this.textbox13Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item15
    {

        private Item16 yTD_Intervention_MinutesField;

        private int yTD_Intervention_InstancesField;

        /// <remarks/>
        public Item16 YTD_Intervention_Minutes
        {
            get { return this.yTD_Intervention_MinutesField; }
            set { this.yTD_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Instances
        {
            get { return this.yTD_Intervention_InstancesField; }
            set { this.yTD_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item16
    {

        private Item17 textbox141Field;

        private int yTD_Intervention_MinutesField;

        /// <remarks/>
        public Item17 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Minutes
        {
            get { return this.yTD_Intervention_MinutesField; }
            set { this.yTD_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item17
    {

        private Item18 attendanceName_CollectionField;

        /// <remarks/>
        public Item18 AttendanceName_Collection
        {
            get { return this.attendanceName_CollectionField; }
            set { this.attendanceName_CollectionField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item18
    {

        private Item19 attendanceNameField;

        /// <remarks/>
        public Item19 AttendanceName
        {
            get { return this.attendanceNameField; }
            set { this.attendanceNameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item19
    {

        private Item20 outcomeName2Field;

        /// <remarks/>
        public Item20 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item20
    {

        private Item21 textbox930Field;

        private Item22 textbox933Field;

        /// <remarks/>
        public Item21 Textbox930
        {
            get { return this.textbox930Field; }
            set { this.textbox930Field = value; }
        }

        /// <remarks/>
        public Item22 Textbox933
        {
            get { return this.textbox933Field; }
            set { this.textbox933Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item21
    {

        private int attendance_Interventions_InstancesField;

        /// <remarks/>
        [XmlAttribute()]
        public int attendance_Interventions_Instances
        {
            get { return this.attendance_Interventions_InstancesField; }
            set { this.attendance_Interventions_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item22
    {

        private int attendance_Interventions_MinutesField;

        /// <remarks/>
        [XmlAttribute()]
        public int attendance_Interventions_Minutes
        {
            get { return this.attendance_Interventions_MinutesField; }
            set { this.attendance_Interventions_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4
    {

        private ReportSubreport4Report reportField;

        /// <remarks/>
        public ReportSubreport4Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4Report
    {

        private ReportSubreport4ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport4ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1
    {

        private ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        private string textbox120Field;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox120
        {
            get { return this.textbox120Field; }
            set { this.textbox120Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
            studentName2Field;

        private string siteName2Field;

        /// <remarks/>
        public ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            textbox45Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            earlyWarn_OfficeVisitsField;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            EarlyWarn_OfficeVisits
        {
            get { return this.earlyWarn_OfficeVisitsField; }
            set { this.earlyWarn_OfficeVisitsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            textbox29Field;

        private int earlyWarn_OfficeVisitsField;

        private bool earlyWarn_OfficeVisitsFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            Textbox29
        {
            get { return this.textbox29Field; }
            set { this.textbox29Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_OfficeVisits
        {
            get { return this.earlyWarn_OfficeVisitsField; }
            set { this.earlyWarn_OfficeVisitsField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_OfficeVisitsSpecified
        {
            get { return this.earlyWarn_OfficeVisitsFieldSpecified; }
            set { this.earlyWarn_OfficeVisitsFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            earlyWarn_DetentionsField;

        private string textbox29Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            EarlyWarn_Detentions
        {
            get { return this.earlyWarn_DetentionsField; }
            set { this.earlyWarn_DetentionsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox29
        {
            get { return this.textbox29Field; }
            set { this.textbox29Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            textbox30Field;

        private int earlyWarn_DetentionsField;

        private bool earlyWarn_DetentionsFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            Textbox30
        {
            get { return this.textbox30Field; }
            set { this.textbox30Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_Detentions
        {
            get { return this.earlyWarn_DetentionsField; }
            set { this.earlyWarn_DetentionsField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DetentionsSpecified
        {
            get { return this.earlyWarn_DetentionsFieldSpecified; }
            set { this.earlyWarn_DetentionsFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            earlyWarn_DaysSuspendedField;

        private string textbox30Field;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            EarlyWarn_DaysSuspended
        {
            get { return this.earlyWarn_DaysSuspendedField; }
            set { this.earlyWarn_DaysSuspendedField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox30
        {
            get { return this.textbox30Field; }
            set { this.textbox30Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            textbox32Field;

        private decimal earlyWarn_DaysSuspendedField;

        private bool earlyWarn_DaysSuspendedFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_DaysSuspended
        {
            get { return this.earlyWarn_DaysSuspendedField; }
            set { this.earlyWarn_DaysSuspendedField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DaysSuspendedSpecified
        {
            get { return this.earlyWarn_DaysSuspendedFieldSpecified; }
            set { this.earlyWarn_DaysSuspendedFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            earlyWarn_BehaviorFrequencyField;

        private float textbox32Field;

        private bool textbox32FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            EarlyWarn_BehaviorFrequency
        {
            get { return this.earlyWarn_BehaviorFrequencyField; }
            set { this.earlyWarn_BehaviorFrequencyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified
        {
            get { return this.textbox32FieldSpecified; }
            set { this.textbox32FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            earlyWarn_BehaviorRPNumberField;

        private string earlyWarn_BehaviorFrequencyField;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            EarlyWarn_BehaviorRPNumber
        {
            get { return this.earlyWarn_BehaviorRPNumberField; }
            set { this.earlyWarn_BehaviorRPNumberField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorFrequency
        {
            get { return this.earlyWarn_BehaviorFrequencyField; }
            set { this.earlyWarn_BehaviorFrequencyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            earlyWarn_BehaviorDaysInRPField;

        private string earlyWarn_BehaviorRPNumberField;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            EarlyWarn_BehaviorDaysInRP
        {
            get { return this.earlyWarn_BehaviorDaysInRPField; }
            set { this.earlyWarn_BehaviorDaysInRPField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorRPNumber
        {
            get { return this.earlyWarn_BehaviorRPNumberField; }
            set { this.earlyWarn_BehaviorRPNumberField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            mONTH_IntructionalDaysField;

        private int earlyWarn_BehaviorDaysInRPField;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            MONTH_IntructionalDays
        {
            get { return this.mONTH_IntructionalDaysField; }
            set { this.mONTH_IntructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_BehaviorDaysInRP
        {
            get { return this.earlyWarn_BehaviorDaysInRPField; }
            set { this.earlyWarn_BehaviorDaysInRPField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
    {

        private
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            mONTH_PrincipleOfficeCountField;

        private int mONTH_IntructionalDaysField;

        /// <remarks/>
        public
            ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            MONTH_PrincipleOfficeCount
        {
            get { return this.mONTH_PrincipleOfficeCountField; }
            set { this.mONTH_PrincipleOfficeCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_IntructionalDays
        {
            get { return this.mONTH_IntructionalDaysField; }
            set { this.mONTH_IntructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport4ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
    {

        private Item23 textbox83Field;

        private int mONTH_PrincipleOfficeCountField;

        /// <remarks/>
        public Item23 Textbox83
        {
            get { return this.textbox83Field; }
            set { this.textbox83Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_PrincipleOfficeCount
        {
            get { return this.mONTH_PrincipleOfficeCountField; }
            set { this.mONTH_PrincipleOfficeCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item23
    {

        private Item24 mONTH_DetentionCountField;

        private float textbox83Field;

        /// <remarks/>
        public Item24 MONTH_DetentionCount
        {
            get { return this.mONTH_DetentionCountField; }
            set { this.mONTH_DetentionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox83
        {
            get { return this.textbox83Field; }
            set { this.textbox83Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item24
    {

        private Item25 textbox117Field;

        private int mONTH_DetentionCountField;

        /// <remarks/>
        public Item25 Textbox117
        {
            get { return this.textbox117Field; }
            set { this.textbox117Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_DetentionCount
        {
            get { return this.mONTH_DetentionCountField; }
            set { this.mONTH_DetentionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item25
    {

        private Item26 mONTH_Behavior_SuspensionCountField;

        private float textbox117Field;

        /// <remarks/>
        public Item26 MONTH_Behavior_SuspensionCount
        {
            get { return this.mONTH_Behavior_SuspensionCountField; }
            set { this.mONTH_Behavior_SuspensionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox117
        {
            get { return this.textbox117Field; }
            set { this.textbox117Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item26
    {

        private Item27 textbox109Field;

        private int mONTH_Behavior_SuspensionCountField;

        /// <remarks/>
        public Item27 Textbox109
        {
            get { return this.textbox109Field; }
            set { this.textbox109Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Behavior_SuspensionCount
        {
            get { return this.mONTH_Behavior_SuspensionCountField; }
            set { this.mONTH_Behavior_SuspensionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item27
    {

        private Item28 mONTH_Intervention_InstancesField;

        private float textbox109Field;

        /// <remarks/>
        public Item28 MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox109
        {
            get { return this.textbox109Field; }
            set { this.textbox109Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item28
    {

        private Item29 mONTH_Intervention_MinutesField;

        private int mONTH_Intervention_InstancesField;

        /// <remarks/>
        public Item29 MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item29
    {

        private Item30 yTD_IntructionalDaysField;

        private int mONTH_Intervention_MinutesField;

        /// <remarks/>
        public Item30 YTD_IntructionalDays
        {
            get { return this.yTD_IntructionalDaysField; }
            set { this.yTD_IntructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item30
    {

        private Item31 yTD_PrincipleOfficeCountField;

        private int yTD_IntructionalDaysField;

        /// <remarks/>
        public Item31 YTD_PrincipleOfficeCount
        {
            get { return this.yTD_PrincipleOfficeCountField; }
            set { this.yTD_PrincipleOfficeCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_IntructionalDays
        {
            get { return this.yTD_IntructionalDaysField; }
            set { this.yTD_IntructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item31
    {

        private Item32 textbox77Field;

        private int yTD_PrincipleOfficeCountField;

        /// <remarks/>
        public Item32 Textbox77
        {
            get { return this.textbox77Field; }
            set { this.textbox77Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_PrincipleOfficeCount
        {
            get { return this.yTD_PrincipleOfficeCountField; }
            set { this.yTD_PrincipleOfficeCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item32
    {

        private Item33 yTD_DetentionCountField;

        private double textbox77Field;

        /// <remarks/>
        public Item33 YTD_DetentionCount
        {
            get { return this.yTD_DetentionCountField; }
            set { this.yTD_DetentionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox77
        {
            get { return this.textbox77Field; }
            set { this.textbox77Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item33
    {

        private Item34 textbox115Field;

        private int yTD_DetentionCountField;

        /// <remarks/>
        public Item34 Textbox115
        {
            get { return this.textbox115Field; }
            set { this.textbox115Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_DetentionCount
        {
            get { return this.yTD_DetentionCountField; }
            set { this.yTD_DetentionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item34
    {

        private Item35 yTD_Behavior_SuspensionCountField;

        private double textbox115Field;

        /// <remarks/>
        public Item35 YTD_Behavior_SuspensionCount
        {
            get { return this.yTD_Behavior_SuspensionCountField; }
            set { this.yTD_Behavior_SuspensionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox115
        {
            get { return this.textbox115Field; }
            set { this.textbox115Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item35
    {

        private Item36 textbox107Field;

        private int yTD_Behavior_SuspensionCountField;

        /// <remarks/>
        public Item36 Textbox107
        {
            get { return this.textbox107Field; }
            set { this.textbox107Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Behavior_SuspensionCount
        {
            get { return this.yTD_Behavior_SuspensionCountField; }
            set { this.yTD_Behavior_SuspensionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item36
    {

        private Item37 yTD_Intervention_InstancesField;

        private float textbox107Field;

        /// <remarks/>
        public Item37 YTD_Intervention_Instances
        {
            get { return this.yTD_Intervention_InstancesField; }
            set { this.yTD_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox107
        {
            get { return this.textbox107Field; }
            set { this.textbox107Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item37
    {

        private Item38 yTD_Intervention_MinutesField;

        private int yTD_Intervention_InstancesField;

        /// <remarks/>
        public Item38 YTD_Intervention_Minutes
        {
            get { return this.yTD_Intervention_MinutesField; }
            set { this.yTD_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Instances
        {
            get { return this.yTD_Intervention_InstancesField; }
            set { this.yTD_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item38
    {

        private Item39 textbox141Field;

        private int yTD_Intervention_MinutesField;

        /// <remarks/>
        public Item39 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Intervention_Minutes
        {
            get { return this.yTD_Intervention_MinutesField; }
            set { this.yTD_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item39
    {

        private Item40[] behaviorName_CollectionField;

        /// <remarks/>
        [XmlArrayItem("BehaviorName", IsNullable = false)]
        public Item40[] BehaviorName_Collection
        {
            get { return this.behaviorName_CollectionField; }
            set { this.behaviorName_CollectionField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item40
    {

        private Item41 outcomeName2Field;

        /// <remarks/>
        public Item41 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item41
    {

        private Item42 textbox930Field;

        private Item43 textbox933Field;

        private string outcomeName2Field;

        /// <remarks/>
        public Item42 Textbox930
        {
            get { return this.textbox930Field; }
            set { this.textbox930Field = value; }
        }

        /// <remarks/>
        public Item43 Textbox933
        {
            get { return this.textbox933Field; }
            set { this.textbox933Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item42
    {

        private int behavior_Interventions_InstancesField;

        /// <remarks/>
        [XmlAttribute()]
        public int behavior_Interventions_Instances
        {
            get { return this.behavior_Interventions_InstancesField; }
            set { this.behavior_Interventions_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item43
    {

        private int behavior_Interventions_MinutesField;

        /// <remarks/>
        [XmlAttribute()]
        public int behavior_Interventions_Minutes
        {
            get { return this.behavior_Interventions_MinutesField; }
            set { this.behavior_Interventions_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3
    {

        private ReportSubreport3Report reportField;

        /// <remarks/>
        public ReportSubreport3Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3Report
    {

        private ReportSubreport3ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport3ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1
    {

        private ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
            studentName2Field;

        private string siteName2Field;

        /// <remarks/>
        public ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            textbox45Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            earlyWarn_AcademicScore3Field;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            EarlyWarn_AcademicScore3
        {
            get { return this.earlyWarn_AcademicScore3Field; }
            set { this.earlyWarn_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            earlyWarn_AcademicScore4Field;

        private decimal earlyWarn_AcademicScore3Field;

        private bool earlyWarn_AcademicScore3FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            EarlyWarn_AcademicScore4
        {
            get { return this.earlyWarn_AcademicScore4Field; }
            set { this.earlyWarn_AcademicScore4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_AcademicScore3
        {
            get { return this.earlyWarn_AcademicScore3Field; }
            set { this.earlyWarn_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AcademicScore3Specified
        {
            get { return this.earlyWarn_AcademicScore3FieldSpecified; }
            set { this.earlyWarn_AcademicScore3FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            earlyWarn_HomeworkCompletionScoreField;

        private string earlyWarn_AcademicScore4Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            EarlyWarn_HomeworkCompletionScore
        {
            get { return this.earlyWarn_HomeworkCompletionScoreField; }
            set { this.earlyWarn_HomeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AcademicScore4
        {
            get { return this.earlyWarn_AcademicScore4Field; }
            set { this.earlyWarn_AcademicScore4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            updated_Academic_AcademicScore3Field;

        private int earlyWarn_HomeworkCompletionScoreField;

        private bool earlyWarn_HomeworkCompletionScoreFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            Updated_Academic_AcademicScore3
        {
            get { return this.updated_Academic_AcademicScore3Field; }
            set { this.updated_Academic_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_HomeworkCompletionScore
        {
            get { return this.earlyWarn_HomeworkCompletionScoreField; }
            set { this.earlyWarn_HomeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_HomeworkCompletionScoreSpecified
        {
            get { return this.earlyWarn_HomeworkCompletionScoreFieldSpecified; }
            set { this.earlyWarn_HomeworkCompletionScoreFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            updated_AcademicScore1TypeName2Field;

        private decimal updated_Academic_AcademicScore3Field;

        private bool updated_Academic_AcademicScore3FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            Updated_AcademicScore1TypeName2
        {
            get { return this.updated_AcademicScore1TypeName2Field; }
            set { this.updated_AcademicScore1TypeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Updated_Academic_AcademicScore3
        {
            get { return this.updated_Academic_AcademicScore3Field; }
            set { this.updated_Academic_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Updated_Academic_AcademicScore3Specified
        {
            get { return this.updated_Academic_AcademicScore3FieldSpecified; }
            set { this.updated_Academic_AcademicScore3FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            updated_DailyAcademicScoreDate3Field;

        private string updated_AcademicScore1TypeName2Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            Updated_DailyAcademicScoreDate3
        {
            get { return this.updated_DailyAcademicScoreDate3Field; }
            set { this.updated_DailyAcademicScoreDate3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_AcademicScore1TypeName2
        {
            get { return this.updated_AcademicScore1TypeName2Field; }
            set { this.updated_AcademicScore1TypeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
    {

        private
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3Updated_Academic_AcademicScor
            updated_Academic_AcademicScore4Field;

        private string updated_DailyAcademicScoreDate3Field;

        /// <remarks/>
        public
            ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3Updated_Academic_AcademicScor
            Updated_Academic_AcademicScore4
        {
            get { return this.updated_Academic_AcademicScore4Field; }
            set { this.updated_Academic_AcademicScore4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_DailyAcademicScoreDate3
        {
            get { return this.updated_DailyAcademicScoreDate3Field; }
            set { this.updated_DailyAcademicScoreDate3Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport3ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3Updated_Academic_AcademicScor
    {

        private Item45 updated_AcademicScore2TypeName2Field;

        /// <remarks/>
        public Item45 Updated_AcademicScore2TypeName2
        {
            get { return this.updated_AcademicScore2TypeName2Field; }
            set { this.updated_AcademicScore2TypeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item45
    {

        private Item46 updated_DailyAcademicScoreDate4Field;

        /// <remarks/>
        public Item46 Updated_DailyAcademicScoreDate4
        {
            get { return this.updated_DailyAcademicScoreDate4Field; }
            set { this.updated_DailyAcademicScoreDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item46
    {

        private Item47 total_Intervention_Instances2Field;

        /// <remarks/>
        public Item47 Total_Intervention_Instances2
        {
            get { return this.total_Intervention_Instances2Field; }
            set { this.total_Intervention_Instances2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item47
    {

        private Item48 total_Intervention_Minutes2Field;

        private int total_Intervention_Instances2Field;

        /// <remarks/>
        public Item48 Total_Intervention_Minutes2
        {
            get { return this.total_Intervention_Minutes2Field; }
            set { this.total_Intervention_Minutes2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Total_Intervention_Instances2
        {
            get { return this.total_Intervention_Instances2Field; }
            set { this.total_Intervention_Instances2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item48
    {

        private Item49 homeworkCompletionScoreField;

        private int total_Intervention_Minutes2Field;

        /// <remarks/>
        public Item49 HomeworkCompletionScore
        {
            get { return this.homeworkCompletionScoreField; }
            set { this.homeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Total_Intervention_Minutes2
        {
            get { return this.total_Intervention_Minutes2Field; }
            set { this.total_Intervention_Minutes2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item49
    {

        private Item50 homeworkCompletionDateField;

        private int homeworkCompletionScoreField;

        private bool homeworkCompletionScoreFieldSpecified;

        /// <remarks/>
        public Item50 HomeworkCompletionDate
        {
            get { return this.homeworkCompletionDateField; }
            set { this.homeworkCompletionDateField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int HomeworkCompletionScore
        {
            get { return this.homeworkCompletionScoreField; }
            set { this.homeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionScoreSpecified
        {
            get { return this.homeworkCompletionScoreFieldSpecified; }
            set { this.homeworkCompletionScoreFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item50
    {

        private Item51 textbox141Field;

        private DateTime homeworkCompletionDateField;

        private bool homeworkCompletionDateFieldSpecified;

        /// <remarks/>
        public Item51 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime HomeworkCompletionDate
        {
            get { return this.homeworkCompletionDateField; }
            set { this.homeworkCompletionDateField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionDateSpecified
        {
            get { return this.homeworkCompletionDateFieldSpecified; }
            set { this.homeworkCompletionDateFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item51
    {

        private Item52[] outcomeName1_CollectionField;

        /// <remarks/>
        [XmlArrayItem("OutcomeName1", IsNullable = false)]
        public Item52[] OutcomeName1_Collection
        {
            get { return this.outcomeName1_CollectionField; }
            set { this.outcomeName1_CollectionField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item52
    {

        private Item53 outcomeName2Field;

        /// <remarks/>
        public Item53 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item53
    {

        private Item54 textbox930Field;

        private Item55 textbox933Field;

        private string outcomeName2Field;

        /// <remarks/>
        public Item54 Textbox930
        {
            get { return this.textbox930Field; }
            set { this.textbox930Field = value; }
        }

        /// <remarks/>
        public Item55 Textbox933
        {
            get { return this.textbox933Field; }
            set { this.textbox933Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item54
    {

        private int academic_Interventions_InstancesField;

        /// <remarks/>
        [XmlAttribute()]
        public int academic_Interventions_Instances
        {
            get { return this.academic_Interventions_InstancesField; }
            set { this.academic_Interventions_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item55
    {

        private int academic_Interventions_MinutesField;

        /// <remarks/>
        [XmlAttribute()]
        public int academic_Interventions_Minutes
        {
            get { return this.academic_Interventions_MinutesField; }
            set { this.academic_Interventions_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5
    {

        private ReportSubreport5Report reportField;

        /// <remarks/>
        public ReportSubreport5Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5Report
    {

        private ReportSubreport5ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport5ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1
    {

        private ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        private string textbox50Field;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox50
        {
            get { return this.textbox50Field; }
            set { this.textbox50Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string siteName2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            textbox45Field;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            earlyWarn_AbsencesField;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
            EarlyWarn_Absences
        {
            get { return this.earlyWarn_AbsencesField; }
            set { this.earlyWarn_AbsencesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_Absences
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            earlyWarn_AttendanceTypeField;

        private decimal earlyWarn_AbsencesField;

        private bool earlyWarn_AbsencesFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
            EarlyWarn_AttendanceType
        {
            get { return this.earlyWarn_AttendanceTypeField; }
            set { this.earlyWarn_AttendanceTypeField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_Absences
        {
            get { return this.earlyWarn_AbsencesField; }
            set { this.earlyWarn_AbsencesField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AbsencesSpecified
        {
            get { return this.earlyWarn_AbsencesFieldSpecified; }
            set { this.earlyWarn_AbsencesFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceType
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            earlyWarn_AttendanceDaysInRPField;

        private string earlyWarn_AttendanceTypeField;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
            EarlyWarn_AttendanceDaysInRP
        {
            get { return this.earlyWarn_AttendanceDaysInRPField; }
            set { this.earlyWarn_AttendanceDaysInRPField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceType
        {
            get { return this.earlyWarn_AttendanceTypeField; }
            set { this.earlyWarn_AttendanceTypeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRP
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            earlyWarn_AttendancePeriodsInDayField;

        private int earlyWarn_AttendanceDaysInRPField;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
            EarlyWarn_AttendancePeriodsInDay
        {
            get { return this.earlyWarn_AttendancePeriodsInDayField; }
            set { this.earlyWarn_AttendancePeriodsInDayField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendanceDaysInRP
        {
            get { return this.earlyWarn_AttendanceDaysInRPField; }
            set { this.earlyWarn_AttendanceDaysInRPField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDay
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            attendanceRate_BaseLineField;

        private int earlyWarn_AttendancePeriodsInDayField;

        private bool earlyWarn_AttendancePeriodsInDayFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
            AttendanceRate_BaseLine
        {
            get { return this.attendanceRate_BaseLineField; }
            set { this.attendanceRate_BaseLineField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_AttendancePeriodsInDay
        {
            get { return this.earlyWarn_AttendancePeriodsInDayField; }
            set { this.earlyWarn_AttendancePeriodsInDayField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AttendancePeriodsInDaySpecified
        {
            get { return this.earlyWarn_AttendancePeriodsInDayFieldSpecified; }
            set { this.earlyWarn_AttendancePeriodsInDayFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLine
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            textbox32Field;

        private decimal attendanceRate_BaseLineField;

        private bool attendanceRate_BaseLineFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
            Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_BaseLine
        {
            get { return this.attendanceRate_BaseLineField; }
            set { this.attendanceRate_BaseLineField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_BaseLineSpecified
        {
            get { return this.attendanceRate_BaseLineFieldSpecified; }
            set { this.attendanceRate_BaseLineFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            textbox10Field;

        private int textbox32Field;

        private bool textbox32FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
            Textbox10
        {
            get { return this.textbox10Field; }
            set { this.textbox10Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified
        {
            get { return this.textbox32FieldSpecified; }
            set { this.textbox32FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            earlyWarn_AttendanceFrequencyField;

        private decimal textbox10Field;

        private bool textbox10FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
            EarlyWarn_AttendanceFrequency
        {
            get { return this.earlyWarn_AttendanceFrequencyField; }
            set { this.earlyWarn_AttendanceFrequencyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox10
        {
            get { return this.textbox10Field; }
            set { this.textbox10Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox10Specified
        {
            get { return this.textbox10FieldSpecified; }
            set { this.textbox10FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequency
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            earlyWarn_AttendanceRPNumberField;

        private string earlyWarn_AttendanceFrequencyField;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
            EarlyWarn_AttendanceRPNumber
        {
            get { return this.earlyWarn_AttendanceRPNumberField; }
            set { this.earlyWarn_AttendanceRPNumberField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceFrequency
        {
            get { return this.earlyWarn_AttendanceFrequencyField; }
            set { this.earlyWarn_AttendanceFrequencyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumber
    {

        private
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            mONTH_NumberOfInstructionalDaysField;

        private string earlyWarn_AttendanceRPNumberField;

        /// <remarks/>
        public
            ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
            MONTH_NumberOfInstructionalDays
        {
            get { return this.mONTH_NumberOfInstructionalDaysField; }
            set { this.mONTH_NumberOfInstructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AttendanceRPNumber
        {
            get { return this.earlyWarn_AttendanceRPNumberField; }
            set { this.earlyWarn_AttendanceRPNumberField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport5ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDMN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827Textbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AbsencesEarlyWarn_AttendanceTypeEarlyWarn_AttendanceDaysInRPEarlyWarn_AttendancePeriodsInDayAttendanceRate_BaseLineTextbox32Textbox10EarlyWarn_AttendanceFrequencyEarlyWarn_AttendanceRPNumberMONTH_NumberOfI
    {

        private Item57 mONTH_NumberOfInstructionalPeriodsField;

        private int mONTH_NumberOfInstructionalDaysField;

        /// <remarks/>
        public Item57 MONTH_NumberOfInstructionalPeriods
        {
            get { return this.mONTH_NumberOfInstructionalPeriodsField; }
            set { this.mONTH_NumberOfInstructionalPeriodsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_NumberOfInstructionalDays
        {
            get { return this.mONTH_NumberOfInstructionalDaysField; }
            set { this.mONTH_NumberOfInstructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item57
    {

        private Item58 mONTH_Attendance_NumberAbsentField;

        private string mONTH_NumberOfInstructionalPeriodsField;

        /// <remarks/>
        public Item58 MONTH_Attendance_NumberAbsent
        {
            get { return this.mONTH_Attendance_NumberAbsentField; }
            set { this.mONTH_Attendance_NumberAbsentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MONTH_NumberOfInstructionalPeriods
        {
            get { return this.mONTH_NumberOfInstructionalPeriodsField; }
            set { this.mONTH_NumberOfInstructionalPeriodsField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item58
    {

        private Item59 mONTH_Attendance_Reason_PeriodUnknownField;

        private int mONTH_Attendance_NumberAbsentField;

        /// <remarks/>
        public Item59 MONTH_Attendance_Reason_PeriodUnknown
        {
            get { return this.mONTH_Attendance_Reason_PeriodUnknownField; }
            set { this.mONTH_Attendance_Reason_PeriodUnknownField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_NumberAbsent
        {
            get { return this.mONTH_Attendance_NumberAbsentField; }
            set { this.mONTH_Attendance_NumberAbsentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item59
    {

        private Item60 attendanceRate_MonthField;

        private int mONTH_Attendance_Reason_PeriodUnknownField;

        /// <remarks/>
        public Item60 AttendanceRate_Month
        {
            get { return this.attendanceRate_MonthField; }
            set { this.attendanceRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodUnknown
        {
            get { return this.mONTH_Attendance_Reason_PeriodUnknownField; }
            set { this.mONTH_Attendance_Reason_PeriodUnknownField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item60
    {

        private Item61 mONTH_Attendance_Reason_PeriodTardyField;

        private decimal attendanceRate_MonthField;

        private bool attendanceRate_MonthFieldSpecified;

        /// <remarks/>
        public Item61 MONTH_Attendance_Reason_PeriodTardy
        {
            get { return this.mONTH_Attendance_Reason_PeriodTardyField; }
            set { this.mONTH_Attendance_Reason_PeriodTardyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_Month
        {
            get { return this.attendanceRate_MonthField; }
            set { this.attendanceRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_MonthSpecified
        {
            get { return this.attendanceRate_MonthFieldSpecified; }
            set { this.attendanceRate_MonthFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item61
    {

        private Item62 onTimeRate_MonthField;

        private int mONTH_Attendance_Reason_PeriodTardyField;

        /// <remarks/>
        public Item62 OnTimeRate_Month
        {
            get { return this.onTimeRate_MonthField; }
            set { this.onTimeRate_MonthField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Attendance_Reason_PeriodTardy
        {
            get { return this.mONTH_Attendance_Reason_PeriodTardyField; }
            set { this.mONTH_Attendance_Reason_PeriodTardyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item62
    {

        private Item63 mONTH_Intervention_InstancesField;

        private decimal onTimeRate_MonthField;

        /// <remarks/>
        public Item63 MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal OnTimeRate_Month
        {
            get { return this.onTimeRate_MonthField; }
            set { this.onTimeRate_MonthField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item63
    {

        private Item64 mONTH_Intervention_MinutesField;

        private int mONTH_Intervention_InstancesField;

        /// <remarks/>
        public Item64 MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item64
    {

        private Item65 yTD_NumberOfInstructionalDaysField;

        private int mONTH_Intervention_MinutesField;

        /// <remarks/>
        public Item65 YTD_NumberOfInstructionalDays
        {
            get { return this.yTD_NumberOfInstructionalDaysField; }
            set { this.yTD_NumberOfInstructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item65
    {

        private Item66 yTD_NumberOfInstructionalPeriodsField;

        private int yTD_NumberOfInstructionalDaysField;

        /// <remarks/>
        public Item66 YTD_NumberOfInstructionalPeriods
        {
            get { return this.yTD_NumberOfInstructionalPeriodsField; }
            set { this.yTD_NumberOfInstructionalPeriodsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_NumberOfInstructionalDays
        {
            get { return this.yTD_NumberOfInstructionalDaysField; }
            set { this.yTD_NumberOfInstructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item66
    {

        private Item67 yTD_Attendance_NumberAbsentField;

        private string yTD_NumberOfInstructionalPeriodsField;

        /// <remarks/>
        public Item67 YTD_Attendance_NumberAbsent
        {
            get { return this.yTD_Attendance_NumberAbsentField; }
            set { this.yTD_Attendance_NumberAbsentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string YTD_NumberOfInstructionalPeriods
        {
            get { return this.yTD_NumberOfInstructionalPeriodsField; }
            set { this.yTD_NumberOfInstructionalPeriodsField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item67
    {

        private Item68 yTD_Attendance_Reason_PeriodUnknownField;

        private int yTD_Attendance_NumberAbsentField;

        /// <remarks/>
        public Item68 YTD_Attendance_Reason_PeriodUnknown
        {
            get { return this.yTD_Attendance_Reason_PeriodUnknownField; }
            set { this.yTD_Attendance_Reason_PeriodUnknownField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_NumberAbsent
        {
            get { return this.yTD_Attendance_NumberAbsentField; }
            set { this.yTD_Attendance_NumberAbsentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item68
    {

        private Item69 attendanceRate_YTDField;

        private int yTD_Attendance_Reason_PeriodUnknownField;

        /// <remarks/>
        public Item69 AttendanceRate_YTD
        {
            get { return this.attendanceRate_YTDField; }
            set { this.attendanceRate_YTDField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodUnknown
        {
            get { return this.yTD_Attendance_Reason_PeriodUnknownField; }
            set { this.yTD_Attendance_Reason_PeriodUnknownField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item69
    {

        private Item70 yTD_Attendance_Reason_PeriodTardyField;

        private decimal attendanceRate_YTDField;

        private bool attendanceRate_YTDFieldSpecified;

        /// <remarks/>
        public Item70 YTD_Attendance_Reason_PeriodTardy
        {
            get { return this.yTD_Attendance_Reason_PeriodTardyField; }
            set { this.yTD_Attendance_Reason_PeriodTardyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal AttendanceRate_YTD
        {
            get { return this.attendanceRate_YTDField; }
            set { this.attendanceRate_YTDField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AttendanceRate_YTDSpecified
        {
            get { return this.attendanceRate_YTDFieldSpecified; }
            set { this.attendanceRate_YTDFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item70
    {

        private Item71 textbox13Field;

        private int yTD_Attendance_Reason_PeriodTardyField;

        /// <remarks/>
        public Item71 Textbox13
        {
            get { return this.textbox13Field; }
            set { this.textbox13Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Attendance_Reason_PeriodTardy
        {
            get { return this.yTD_Attendance_Reason_PeriodTardyField; }
            set { this.yTD_Attendance_Reason_PeriodTardyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item71
    {

        private Item72 cOUNT_TotalInterventionForThisStudentField;

        private decimal textbox13Field;

        /// <remarks/>
        public Item72 COUNT_TotalInterventionForThisStudent
        {
            get { return this.cOUNT_TotalInterventionForThisStudentField; }
            set { this.cOUNT_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Textbox13
        {
            get { return this.textbox13Field; }
            set { this.textbox13Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item72
    {

        private Item73 mINUTES_TotalInterventionForThisStudentField;

        private int cOUNT_TotalInterventionForThisStudentField;

        /// <remarks/>
        public Item73 MINUTES_TotalInterventionForThisStudent
        {
            get { return this.mINUTES_TotalInterventionForThisStudentField; }
            set { this.mINUTES_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent
        {
            get { return this.cOUNT_TotalInterventionForThisStudentField; }
            set { this.cOUNT_TotalInterventionForThisStudentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item73
    {

        private Item74 textbox116Field;

        private ushort mINUTES_TotalInterventionForThisStudentField;

        private bool mINUTES_TotalInterventionForThisStudentFieldSpecified;

        /// <remarks/>
        public Item74 Textbox116
        {
            get { return this.textbox116Field; }
            set { this.textbox116Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent
        {
            get { return this.mINUTES_TotalInterventionForThisStudentField; }
            set { this.mINUTES_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudentSpecified
        {
            get { return this.mINUTES_TotalInterventionForThisStudentFieldSpecified; }
            set { this.mINUTES_TotalInterventionForThisStudentFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item74
    {

        private Item75 textbox141Field;

        private Item78 textbox125Field;

        private Item81 textbox127Field;

        private Item84 textbox129Field;

        private Item87 textbox131Field;

        /// <remarks/>
        public Item75 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        public Item78 Textbox125
        {
            get { return this.textbox125Field; }
            set { this.textbox125Field = value; }
        }

        /// <remarks/>
        public Item81 Textbox127
        {
            get { return this.textbox127Field; }
            set { this.textbox127Field = value; }
        }

        /// <remarks/>
        public Item84 Textbox129
        {
            get { return this.textbox129Field; }
            set { this.textbox129Field = value; }
        }

        /// <remarks/>
        public Item87 Textbox131
        {
            get { return this.textbox131Field; }
            set { this.textbox131Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item75
    {

        private Item76 outcomeName2Field;

        private Item77 textbox6Field;

        /// <remarks/>
        public Item76 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }

        /// <remarks/>
        public Item77 Textbox6
        {
            get { return this.textbox6Field; }
            set { this.textbox6Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item76
    {

        private int cOUNT_IsTypeServiceAndOrLeadershipField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership
        {
            get { return this.cOUNT_IsTypeServiceAndOrLeadershipField; }
            set { this.cOUNT_IsTypeServiceAndOrLeadershipField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item77
    {

        private ushort mINUTES_IsTypeServiceAndOrLeadershipField;

        private bool mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipField; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item78
    {

        private Item79 outcomeName3Field;

        private Item80 textbox19Field;

        /// <remarks/>
        public Item79 OutcomeName3
        {
            get { return this.outcomeName3Field; }
            set { this.outcomeName3Field = value; }
        }

        /// <remarks/>
        public Item80 Textbox19
        {
            get { return this.textbox19Field; }
            set { this.textbox19Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item79
    {

        private int cOUNT_IsTypeCaringAdultField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult
        {
            get { return this.cOUNT_IsTypeCaringAdultField; }
            set { this.cOUNT_IsTypeCaringAdultField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item80
    {

        private ushort mINUTES_IsTypeCaringAdultField;

        private bool mINUTES_IsTypeCaringAdultFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult
        {
            get { return this.mINUTES_IsTypeCaringAdultField; }
            set { this.mINUTES_IsTypeCaringAdultField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified
        {
            get { return this.mINUTES_IsTypeCaringAdultFieldSpecified; }
            set { this.mINUTES_IsTypeCaringAdultFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item81
    {

        private Item82 outcomeName4Field;

        private Item83 textbox28Field;

        /// <remarks/>
        public Item82 OutcomeName4
        {
            get { return this.outcomeName4Field; }
            set { this.outcomeName4Field = value; }
        }

        /// <remarks/>
        public Item83 Textbox28
        {
            get { return this.textbox28Field; }
            set { this.textbox28Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item82
    {

        private int cOUNT_IsTypeHighQualitySupportField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport
        {
            get { return this.cOUNT_IsTypeHighQualitySupportField; }
            set { this.cOUNT_IsTypeHighQualitySupportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item83
    {

        private ushort mINUTES_IsTypeHighQualitySupportField;

        private bool mINUTES_IsTypeHighQualitySupportFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport
        {
            get { return this.mINUTES_IsTypeHighQualitySupportField; }
            set { this.mINUTES_IsTypeHighQualitySupportField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified
        {
            get { return this.mINUTES_IsTypeHighQualitySupportFieldSpecified; }
            set { this.mINUTES_IsTypeHighQualitySupportFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item84
    {

        private Item85 outcomeName7Field;

        private Item86 textbox39Field;

        /// <remarks/>
        public Item85 OutcomeName7
        {
            get { return this.outcomeName7Field; }
            set { this.outcomeName7Field = value; }
        }

        /// <remarks/>
        public Item86 Textbox39
        {
            get { return this.textbox39Field; }
            set { this.textbox39Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item85
    {

        private int cOUNT_In_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time
        {
            get { return this.cOUNT_In_School_TimeField; }
            set { this.cOUNT_In_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item86
    {

        private int mINUTES_In_School_TimeField;

        private bool mINUTES_In_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time
        {
            get { return this.mINUTES_In_School_TimeField; }
            set { this.mINUTES_In_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified
        {
            get { return this.mINUTES_In_School_TimeFieldSpecified; }
            set { this.mINUTES_In_School_TimeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item87
    {

        private Item88 outcomeName8Field;

        private Item89 textbox35Field;

        /// <remarks/>
        public Item88 OutcomeName8
        {
            get { return this.outcomeName8Field; }
            set { this.outcomeName8Field = value; }
        }

        /// <remarks/>
        public Item89 Textbox35
        {
            get { return this.textbox35Field; }
            set { this.textbox35Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item88
    {

        private int cOUNT_Out_Of_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time
        {
            get { return this.cOUNT_Out_Of_School_TimeField; }
            set { this.cOUNT_Out_Of_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item89
    {

        private int mINUTES_Out_Of_School_TimeField;

        private bool mINUTES_Out_Of_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time
        {
            get { return this.mINUTES_Out_Of_School_TimeField; }
            set { this.mINUTES_Out_Of_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified
        {
            get { return this.mINUTES_Out_Of_School_TimeFieldSpecified; }
            set { this.mINUTES_Out_Of_School_TimeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6
    {

        private ReportSubreport6Report reportField;

        /// <remarks/>
        public ReportSubreport6Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6Report
    {

        private ReportSubreport6ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport6ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1
    {

        private ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        private string textbox120Field;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox120
        {
            get { return this.textbox120Field; }
            set { this.textbox120Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
            studentName2Field;

        private string siteName2Field;

        /// <remarks/>
        public ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            textbox45Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            earlyWarn_OfficeVisitsField;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
            EarlyWarn_OfficeVisits
        {
            get { return this.earlyWarn_OfficeVisitsField; }
            set { this.earlyWarn_OfficeVisitsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisits
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            textbox29Field;

        private int earlyWarn_OfficeVisitsField;

        private bool earlyWarn_OfficeVisitsFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
            Textbox29
        {
            get { return this.textbox29Field; }
            set { this.textbox29Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_OfficeVisits
        {
            get { return this.earlyWarn_OfficeVisitsField; }
            set { this.earlyWarn_OfficeVisitsField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_OfficeVisitsSpecified
        {
            get { return this.earlyWarn_OfficeVisitsFieldSpecified; }
            set { this.earlyWarn_OfficeVisitsFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            earlyWarn_DetentionsField;

        private string textbox29Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
            EarlyWarn_Detentions
        {
            get { return this.earlyWarn_DetentionsField; }
            set { this.earlyWarn_DetentionsField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox29
        {
            get { return this.textbox29Field; }
            set { this.textbox29Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_Detentions
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            textbox30Field;

        private int earlyWarn_DetentionsField;

        private bool earlyWarn_DetentionsFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
            Textbox30
        {
            get { return this.textbox30Field; }
            set { this.textbox30Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_Detentions
        {
            get { return this.earlyWarn_DetentionsField; }
            set { this.earlyWarn_DetentionsField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DetentionsSpecified
        {
            get { return this.earlyWarn_DetentionsFieldSpecified; }
            set { this.earlyWarn_DetentionsFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            earlyWarn_DaysSuspendedField;

        private string textbox30Field;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
            EarlyWarn_DaysSuspended
        {
            get { return this.earlyWarn_DaysSuspendedField; }
            set { this.earlyWarn_DaysSuspendedField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox30
        {
            get { return this.textbox30Field; }
            set { this.textbox30Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspended
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            textbox32Field;

        private decimal earlyWarn_DaysSuspendedField;

        private bool earlyWarn_DaysSuspendedFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
            Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_DaysSuspended
        {
            get { return this.earlyWarn_DaysSuspendedField; }
            set { this.earlyWarn_DaysSuspendedField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_DaysSuspendedSpecified
        {
            get { return this.earlyWarn_DaysSuspendedFieldSpecified; }
            set { this.earlyWarn_DaysSuspendedFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            earlyWarn_BehaviorFrequencyField;

        private float textbox32Field;

        private bool textbox32FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
            EarlyWarn_BehaviorFrequency
        {
            get { return this.earlyWarn_BehaviorFrequencyField; }
            set { this.earlyWarn_BehaviorFrequencyField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox32
        {
            get { return this.textbox32Field; }
            set { this.textbox32Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Textbox32Specified
        {
            get { return this.textbox32FieldSpecified; }
            set { this.textbox32FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequency
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            earlyWarn_BehaviorRPNumberField;

        private string earlyWarn_BehaviorFrequencyField;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
            EarlyWarn_BehaviorRPNumber
        {
            get { return this.earlyWarn_BehaviorRPNumberField; }
            set { this.earlyWarn_BehaviorRPNumberField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorFrequency
        {
            get { return this.earlyWarn_BehaviorFrequencyField; }
            set { this.earlyWarn_BehaviorFrequencyField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumber
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            earlyWarn_BehaviorDaysInRPField;

        private string earlyWarn_BehaviorRPNumberField;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
            EarlyWarn_BehaviorDaysInRP
        {
            get { return this.earlyWarn_BehaviorDaysInRPField; }
            set { this.earlyWarn_BehaviorDaysInRPField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_BehaviorRPNumber
        {
            get { return this.earlyWarn_BehaviorRPNumberField; }
            set { this.earlyWarn_BehaviorRPNumberField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRP
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            mONTH_IntructionalDaysField;

        private int earlyWarn_BehaviorDaysInRPField;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
            MONTH_IntructionalDays
        {
            get { return this.mONTH_IntructionalDaysField; }
            set { this.mONTH_IntructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_BehaviorDaysInRP
        {
            get { return this.earlyWarn_BehaviorDaysInRPField; }
            set { this.earlyWarn_BehaviorDaysInRPField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDays
    {

        private
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            mONTH_PrincipleOfficeCountField;

        private int mONTH_IntructionalDaysField;

        /// <remarks/>
        public
            ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
            MONTH_PrincipleOfficeCount
        {
            get { return this.mONTH_PrincipleOfficeCountField; }
            set { this.mONTH_PrincipleOfficeCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_IntructionalDays
        {
            get { return this.mONTH_IntructionalDaysField; }
            set { this.mONTH_IntructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport6ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_OfficeVisitsTextbox29EarlyWarn_DetentionsTextbox30EarlyWarn_DaysSuspendedTextbox32EarlyWarn_BehaviorFrequencyEarlyWarn_BehaviorRPNumberEarlyWarn_BehaviorDaysInRPMONTH_IntructionalDaysMONTH_Prin
    {

        private Item90 textbox83Field;

        private int mONTH_PrincipleOfficeCountField;

        /// <remarks/>
        public Item90 Textbox83
        {
            get { return this.textbox83Field; }
            set { this.textbox83Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_PrincipleOfficeCount
        {
            get { return this.mONTH_PrincipleOfficeCountField; }
            set { this.mONTH_PrincipleOfficeCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item90
    {

        private Item91 mONTH_DetentionCountField;

        private float textbox83Field;

        /// <remarks/>
        public Item91 MONTH_DetentionCount
        {
            get { return this.mONTH_DetentionCountField; }
            set { this.mONTH_DetentionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox83
        {
            get { return this.textbox83Field; }
            set { this.textbox83Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item91
    {

        private Item92 textbox117Field;

        private int mONTH_DetentionCountField;

        /// <remarks/>
        public Item92 Textbox117
        {
            get { return this.textbox117Field; }
            set { this.textbox117Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_DetentionCount
        {
            get { return this.mONTH_DetentionCountField; }
            set { this.mONTH_DetentionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item92
    {

        private Item93 mONTH_Behavior_SuspensionCountField;

        private float textbox117Field;

        /// <remarks/>
        public Item93 MONTH_Behavior_SuspensionCount
        {
            get { return this.mONTH_Behavior_SuspensionCountField; }
            set { this.mONTH_Behavior_SuspensionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox117
        {
            get { return this.textbox117Field; }
            set { this.textbox117Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item93
    {

        private Item94 textbox109Field;

        private int mONTH_Behavior_SuspensionCountField;

        /// <remarks/>
        public Item94 Textbox109
        {
            get { return this.textbox109Field; }
            set { this.textbox109Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Behavior_SuspensionCount
        {
            get { return this.mONTH_Behavior_SuspensionCountField; }
            set { this.mONTH_Behavior_SuspensionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item94
    {

        private Item95 mONTH_Intervention_InstancesField;

        private float textbox109Field;

        /// <remarks/>
        public Item95 MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox109
        {
            get { return this.textbox109Field; }
            set { this.textbox109Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item95
    {

        private Item96 mONTH_Intervention_MinutesField;

        private int mONTH_Intervention_InstancesField;

        /// <remarks/>
        public Item96 MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Instances
        {
            get { return this.mONTH_Intervention_InstancesField; }
            set { this.mONTH_Intervention_InstancesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item96
    {

        private Item97 yTD_IntructionalDaysField;

        private int mONTH_Intervention_MinutesField;

        /// <remarks/>
        public Item97 YTD_IntructionalDays
        {
            get { return this.yTD_IntructionalDaysField; }
            set { this.yTD_IntructionalDaysField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int MONTH_Intervention_Minutes
        {
            get { return this.mONTH_Intervention_MinutesField; }
            set { this.mONTH_Intervention_MinutesField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item97
    {

        private Item98 yTD_PrincipleOfficeCountField;

        private int yTD_IntructionalDaysField;

        /// <remarks/>
        public Item98 YTD_PrincipleOfficeCount
        {
            get { return this.yTD_PrincipleOfficeCountField; }
            set { this.yTD_PrincipleOfficeCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_IntructionalDays
        {
            get { return this.yTD_IntructionalDaysField; }
            set { this.yTD_IntructionalDaysField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item98
    {

        private Item99 textbox77Field;

        private int yTD_PrincipleOfficeCountField;

        /// <remarks/>
        public Item99 Textbox77
        {
            get { return this.textbox77Field; }
            set { this.textbox77Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_PrincipleOfficeCount
        {
            get { return this.yTD_PrincipleOfficeCountField; }
            set { this.yTD_PrincipleOfficeCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item99
    {

        private Item100 yTD_DetentionCountField;

        private double textbox77Field;

        /// <remarks/>
        public Item100 YTD_DetentionCount
        {
            get { return this.yTD_DetentionCountField; }
            set { this.yTD_DetentionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox77
        {
            get { return this.textbox77Field; }
            set { this.textbox77Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item100
    {

        private Item101 textbox115Field;

        private int yTD_DetentionCountField;

        /// <remarks/>
        public Item101 Textbox115
        {
            get { return this.textbox115Field; }
            set { this.textbox115Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_DetentionCount
        {
            get { return this.yTD_DetentionCountField; }
            set { this.yTD_DetentionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item101
    {

        private Item102 yTD_Behavior_SuspensionCountField;

        private double textbox115Field;

        /// <remarks/>
        public Item102 YTD_Behavior_SuspensionCount
        {
            get { return this.yTD_Behavior_SuspensionCountField; }
            set { this.yTD_Behavior_SuspensionCountField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public double Textbox115
        {
            get { return this.textbox115Field; }
            set { this.textbox115Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item102
    {

        private Item103 textbox107Field;

        private int yTD_Behavior_SuspensionCountField;

        /// <remarks/>
        public Item103 Textbox107
        {
            get { return this.textbox107Field; }
            set { this.textbox107Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int YTD_Behavior_SuspensionCount
        {
            get { return this.yTD_Behavior_SuspensionCountField; }
            set { this.yTD_Behavior_SuspensionCountField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item103
    {

        private Item104 cOUNT_TotalInterventionForThisStudent2Field;

        private float textbox107Field;

        /// <remarks/>
        public Item104 COUNT_TotalInterventionForThisStudent2
        {
            get { return this.cOUNT_TotalInterventionForThisStudent2Field; }
            set { this.cOUNT_TotalInterventionForThisStudent2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public float Textbox107
        {
            get { return this.textbox107Field; }
            set { this.textbox107Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item104
    {

        private Item105 mINUTES_TotalInterventionForThisStudent2Field;

        private int cOUNT_TotalInterventionForThisStudent2Field;

        /// <remarks/>
        public Item105 MINUTES_TotalInterventionForThisStudent2
        {
            get { return this.mINUTES_TotalInterventionForThisStudent2Field; }
            set { this.mINUTES_TotalInterventionForThisStudent2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent2
        {
            get { return this.cOUNT_TotalInterventionForThisStudent2Field; }
            set { this.cOUNT_TotalInterventionForThisStudent2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item105
    {

        private Item106 textbox118Field;

        private ushort mINUTES_TotalInterventionForThisStudent2Field;

        private bool mINUTES_TotalInterventionForThisStudent2FieldSpecified;

        /// <remarks/>
        public Item106 Textbox118
        {
            get { return this.textbox118Field; }
            set { this.textbox118Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent2
        {
            get { return this.mINUTES_TotalInterventionForThisStudent2Field; }
            set { this.mINUTES_TotalInterventionForThisStudent2Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudent2Specified
        {
            get { return this.mINUTES_TotalInterventionForThisStudent2FieldSpecified; }
            set { this.mINUTES_TotalInterventionForThisStudent2FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item106
    {

        private Item107 textbox141Field;

        private Item110 textbox125Field;

        private Item113 textbox127Field;

        private Item116 textbox129Field;

        private Item119 textbox131Field;

        /// <remarks/>
        public Item107 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        public Item110 Textbox125
        {
            get { return this.textbox125Field; }
            set { this.textbox125Field = value; }
        }

        /// <remarks/>
        public Item113 Textbox127
        {
            get { return this.textbox127Field; }
            set { this.textbox127Field = value; }
        }

        /// <remarks/>
        public Item116 Textbox129
        {
            get { return this.textbox129Field; }
            set { this.textbox129Field = value; }
        }

        /// <remarks/>
        public Item119 Textbox131
        {
            get { return this.textbox131Field; }
            set { this.textbox131Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item107
    {

        private Item108 outcomeName2Field;

        private Item109 textbox10Field;

        /// <remarks/>
        public Item108 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }

        /// <remarks/>
        public Item109 Textbox10
        {
            get { return this.textbox10Field; }
            set { this.textbox10Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item108
    {

        private int cOUNT_IsTypeServiceAndOrLeadershipField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership
        {
            get { return this.cOUNT_IsTypeServiceAndOrLeadershipField; }
            set { this.cOUNT_IsTypeServiceAndOrLeadershipField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item109
    {

        private ushort mINUTES_IsTypeServiceAndOrLeadershipField;

        private bool mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipField; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item110
    {

        private Item111 outcomeName3Field;

        private Item112 textbox19Field;

        /// <remarks/>
        public Item111 OutcomeName3
        {
            get { return this.outcomeName3Field; }
            set { this.outcomeName3Field = value; }
        }

        /// <remarks/>
        public Item112 Textbox19
        {
            get { return this.textbox19Field; }
            set { this.textbox19Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item111
    {

        private int cOUNT_IsTypeCaringAdultField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult
        {
            get { return this.cOUNT_IsTypeCaringAdultField; }
            set { this.cOUNT_IsTypeCaringAdultField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item112
    {

        private ushort mINUTES_IsTypeCaringAdultField;

        private bool mINUTES_IsTypeCaringAdultFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult
        {
            get { return this.mINUTES_IsTypeCaringAdultField; }
            set { this.mINUTES_IsTypeCaringAdultField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified
        {
            get { return this.mINUTES_IsTypeCaringAdultFieldSpecified; }
            set { this.mINUTES_IsTypeCaringAdultFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item113
    {

        private Item114 outcomeName4Field;

        private Item115 textbox34Field;

        /// <remarks/>
        public Item114 OutcomeName4
        {
            get { return this.outcomeName4Field; }
            set { this.outcomeName4Field = value; }
        }

        /// <remarks/>
        public Item115 Textbox34
        {
            get { return this.textbox34Field; }
            set { this.textbox34Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item114
    {

        private int cOUNT_IsTypeHighQualitySupportField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport
        {
            get { return this.cOUNT_IsTypeHighQualitySupportField; }
            set { this.cOUNT_IsTypeHighQualitySupportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item115
    {

        private ushort mINUTES_IsTypeHighQualitySupportField;

        private bool mINUTES_IsTypeHighQualitySupportFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport
        {
            get { return this.mINUTES_IsTypeHighQualitySupportField; }
            set { this.mINUTES_IsTypeHighQualitySupportField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified
        {
            get { return this.mINUTES_IsTypeHighQualitySupportFieldSpecified; }
            set { this.mINUTES_IsTypeHighQualitySupportFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item116
    {

        private Item117 outcomeName7Field;

        private Item118 textbox39Field;

        /// <remarks/>
        public Item117 OutcomeName7
        {
            get { return this.outcomeName7Field; }
            set { this.outcomeName7Field = value; }
        }

        /// <remarks/>
        public Item118 Textbox39
        {
            get { return this.textbox39Field; }
            set { this.textbox39Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item117
    {

        private int cOUNT_In_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time
        {
            get { return this.cOUNT_In_School_TimeField; }
            set { this.cOUNT_In_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item118
    {

        private int mINUTES_In_School_TimeField;

        private bool mINUTES_In_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time
        {
            get { return this.mINUTES_In_School_TimeField; }
            set { this.mINUTES_In_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified
        {
            get { return this.mINUTES_In_School_TimeFieldSpecified; }
            set { this.mINUTES_In_School_TimeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item119
    {

        private Item120 outcomeName8Field;

        private Item121 textbox35Field;

        /// <remarks/>
        public Item120 OutcomeName8
        {
            get { return this.outcomeName8Field; }
            set { this.outcomeName8Field = value; }
        }

        /// <remarks/>
        public Item121 Textbox35
        {
            get { return this.textbox35Field; }
            set { this.textbox35Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item120
    {

        private int cOUNT_Out_Of_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time
        {
            get { return this.cOUNT_Out_Of_School_TimeField; }
            set { this.cOUNT_Out_Of_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item121
    {

        private int mINUTES_Out_Of_School_TimeField;

        private bool mINUTES_Out_Of_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time
        {
            get { return this.mINUTES_Out_Of_School_TimeField; }
            set { this.mINUTES_Out_Of_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified
        {
            get { return this.mINUTES_Out_Of_School_TimeFieldSpecified; }
            set { this.mINUTES_Out_Of_School_TimeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2
    {

        private ReportSubreport2Report reportField;

        /// <remarks/>
        public ReportSubreport2Report Report
        {
            get { return this.reportField; }
            set { this.reportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2Report
    {

        private ReportSubreport2ReportTablix1 tablix1Field;

        private string nameField;

        /// <remarks/>
        public ReportSubreport2ReportTablix1 Tablix1
        {
            get { return this.tablix1Field; }
            set { this.tablix1Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1
    {

        private ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1[] mN_PromiseFellows_StudentID1_CollectionField;

        /// <remarks/>
        [XmlArrayItem("MN_PromiseFellows_StudentID1", IsNullable = false)]
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1[] MN_PromiseFellows_StudentID1_Collection
        {
            get { return this.mN_PromiseFellows_StudentID1_CollectionField; }
            set { this.mN_PromiseFellows_StudentID1_CollectionField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1
    {

        private ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2 memberName2Field;

        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2 MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2
    {

        private ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2Field;

        private string memberName2Field;

        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2 siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MemberName2
        {
            get { return this.memberName2Field; }
            set { this.memberName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2
    {

        private ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
            studentName2Field;

        private string siteName2Field;

        /// <remarks/>
        public ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2 StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string siteName2
        {
            get { return this.siteName2Field; }
            set { this.siteName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            mN_MathGradeName2Field;

        private string studentName2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
            MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StudentName2
        {
            get { return this.studentName2Field; }
            set { this.studentName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2Field;

        private string mN_MathGradeName2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
            programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathGradeName2
        {
            get { return this.mN_MathGradeName2Field; }
            set { this.mN_MathGradeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            mN_MathStudentStatusName2Field;

        private string programName2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
            MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string programName2
        {
            get { return this.programName2Field; }
            set { this.programName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            startDate4Field;

        private string mN_MathStudentStatusName2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
            StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string MN_MathStudentStatusName2
        {
            get { return this.mN_MathStudentStatusName2Field; }
            set { this.mN_MathStudentStatusName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            endDate2Field;

        private string startDate4Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
            EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string StartDate4
        {
            get { return this.startDate4Field; }
            set { this.startDate4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            textbox817Field;

        private string endDate2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
            Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EndDate2
        {
            get { return this.endDate2Field; }
            set { this.endDate2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            textbox11Field;

        private string textbox817Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
            Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox817
        {
            get { return this.textbox817Field; }
            set { this.textbox817Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            textbox8Field;

        private string textbox11Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
            Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox11
        {
            get { return this.textbox11Field; }
            set { this.textbox11Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            textbox827Field;

        private string textbox8Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
            Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox8
        {
            get { return this.textbox8Field; }
            set { this.textbox8Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            mN_PromiseFellows_StudentID_CollectionField;

        private string textbox827Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
            MN_PromiseFellows_StudentID_Collection
        {
            get { return this.mN_PromiseFellows_StudentID_CollectionField; }
            set { this.mN_PromiseFellows_StudentID_CollectionField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox827
        {
            get { return this.textbox827Field; }
            set { this.textbox827Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_Collection
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            mN_PromiseFellows_StudentIDField;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
            MN_PromiseFellows_StudentID
        {
            get { return this.mN_PromiseFellows_StudentIDField; }
            set { this.mN_PromiseFellows_StudentIDField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentID
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            textbox45Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
            Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            textbox51Field;

        private string textbox45Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
            Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox45
        {
            get { return this.textbox45Field; }
            set { this.textbox45Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            textbox52Field;

        private string textbox51Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
            Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox51
        {
            get { return this.textbox51Field; }
            set { this.textbox51Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            textbox53Field;

        private string textbox52Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
            Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox52
        {
            get { return this.textbox52Field; }
            set { this.textbox52Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            textbox55Field;

        private string textbox53Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
            Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox53
        {
            get { return this.textbox53Field; }
            set { this.textbox53Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            earlyWarn_AcademicScore3Field;

        private string textbox55Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
            EarlyWarn_AcademicScore3
        {
            get { return this.earlyWarn_AcademicScore3Field; }
            set { this.earlyWarn_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Textbox55
        {
            get { return this.textbox55Field; }
            set { this.textbox55Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            earlyWarn_AcademicScore4Field;

        private decimal earlyWarn_AcademicScore3Field;

        private bool earlyWarn_AcademicScore3FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
            EarlyWarn_AcademicScore4
        {
            get { return this.earlyWarn_AcademicScore4Field; }
            set { this.earlyWarn_AcademicScore4Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal EarlyWarn_AcademicScore3
        {
            get { return this.earlyWarn_AcademicScore3Field; }
            set { this.earlyWarn_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_AcademicScore3Specified
        {
            get { return this.earlyWarn_AcademicScore3FieldSpecified; }
            set { this.earlyWarn_AcademicScore3FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            earlyWarn_HomeworkCompletionScoreField;

        private string earlyWarn_AcademicScore4Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
            EarlyWarn_HomeworkCompletionScore
        {
            get { return this.earlyWarn_HomeworkCompletionScoreField; }
            set { this.earlyWarn_HomeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string EarlyWarn_AcademicScore4
        {
            get { return this.earlyWarn_AcademicScore4Field; }
            set { this.earlyWarn_AcademicScore4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScore
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            updated_Academic_AcademicScore3Field;

        private int earlyWarn_HomeworkCompletionScoreField;

        private bool earlyWarn_HomeworkCompletionScoreFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
            Updated_Academic_AcademicScore3
        {
            get { return this.updated_Academic_AcademicScore3Field; }
            set { this.updated_Academic_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int EarlyWarn_HomeworkCompletionScore
        {
            get { return this.earlyWarn_HomeworkCompletionScoreField; }
            set { this.earlyWarn_HomeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EarlyWarn_HomeworkCompletionScoreSpecified
        {
            get { return this.earlyWarn_HomeworkCompletionScoreFieldSpecified; }
            set { this.earlyWarn_HomeworkCompletionScoreFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            updated_AcademicScore1TypeName2Field;

        private decimal updated_Academic_AcademicScore3Field;

        private bool updated_Academic_AcademicScore3FieldSpecified;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
            Updated_AcademicScore1TypeName2
        {
            get { return this.updated_AcademicScore1TypeName2Field; }
            set { this.updated_AcademicScore1TypeName2Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal Updated_Academic_AcademicScore3
        {
            get { return this.updated_Academic_AcademicScore3Field; }
            set { this.updated_Academic_AcademicScore3Field = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Updated_Academic_AcademicScore3Specified
        {
            get { return this.updated_Academic_AcademicScore3FieldSpecified; }
            set { this.updated_Academic_AcademicScore3FieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            updated_DailyAcademicScoreDate3Field;

        private string updated_AcademicScore1TypeName2Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
            Updated_DailyAcademicScoreDate3
        {
            get { return this.updated_DailyAcademicScoreDate3Field; }
            set { this.updated_DailyAcademicScoreDate3Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_AcademicScore1TypeName2
        {
            get { return this.updated_AcademicScore1TypeName2Field; }
            set { this.updated_AcademicScore1TypeName2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScore
            homeworkCompletionScoreField;

        private string updated_DailyAcademicScoreDate3Field;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScore
            HomeworkCompletionScore
        {
            get { return this.homeworkCompletionScoreField; }
            set { this.homeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Updated_DailyAcademicScoreDate3
        {
            get { return this.updated_DailyAcademicScoreDate3Field; }
            set { this.updated_DailyAcademicScoreDate3Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScore
    {

        private
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScoreHomewo
            homeworkCompletionDateField;

        private int homeworkCompletionScoreField;

        private bool homeworkCompletionScoreFieldSpecified;

        /// <remarks/>
        public
            ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScoreHomewo
            HomeworkCompletionDate
        {
            get { return this.homeworkCompletionDateField; }
            set { this.homeworkCompletionDateField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int HomeworkCompletionScore
        {
            get { return this.homeworkCompletionScoreField; }
            set { this.homeworkCompletionScoreField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionScoreSpecified
        {
            get { return this.homeworkCompletionScoreFieldSpecified; }
            set { this.homeworkCompletionScoreFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class
        ReportSubreport2ReportTablix1MN_PromiseFellows_StudentID1MemberName2SiteName2StudentName2MN_MathGradeName2ProgramName2MN_MathStudentStatusName2StartDate4EndDate2Textbox817Textbox11Textbox8Textbox827MN_PromiseFellows_StudentID_CollectionMN_PromiseFellows_StudentIDTextbox45Textbox51Textbox52Textbox53Textbox55EarlyWarn_AcademicScore3EarlyWarn_AcademicScore4EarlyWarn_HomeworkCompletionScoreUpdated_Academic_AcademicScore3Updated_AcademicScore1TypeName2Updated_DailyAcademicScoreDate3HomeworkCompletionScoreHomewo
    {

        private Item122 cOUNT_TotalInterventionForThisStudentField;

        private DateTime homeworkCompletionDateField;

        private bool homeworkCompletionDateFieldSpecified;

        /// <remarks/>
        public Item122 COUNT_TotalInterventionForThisStudent
        {
            get { return this.cOUNT_TotalInterventionForThisStudentField; }
            set { this.cOUNT_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime HomeworkCompletionDate
        {
            get { return this.homeworkCompletionDateField; }
            set { this.homeworkCompletionDateField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool HomeworkCompletionDateSpecified
        {
            get { return this.homeworkCompletionDateFieldSpecified; }
            set { this.homeworkCompletionDateFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item122
    {

        private Item123 mINUTES_TotalInterventionForThisStudentField;

        private int cOUNT_TotalInterventionForThisStudentField;

        /// <remarks/>
        public Item123 MINUTES_TotalInterventionForThisStudent
        {
            get { return this.mINUTES_TotalInterventionForThisStudentField; }
            set { this.mINUTES_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_TotalInterventionForThisStudent
        {
            get { return this.cOUNT_TotalInterventionForThisStudentField; }
            set { this.cOUNT_TotalInterventionForThisStudentField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item123
    {

        private Item124 textbox114Field;

        private ushort mINUTES_TotalInterventionForThisStudentField;

        private bool mINUTES_TotalInterventionForThisStudentFieldSpecified;

        /// <remarks/>
        public Item124 Textbox114
        {
            get { return this.textbox114Field; }
            set { this.textbox114Field = value; }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_TotalInterventionForThisStudent
        {
            get { return this.mINUTES_TotalInterventionForThisStudentField; }
            set { this.mINUTES_TotalInterventionForThisStudentField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_TotalInterventionForThisStudentSpecified
        {
            get { return this.mINUTES_TotalInterventionForThisStudentFieldSpecified; }
            set { this.mINUTES_TotalInterventionForThisStudentFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item124
    {

        private Item125 textbox141Field;

        private Item130 textbox125Field;

        private Item135 textbox127Field;

        private Item140 textbox129Field;

        private Item145 textbox131Field;

        /// <remarks/>
        public Item125 Textbox141
        {
            get { return this.textbox141Field; }
            set { this.textbox141Field = value; }
        }

        /// <remarks/>
        public Item130 Textbox125
        {
            get { return this.textbox125Field; }
            set { this.textbox125Field = value; }
        }

        /// <remarks/>
        public Item135 Textbox127
        {
            get { return this.textbox127Field; }
            set { this.textbox127Field = value; }
        }

        /// <remarks/>
        public Item140 Textbox129
        {
            get { return this.textbox129Field; }
            set { this.textbox129Field = value; }
        }

        /// <remarks/>
        public Item145 Textbox131
        {
            get { return this.textbox131Field; }
            set { this.textbox131Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item125
    {

        private Item126 outcomeName2Field;

        private Item128 textbox4Field;

        /// <remarks/>
        public Item126 OutcomeName2
        {
            get { return this.outcomeName2Field; }
            set { this.outcomeName2Field = value; }
        }

        /// <remarks/>
        public Item128 Textbox4
        {
            get { return this.textbox4Field; }
            set { this.textbox4Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item126
    {

        private Item127 textbox2Field;

        /// <remarks/>
        public Item127 Textbox2
        {
            get { return this.textbox2Field; }
            set { this.textbox2Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item127
    {

        private int cOUNT_IsTypeServiceAndOrLeadershipField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeServiceAndOrLeadership
        {
            get { return this.cOUNT_IsTypeServiceAndOrLeadershipField; }
            set { this.cOUNT_IsTypeServiceAndOrLeadershipField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item128
    {

        private Item129 textbox6Field;

        /// <remarks/>
        public Item129 Textbox6
        {
            get { return this.textbox6Field; }
            set { this.textbox6Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item129
    {

        private ushort mINUTES_IsTypeServiceAndOrLeadershipField;

        private bool mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeServiceAndOrLeadership
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipField; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeServiceAndOrLeadershipSpecified
        {
            get { return this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified; }
            set { this.mINUTES_IsTypeServiceAndOrLeadershipFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item130
    {

        private Item131 outcomeName3Field;

        private Item133 textbox9Field;

        /// <remarks/>
        public Item131 OutcomeName3
        {
            get { return this.outcomeName3Field; }
            set { this.outcomeName3Field = value; }
        }

        /// <remarks/>
        public Item133 Textbox9
        {
            get { return this.textbox9Field; }
            set { this.textbox9Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item131
    {

        private Item132 textbox7Field;

        /// <remarks/>
        public Item132 Textbox7
        {
            get { return this.textbox7Field; }
            set { this.textbox7Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item132
    {

        private int cOUNT_IsTypeCaringAdultField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeCaringAdult
        {
            get { return this.cOUNT_IsTypeCaringAdultField; }
            set { this.cOUNT_IsTypeCaringAdultField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item133
    {

        private Item134 textbox12Field;

        /// <remarks/>
        public Item134 Textbox12
        {
            get { return this.textbox12Field; }
            set { this.textbox12Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item134
    {

        private ushort mINUTES_IsTypeCaringAdultField;

        private bool mINUTES_IsTypeCaringAdultFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeCaringAdult
        {
            get { return this.mINUTES_IsTypeCaringAdultField; }
            set { this.mINUTES_IsTypeCaringAdultField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeCaringAdultSpecified
        {
            get { return this.mINUTES_IsTypeCaringAdultFieldSpecified; }
            set { this.mINUTES_IsTypeCaringAdultFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item135
    {

        private Item136 outcomeName4Field;

        private Item138 textbox19Field;

        /// <remarks/>
        public Item136 OutcomeName4
        {
            get { return this.outcomeName4Field; }
            set { this.outcomeName4Field = value; }
        }

        /// <remarks/>
        public Item138 Textbox19
        {
            get { return this.textbox19Field; }
            set { this.textbox19Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item136
    {

        private Item137 textbox13Field;

        /// <remarks/>
        public Item137 Textbox13
        {
            get { return this.textbox13Field; }
            set { this.textbox13Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item137
    {

        private int cOUNT_IsTypeHighQualitySupportField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_IsTypeHighQualitySupport
        {
            get { return this.cOUNT_IsTypeHighQualitySupportField; }
            set { this.cOUNT_IsTypeHighQualitySupportField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item138
    {

        private Item139 textbox17Field;

        /// <remarks/>
        public Item139 Textbox17
        {
            get { return this.textbox17Field; }
            set { this.textbox17Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item139
    {

        private ushort mINUTES_IsTypeHighQualitySupportField;

        private bool mINUTES_IsTypeHighQualitySupportFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public ushort MINUTES_IsTypeHighQualitySupport
        {
            get { return this.mINUTES_IsTypeHighQualitySupportField; }
            set { this.mINUTES_IsTypeHighQualitySupportField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_IsTypeHighQualitySupportSpecified
        {
            get { return this.mINUTES_IsTypeHighQualitySupportFieldSpecified; }
            set { this.mINUTES_IsTypeHighQualitySupportFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item140
    {

        private Item141 outcomeName7Field;

        private Item143 textbox39Field;

        /// <remarks/>
        public Item141 OutcomeName7
        {
            get { return this.outcomeName7Field; }
            set { this.outcomeName7Field = value; }
        }

        /// <remarks/>
        public Item143 Textbox39
        {
            get { return this.textbox39Field; }
            set { this.textbox39Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item141
    {

        private Item142 textbox20Field;

        /// <remarks/>
        public Item142 Textbox20
        {
            get { return this.textbox20Field; }
            set { this.textbox20Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item142
    {

        private int cOUNT_In_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_In_School_Time
        {
            get { return this.cOUNT_In_School_TimeField; }
            set { this.cOUNT_In_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item143
    {

        private Item144 textbox21Field;

        /// <remarks/>
        public Item144 Textbox21
        {
            get { return this.textbox21Field; }
            set { this.textbox21Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item144
    {

        private int mINUTES_In_School_TimeField;

        private bool mINUTES_In_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_In_School_Time
        {
            get { return this.mINUTES_In_School_TimeField; }
            set { this.mINUTES_In_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_In_School_TimeSpecified
        {
            get { return this.mINUTES_In_School_TimeFieldSpecified; }
            set { this.mINUTES_In_School_TimeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item145
    {

        private Item146 outcomeName8Field;

        private Item148 textbox35Field;

        /// <remarks/>
        public Item146 OutcomeName8
        {
            get { return this.outcomeName8Field; }
            set { this.outcomeName8Field = value; }
        }

        /// <remarks/>
        public Item148 Textbox35
        {
            get { return this.textbox35Field; }
            set { this.textbox35Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item146
    {

        private Item147 textbox22Field;

        /// <remarks/>
        public Item147 Textbox22
        {
            get { return this.textbox22Field; }
            set { this.textbox22Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item147
    {

        private int cOUNT_Out_Of_School_TimeField;

        /// <remarks/>
        [XmlAttribute()]
        public int COUNT_Out_Of_School_Time
        {
            get { return this.cOUNT_Out_Of_School_TimeField; }
            set { this.cOUNT_Out_Of_School_TimeField = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item148
    {

        private Item149 textbox23Field;

        /// <remarks/>
        public Item149 Textbox23
        {
            get { return this.textbox23Field; }
            set { this.textbox23Field = value; }
        }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "PF_MemberCombo_Main")]
    public partial class Item149
    {

        private int mINUTES_Out_Of_School_TimeField;

        private bool mINUTES_Out_Of_School_TimeFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public int MINUTES_Out_Of_School_Time
        {
            get { return this.mINUTES_Out_Of_School_TimeField; }
            set { this.mINUTES_Out_Of_School_TimeField = value; }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool MINUTES_Out_Of_School_TimeSpecified
        {
            get { return this.mINUTES_Out_Of_School_TimeFieldSpecified; }
            set { this.mINUTES_Out_Of_School_TimeFieldSpecified = value; }
        }
    }



}

