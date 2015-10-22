using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using PFdata.Dashboard.Data;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Operations;
using PFdata.Dashboard.Presentation;
using PFdata.Properties;

namespace PFdata
{

    public partial class MainWindow : Window
    {

        #region initializingVariables

        public static List<Student> StudentList = new List<Student>();

        private List<Student> _filteredStudentList = new List<Student>();
        private List<PromiseFellow> _fellowList = new List<PromiseFellow>();
        private List<RowItem> _rowList = new List<RowItem>();

        public static Dictionary<string, string> FellowSiteDict = new Dictionary<string, string>();
        private List<string> _fellowNameList;
        private List<string> _siteList;
        private List<string> _gradeList;
        private bool _siteBoxActive; 
   
        public static StudentTotals Totals = new StudentTotals(); 

        private string _studentReportName;
        private string _fileName;
        public static string FilePath;


        private const string MinsTag = "<Span FontSize='10'>min</Span>"; // Small text minutes tag to add to intervention total boxes

        private readonly DataTable _dataTable1 = new DataTable();
        private readonly DataTable _dataTable2 = new DataTable();

        private readonly DataColumn _studentName = new DataColumn("Name");
        private readonly DataColumn _daysSupported = new DataColumn("Days Supported", typeof (double));
        private readonly DataColumn _interventionTotal = new DataColumn("Intervention Min", typeof (double));
        private readonly DataColumn _avgMin = new DataColumn("Avg Min \x2215 Week", typeof (double));
        private readonly DataColumn _missingEw = new DataColumn("Missing Baseline", typeof (int));
        private readonly DataColumn _improvementStatus = new DataColumn("Improvement Areas", typeof (string));
        private readonly DataColumn _improvementTotal = new DataColumn("Improvement Total", typeof (int));
        private readonly DataColumn _daysReported = new DataColumn("Days Reported", typeof (int));
        private readonly DataColumn _serviceSite = new DataColumn("Service Site", typeof (string));
        private readonly DataColumn _promiseFellow = new DataColumn("Promise Fellow", typeof (string));
        private readonly DataColumn _emptyColumn = new DataColumn("empty", typeof (string));

        private readonly DataColumn _studentName2 = new DataColumn("Name");
        private readonly DataColumn _daysSupported2 = new DataColumn("Days Supported", typeof (double));
        private readonly DataColumn _interventionTotal2 = new DataColumn("Intervention Min", typeof (double));
        private readonly DataColumn _avgMin2 = new DataColumn("Avg Min \x2215 Week", typeof (double));
        private readonly DataColumn _missingEw2 = new DataColumn("Missing Baseline", typeof (int));
        private readonly DataColumn _improvementStatus2 = new DataColumn("Improvement Areas", typeof (string));
        private readonly DataColumn _improvementTotal2 = new DataColumn("Improvement Total", typeof (int));
        private readonly DataColumn _daysReported2 = new DataColumn("Days Reported", typeof (int));
        private readonly DataColumn _serviceSite2 = new DataColumn("Service Site", typeof (string));
        private readonly DataColumn _promiseFellow2 = new DataColumn("Promise Fellow", typeof (string));
        private readonly DataColumn _emptyColumn2 = new DataColumn("empty", typeof (string));

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            //Creating columns to be used in both datagrids

            _dataTable1.Columns.AddRange(new DataColumn[]
            {
                _studentName, _daysSupported, _interventionTotal, _avgMin, _missingEw, _improvementStatus,
                _improvementTotal, _daysReported, _serviceSite, _promiseFellow, _emptyColumn
            });

            _dataTable2.Columns.AddRange(new DataColumn[]
            {
                _studentName2, _daysSupported2, _interventionTotal2, _avgMin2, _missingEw2, _improvementStatus2,
                _improvementTotal2, _daysReported2, _serviceSite2, _promiseFellow2, _emptyColumn2
            });


            // Labels the datagrids according to what the last saved setting was 
            DataGridControls.SetDatagridLabels(MainGrid, GridLabel1, GridLabel2);

            // display last saved setting regarding whether to show error prompts or not
            LogSettingsMenuItem1.IsChecked = Settings.Default.DisplayErrorPrompt;


           
        }


