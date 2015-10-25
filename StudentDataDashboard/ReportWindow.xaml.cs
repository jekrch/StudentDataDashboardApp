using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Operations;
using PFdata.Dashboard.Presentation;

namespace PFdata
{
    /// <summary>
    /// Interaction logic for reportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private const string MinsTag = "<Span FontSize='10'>min</Span>";
        private const string MissingMessage = "<Span Foreground='Red'>missing</Span>";
        private const string MonthTag = "<Span FontSize='9'> /mo</Span>";
        private readonly Student _stud;

        public ReportWindow()
        {

            InitializeComponent();

            // Retrieve Student object for selected student
            _stud = MainWindow.StudentList.First(s => s.Profile.Name == MainWindow.StudentForReport);
            
            StudentDataCalc.SetRateChanges(_stud); // Set all of the rate change boxes
            
            DisplayInterventionsNeeded(); // Set the interventions needed boxes

            DisplayMissingBaselineIndicators(); // Display the missing baseline data indicators

            DisplayInterventionBreakdown(); // Display intervention mins and percentages

            DisplayStudentInfo(); // Displays basic/general information about student

            DisplayAbcRates(); // Display baseline and current ABC data

        }

        private void DisplayStudentInfo()
        {
            NameLabel.Content = String.Format("Report on " + MainWindow.StudentForReport);

            studentDataBox.Text = $"{_stud.Grade}\n{_stud.SupportDates.Start1}\n{_stud.Profile.Status}";

            string studentDataBox2String = String.Format("<Span Foreground='{0}'>{1}</Span>\n{2}\n{3}",
                _stud.MissingBaselineCount > 0 ? "Red" : "Black", _stud.MissingBaselineCount,
                _stud.TotalDays, 
                _stud.Ytd.InstructDays);

            SetInlineExpression.SetFormattedText(studentDataBox2, studentDataBox2String);
        }