        // Master workflow: this loads xml file and displays data in datagrids and text fields 
        public async Task LoadData()
        {

            StudentList.Clear();

            ProgressBarStudentList.IsIndeterminate = true;
            StudentList = await StudentListGenerator.CreateStudentListAsync(FilePath);
            ProgressBarStudentList.IsIndeterminate = false;


            // Clear combobox and insert all student names in list, which can be selected to produce individual student data reports

            var studentList = StudentList.Select(student => student.Profile.Name).Distinct();
            ComboBoxControls.SetComboBox(studentBox, studentList, false);


            // Get distinct sites and fellow names from students and listing them in comboboxes to be selected for sorting the datagrid

            _siteList = StudentList.Select(student => student.Profile.Site).Distinct().ToList();

            _fellowNameList = StudentList.Select(student => student.Profile.Fellow).Distinct().ToList();

            _gradeList = StudentList.Select(student => student.Grade).Distinct().ToList();


            // Generate dictionary associating each fellow with his or her site

            await ComboBoxControls.CreateFellowSiteDict(_fellowNameList);

            ComboBoxControls.SetComboBox(siteBox, _siteList);
            ComboBoxControls.SetComboBox(fellowBox, _fellowNameList);
            ComboBoxControls.SetComboBox(gradeBox, _gradeList);

            _dataTable1.Clear();
            _dataTable2.Clear();

            // Set studentlist to datagrids
            SetDatagrids();

            // calculate student totals to add to total boxes
            await TotalsCalc.CalculateStudentTotalsAsync(_filteredStudentList);

            // Set text boxes presenting totals for student data 

            SetDataTotalBoxes();

            //Saving studentList to properties to be used in reportWindow
            App.Current.Properties["studentList"] = StudentList;

        }


        // Sorts the datagrid by site and promise fellow - as specified in comboboxes
        private void SiteAndFellowFilter()
        {
            if (siteBox.SelectedItem != null && siteBox.SelectedItem.ToString() != "All")
            {
                string site = siteBox.SelectedItem.ToString();

                _filteredStudentList = (_filteredStudentList.Where(student => student.Profile.Site == site)).ToList();

                _filteredStudentList = _filteredStudentList.Where(s => s.Profile.Site == site).ToList();

            }

            if (fellowBox.SelectedItem != null && fellowBox.SelectedItem.ToString() != "All")
            {
                string fellow = fellowBox.SelectedItem.ToString();

                _filteredStudentList = (_filteredStudentList.Where(student => student.Profile.Fellow == fellow)).ToList();
            }

            if (gradeBox.SelectedItem != null && gradeBox.SelectedItem.ToString() != "All")
            {
                string grade = gradeBox.SelectedItem.ToString();

                _filteredStudentList = (_filteredStudentList.Where(student => student.Grade == grade)).ToList();
            }

            if (!Settings.Default.ShowInactive && Settings.Default.RowItem == "Students")
            {
                _filteredStudentList = (_filteredStudentList.Where(student => student.Profile.Status == "Active")).ToList();
            }

        }


        // Sets the two main datagrids with data from the loaded report.
        public void SetDatagrids()
        {

            _dataTable1.Clear();
            _dataTable2.Clear();

            _filteredStudentList = (StudentList.Select(student => student)).ToList(); 

            SiteAndFellowFilter(); // Sorts the datagrid by site and promise fellow - as specified in comboboxes

            if (Settings.Default.RowItem == "Students" || Settings.Default.RowItem == "") // Fill rows with students if 'Student' is selected in table settings window
            {
                _rowList = _filteredStudentList.Cast<RowItem>().ToList(); //.ToList();
                
                DataGridControls.SplitDataGrids(_rowList, _dataTable1, _dataTable2, MainGrid);
            }
            else // Else fill rows with promise fellow items, 
            {
                _fellowList.Clear();
                _fellowList = FellowData.CreatePromiseFellowList(_filteredStudentList);

                _rowList = _fellowList.Cast<RowItem>().ToList(); //.ToList();
                DataGridControls.SplitDataGrids(_rowList, _dataTable1, _dataTable2, MainGrid);
                
            }

            // loading to datagrid
            dataGrid.ItemsSource = _dataTable1.DefaultView;
            dataGrid2.ItemsSource = _dataTable2.DefaultView;

            DataGridControls.SetDataGridColumns(dataGrid);
            DataGridControls.SetDataGridColumns(dataGrid2);

            DataGridControls.SetColumnToolTips(dataGrid);
            DataGridControls.SetColumnToolTips(dataGrid2);

            // Setting table labels
            GridLabel1.Content = $"{DataGridControls.DataGridLabel1} ({_dataTable1.Rows.Count})";
            GridLabel2.Content = $"{DataGridControls.DataGridLabel2} ({_dataTable2.Rows.Count})";
  

        }