        private void DisplayAbcRates()
        {
            string prevRateString = String.Format("{0:P1}\n\n{1}\n{2}\n{3}\n\n{4}\n{5}",
                _stud.CheckEwField.Absences ? (object) _stud.Bl.Attend.Rate : MissingMessage,
                _stud.CheckEwField.OfficeRefs ? 
                (Math.Round(_stud.Bl.Behav.OfficeRate *19, 2)) + MonthTag : MissingMessage,
                _stud.CheckEwField.Detentions ? (Math.Round(_stud.Bl.Behav.DetenRate *19, 2)) + MonthTag : MissingMessage,
                _stud.CheckEwField.Suspensions ? 
                    (Math.Round(_stud.Bl.Behav.SuspendRate *19, 2)) + MonthTag : MissingMessage,
                _stud.Bl.Acad.ScoreCheck ? (object) _stud.Bl.Acad.Score : MissingMessage,
                _stud.Bl.Acad.HomeworkCompletionScoreCheck ? (object) _stud.Bl.Acad.HomeworkCompletionScore : MissingMessage
                );

            SetInlineExpression.SetFormattedText(prevRateBox, prevRateString);

            string rateBoxString = String.Format("{0:P1}\n\n{1:0.00}{2}\n{3:0.00}{4}\n{5:0.00}{6}\n\n{7} \n{8}",
                _stud.Mo.Attend.Rate,
                Double.IsNaN(_stud.Mo.Behav.OfficeRate*19) ? 0 : _stud.Mo.Behav.OfficeRate*19, MonthTag,
                Double.IsNaN(_stud.Mo.Behav.DetenRate*19) ? 0 : _stud.Mo.Behav.DetenRate*19, MonthTag,
                Double.IsNaN(_stud.Mo.Behav.SuspendRate*19) ? 0 : _stud.Mo.Behav.SuspendRate*19, MonthTag,
                _stud.Mo.Acad.ScoreCheck ? (object) _stud.Mo.Acad.Score : "",
                _stud.Mo.Acad.HomeworkCompletionScoreCheck ? (object) _stud.Mo.Acad.HomeworkCompletionScore : ""
                );

            SetInlineExpression.SetFormattedText(rateMonthBox, rateBoxString);

            string ytdBoxString = String.Format("{0:P1}\n\n{1:0.00}{2}\n{3:0.00}{4}\n{5:0.00}{6}\n\n{7}\n{8}",
                _stud.Ytd.Attend.Rate,
                Double.IsNaN(_stud.Ytd.Behav.OfficeRate *19) ? 0 : _stud.Ytd.Behav.OfficeRate *19, MonthTag,
                Double.IsNaN(_stud.Ytd.Behav.DetenRate *19) ? 0 : _stud.Ytd.Behav.DetenRate *19, MonthTag,
                Double.IsNaN(_stud.Ytd.Behav.SuspendRate *19) ? 0 : _stud.Ytd.Behav.SuspendRate *19, MonthTag,
                _stud.Mo.Acad.ScoreCheck ? (object) _stud.Mo.Acad.Score : "",
                _stud.Mo.Acad.HomeworkCompletionScoreCheck ? (object) _stud.Mo.Acad.HomeworkCompletionScore : ""
                );

            SetInlineExpression.SetFormattedText(rateYTDBox, ytdBoxString);

            string changeMoString = String.Format("{0}\n\n{1}\n{2}\n{3}\n\n{4}\n{5}",
                _stud.CheckEwField.Absences ? FormatPercentNegativeIsRed(_stud.Mo.Change.AttendRate) : "",
                _stud.CheckEwField.OfficeRefs ? FormatPercentNegativeIsGreen(_stud.Mo.Change.OfficeRate) : "",
                _stud.CheckEwField.Detentions ? FormatPercentNegativeIsGreen(_stud.Mo.Change.DetenRate) : "",
                _stud.CheckEwField.Suspensions ? FormatPercentNegativeIsGreen(_stud.Mo.Change.SuspendRate) : "",
                _stud.Bl.Acad.ScoreCheck && _stud.Mo.Acad.ScoreCheck ? 
                    FormatPercentNegativeIsRed(_stud.Mo.Change.AcadScore) : "",
                _stud.Bl.Acad.HomeworkCompletionScoreCheck && _stud.Mo.Acad.HomeworkCompletionScoreCheck ? 
                    FormatPercentNegativeIsRed(_stud.Mo.Change.HomeworkScore) : ""
                );

            SetInlineExpression.SetFormattedText(changeMonthBox, changeMoString);

            string changeYtdString = String.Format("{0}\n\n{1}\n{2}\n{3}\n\n{4}\n{5}",
                _stud.CheckEwField.Absences ? FormatPercentNegativeIsRed(_stud.Ytd.Change.AttendRate) : "",
                _stud.CheckEwField.OfficeRefs ? FormatPercentNegativeIsGreen(_stud.Ytd.Change.OfficeRate) : "",
                _stud.CheckEwField.Detentions ? FormatPercentNegativeIsGreen(_stud.Ytd.Change.DetenRate) : "",
                _stud.CheckEwField.Suspensions ? FormatPercentNegativeIsGreen(_stud.Ytd.Change.SuspendRate) : "",
                _stud.Bl.Acad.ScoreCheck && _stud.Mo.Acad.ScoreCheck ? 
                    FormatPercentNegativeIsRed(_stud.Ytd.Change.AcadScore) : "",
                _stud.Bl.Acad.HomeworkCompletionScoreCheck && _stud.Mo.Acad.HomeworkCompletionScoreCheck ? 
                    FormatPercentNegativeIsRed(_stud.Ytd.Change.HomeworkScore) : ""
                );

            SetInlineExpression.SetFormattedText(changeYTDBox, changeYtdString);
        }

        // Display the intervention mins and percentages
        private void DisplayInterventionBreakdown()
        {
           
            string inSchoolBoxString = $"{_stud.Intvns.HighQualInSchoolMin} {MinsTag}";
            string outSchoolBoxString = $"{_stud.Intvns.HighQualOutOfSchoolMin} {MinsTag}";
            string careBoxString = $"{_stud.Intvns.CareMin} {MinsTag}";
            string serveBoxString = $"{_stud.Intvns.ServMin} {MinsTag}";

            SetInlineExpression.SetFormattedText(inSchoolBox, inSchoolBoxString);
            SetInlineExpression.SetFormattedText(outSchoolBox, outSchoolBoxString);
            SetInlineExpression.SetFormattedText(careBox, careBoxString);
            SetInlineExpression.SetFormattedText(serveBox, serveBoxString);

            // display percentage of high quality support mins marked as In-School Support
            inSchoolPctBox.Text = String.Format("{0:P0}",
                (double) _stud.Intvns.HighQualTotalMin == 0 ? 
                    0 : (_stud.Intvns.HighQualInSchoolMin/(double)(_stud.Intvns.HighQualInSchoolMin + _stud.Intvns.HighQualOutOfSchoolMin)));

            // display percentage of high quality support mins marked as Out-of-School Support
            outSchoolPctBox.Text = String.Format("{0:P0}",
                (double) _stud.Intvns.HighQualTotalMin == 0 ? 
                    0 : (_stud.Intvns.HighQualOutOfSchoolMin/(double)(_stud.Intvns.HighQualInSchoolMin + _stud.Intvns.HighQualOutOfSchoolMin)));

        }