        // Assign data to total boxes 
        private void SetDataTotalBoxes()
        {

            var inSchoolBoxString = $"{Totals.InSchoolSupportMins} {MinsTag}";
            var outSchoolBoxString = $"{Totals.OutSchoolSupportMins} {MinsTag}";
            var careBoxString = $"{Totals.CaringAdultsmin} {MinsTag}";
            var serveBoxString = $"{Totals.ServiceMins} {MinsTag}";

            SetInlineExpression.SetFormattedText(inSchoolBox, inSchoolBoxString);
            SetInlineExpression.SetFormattedText(outSchoolBox, outSchoolBoxString);
            SetInlineExpression.SetFormattedText(careBox, careBoxString);
            SetInlineExpression.SetFormattedText(serveBox, serveBoxString);

            inSchoolPctBox.Text = $"{(Totals.InSchoolSupportMins / (Totals.InSchoolSupportMins + Totals.OutSchoolSupportMins)):P0}";
            outSchoolPctBox.Text = $"{(Totals.OutSchoolSupportMins / (Totals.InSchoolSupportMins + Totals.OutSchoolSupportMins)):P0}";
            //carePctBox.Text = $"{(Totals.CaringAdultsmin / Totals.InterventionMins):P0}";
            //servePctBox.Text = $"{(Totals.ServiceMins / Totals.InterventionMins):P0}";

            // Calculate and display the percentage of students who need each of the intervention types. 

            double studentCount = _filteredStudentList.Count();

            IntNeededBoxAttend.Text =
                $"{_filteredStudentList.Count(student => student.Intvns.Needed.Attend == "No") / studentCount:P0}";

            IntNeededBoxBehav.Text =
                $"{_filteredStudentList.Count(student => student.Intvns.Needed.Behav == "Yes") / studentCount:P0}";

            IntNeededBoxAcad.Text =
                $"{_filteredStudentList.Count(student => student.Intvns.Needed.AcadMath == "Yes" || student.Intvns.Needed.AcadReading == "Yes" || student.Intvns.Needed.AcadOther == "Yes") / studentCount:P0}";

            // Calculate and display the percentage of students in each grade. 

            DisplayGradePercentages(studentCount, Grade6Box, "6th");
            DisplayGradePercentages(studentCount, Grade7Box, "7th");
            DisplayGradePercentages(studentCount, Grade8Box, "8th");
            DisplayGradePercentages(studentCount, Grade9Box, "9th");
            DisplayGradePercentages(studentCount, Grade10Box, "10th");
           
            // Setting general information boxes

            string missingBaselineBoxString =
                $"<Span Foreground='{(Totals.MissingBaseline == 0 ? "Black" : "Red")}'>{Totals.MissingBaseline}</Span>";

            SetInlineExpression.SetFormattedText(missingBaselineBox, missingBaselineBoxString);

            improvedBox.Text = Totals.ImproveOverall.ToString();
            avgDaysReportedBox.Text = $"{Math.Round(Totals.ReportDays / studentCount, 1)}";
            
        }


        // Displays the percentage of students in specified grade to appropriate textblock
        private void DisplayGradePercentages(double studentCount, TextBlock textblock, string grade)
        {
            textblock.Text = $"{_filteredStudentList.Count(student => student.Grade == grade) /studentCount:P0}";
        }


        // Displays reportWindow for student selected by user
        public void GetReport()
        {
            if (studentBox.SelectedItem != null)
            {
                _studentReportName = studentBox.SelectedItem.ToString();

                App.Current.Properties["studentReportName"] = _studentReportName;

                var report = new ReportWindow
                {
                    Title = _studentReportName,
                    Owner = this
                };

                report.Show();
            }
        }


        #region click events 

        private void GetReportButton_Click(object sender, RoutedEventArgs e)
        {
            GetReport();
        }