        private void DisplayMissingBaselineIndicators()
        {
            string otherMissingBaselineString = "";

            if (_stud.Bl.Acad.ScoreType == "[Select]") otherMissingBaselineString += "\u2022 Acad Score Type\n";
            if (_stud.EwAttendReportPeriodNum == "") otherMissingBaselineString += "\u2022 Attend Report Per #\n";
            if (_stud.EwBehavReportPeriodNum == "") otherMissingBaselineString += "\u2022 Behav Report Per #\n";

            otherMissingBaselineTextBlock.Text = otherMissingBaselineString;

            if (otherMissingBaselineString == "") otherMissingBaselineLabel.Visibility = Visibility.Hidden;
        }

        private void DisplayInterventionsNeeded()
        {
            if (_stud.Intvns.Needed.Attend == "Yes") interventionsNeededBox.Text += $"\u2022 Attendance \n"; 
            if (_stud.Intvns.Needed.Behav == "Yes") interventionsNeededBox.Text += $"\u2022 Behavior \n";
            if (_stud.Intvns.Needed.AcadMath == "Yes") interventionsNeededBox.Text += $"\u2022 Academic-Math \n";      
            if (_stud.Intvns.Needed.AcadReading == "Yes")  interventionsNeededBox.Text += $"\u2022 Academic-Reading \n";        
            if (_stud.Intvns.Needed.AcadOther == "Yes") interventionsNeededBox.Text += $"\u2022 Academic-Other ";

            if (interventionsNeededBox.Text == "")
            {
                var interventionMissingString =
                    "<Span Foreground='Red' FontWeight='normal'>missing baseline\nintervention needed\ncategories</Span>";
                SetInlineExpression.SetFormattedText(interventionsNeededBox, interventionMissingString);
            }
        }


        public string FormatPercentNegativeIsRed(double percent)
        {
            if (percent > 0)
                return $"<Span Foreground='Green'>+{percent:P0}</Span>";

            return $"<Span Foreground='Red'>{percent:P0}</Span>";
        }

        public string FormatPercentNegativeIsGreen(double percent)
        {
            if (percent > 0)
                return $"<Span Foreground='Red'>+{percent:P0}</Span>";

            if (percent == 0)
                return $"<Span Foreground='Green'>  {percent:P0}</Span>";

            return $"<Span Foreground='Green'>{percent:P0}</Span>";
        }


        public MainWindow owner { get; set; }

        // Make YTD rates and rate changes visible.
        private void ComboBoxYTD_Selected(object sender, RoutedEventArgs e)
        {
            SetVisibility(Visibility.Hidden, changeMonthBox, rateMonthBox);
            SetVisibility(Visibility.Visible, changeYTDBox, rateYTDBox);
        }

        // Make month rates and rate changes visible.
        private void ComboBoxMonth_Selected(object sender, RoutedEventArgs e)
        {
            SetVisibility(Visibility.Visible, changeMonthBox, rateMonthBox);
            SetVisibility(Visibility.Hidden, changeYTDBox, rateYTDBox);
        }

        // Sets the visibility of the specified textblocks
        private void SetVisibility(Visibility visibilitySetting, params TextBlock[] boxArray)
        {
            foreach (var box in boxArray)
            {
                box.Visibility = visibilitySetting; 
            }
        }
       

        // Removed method for taking screenshot of report window 

        //private void ScnShotButton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    { 
        //        var dlg = new SaveFileDialog();
        //        dlg.FileName = $"{_studentReportName.Replace(" ", "")}Report"; // Default file name
        //        dlg.DefaultExt = ".jpg";
        //        dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg";

        //        // Show save file dialog box
        //        bool? result = dlg.ShowDialog();

        //        // Process save file dialog box results
        //        if (result == true)
        //        {
        //            // Save datestamped image captured via GetReportImage
        //            ScreenshotGenerator.SaveAsJpg(
        //                ScreenshotGenerator.GetReportImage(ReportGrid, new Point(359, 367)), 
        //                new FileStream(dlg.FileName, FileMode.Create));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "File error", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }

        //}
    }
}