        private void dataGrid_RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GetReport();
        }

        private void dataGrid2_RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GetReport();
        }
        
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count <= 0) return;

            DataRowView row = (DataRowView) dataGrid.SelectedItems[0];
            _studentReportName = row["Name"].ToString();

            studentBox.SelectedValue = _studentReportName;
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ( dataGrid2.SelectedItems.Count <= 0) return; 

            var row = (DataRowView) dataGrid2.SelectedItems[0];
            _studentReportName = row["Name"].ToString();

            studentBox.SelectedValue = _studentReportName;
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SetDatagrids();

            await TotalsCalc.CalculateStudentTotalsAsync(_filteredStudentList);

            // Set text boxes presenting totals for student data 

            SetDataTotalBoxes();
        }

        private void TableSettingsMenuItem_Click(object sender, RoutedEventArgs e)
        {

            var tableSettingsWindow1 = TableSettingsWindow.GetTsWindow;

            if (tableSettingsWindow1 != null)
            {
                tableSettingsWindow1.Show();

               tableSettingsWindow1.Owner = this;
            }
            
        }

        // Opens an xml file and initiates data loading process
        private async void LoadFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Display OpenFileDialog.
            // Set filter for file extension and default file extension 

            var dlg = new OpenFileDialog
            {
                DefaultExt = ".xml",
                Filter = "XML Files (*.xml)|*.xml"
            };


            bool? result = dlg.ShowDialog();

            try
            {
                if (result == true)
                {
                    FilePath = dlg.FileName;
                    _fileName = Path.GetFileName(FilePath);
                    fileBox.Content = _fileName;
                    await LoadData();
                }
            }
            catch(Exception ex) 
            {
                ProgressBarStudentList.IsIndeterminate = false;

                fellowBox.Items.Clear();
                gradeBox.Items.Clear();
                studentBox.Items.Clear();
                siteBox.Items.Clear();
                _dataTable1.Clear();
                _dataTable2.Clear();
                
                if (LogSettingsMenuItem1.IsChecked)
                {
                    App.Current.Properties["LoadException"] = ex;

                    App.Current.Properties["LogSettingsMenuItem"] = this.LogSettingsMenuItem1;

                    var errorWin = new ErrorLogWindow();

                    errorWin.Show();

                }
                else
                {
                   MessageBox.Show(
                    "Invalid file. Please check the file format or contact Alliance administrator for support.",		
                     "File error", MessageBoxButton.OK, MessageBoxImage.Error); 
                } 

            }
        }

        // Closes the program
        private void QuitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Saves screenshot of the main window
        private void SaveWindowMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = String.Format("{0}Dashboard", _fileName != null ? _fileName.Substring(0, _fileName.IndexOf('.')) : ""); // Default file name
                dlg.DefaultExt = ".jpg";
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg";

                // Show save file dialog box
                bool? result = dlg.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                   
                        //dataGrid2.Columns[0].Width
                    // Save datestamped image captured via GetReportImage
                        ScreenshotGenerator.SaveAsJpg(
                        ScreenshotGenerator.GetReportImage(DashboardGrid, new Point(59, 4), Settings.Default.DataGridSplit == "No Split", 
                        dataGrid.Columns[0].ActualWidth, dataGrid2.Columns[0].ActualWidth),
                        new FileStream(dlg.FileName, FileMode.Create));
                }
            }
            catch
            {
                MessageBox.Show("An error occurred. Unable to save file", "File error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        #endregion

        // If the user selects a fellow in the fellow combobox, reassign items to the site combobox so that invalid pairs cannot be selected.
        private void fellowBox_SelectionChanged(object sender, SelectionChangedEventArgs e)  
        {
            if (fellowBox.SelectedItem != null && fellowBox.SelectedItem.ToString() != "All" && !_siteBoxActive)
            {
                var fellowName = fellowBox.SelectedItem.ToString();

                siteBox.SelectedValue = FellowSiteDict[fellowName];
            }
         

        }

        // Ensures that when a fellow is selected in combo box only the fellow's associated 
        // sites are available in the site combo box. Likewise, when a site is selected, only
        // the promise fellows associated with that site are available in the fellow box.
        private void siteBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (siteBox.SelectedItem != null && siteBox.SelectedItem.ToString() != "All" && _siteBoxActive)
            {
                var siteName = siteBox.SelectedItem.ToString();
                fellowBox.Items.Clear();
                fellowBox.Items.Add("All");
                foreach (var item in FellowSiteDict)
                {
                    if (item.Value == siteName)
                    {
                        fellowBox.Items.Add(item.Key);
                    }
                }

                fellowBox.SelectedIndex = 0;
            }

            if (siteBox.SelectedItem != null && siteBox.SelectedItem.ToString() == "All" && _siteBoxActive)
            {
                var prevIdx = fellowBox.SelectedIndex;
                fellowBox.Items.Clear();
                fellowBox.Items.Add("All");
                foreach (var item in FellowSiteDict)
                {
                    fellowBox.Items.Add(item.Key);
                }
                fellowBox.SelectedIndex = prevIdx;
            }
        }

        private void siteBox_DropDownOpened(object sender, EventArgs e)
        {
            _siteBoxActive = true;
        }

        private void fellowBox_DropDownOpened(object sender, EventArgs e)
        {
            _siteBoxActive = false;
        }

        private void LogSettingsMenuItem1_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.DisplayErrorPrompt = LogSettingsMenuItem1.IsChecked; 
        }
    }

}
