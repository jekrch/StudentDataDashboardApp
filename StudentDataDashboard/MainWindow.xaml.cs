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

        private static List<Student> _filteredStudentList = new List<Student>();
        private List<PromiseFellow> _fellowList = new List<PromiseFellow>();
        private List<RowItem> _rowList = new List<RowItem>();

        private static Dictionary<string, string> _fellowSiteDict = new Dictionary<string, string>();
        private List<string> _studentNameList;

        private bool _siteBoxActive;

        private StudentTotals _studentTotals = new StudentTotals(); 

        public static string StudentForReport;

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

            // If the exclude date has not yet been set (first run of program), 
            // set it to most recent, previous Sept 1st date. 
            if (Settings.Default.ExcludeDate == default(DateTime))
            {
                Settings.Default.ExcludeDate = DateSettingsWindow.GetPreviousSeptemberDate(); 
            }
            
        }

        
        // Master workflow: this loads xml file and displays data in datagrids and text fields 
        public async Task LoadData(bool loadStudentList = true, bool setFilterBoxes = true)
        {
            // load studentList unless otherwise specified
            if (loadStudentList)
            {           
                StudentList.Clear();

                ProgressBarStudentList.IsIndeterminate = true;
                StudentList = await StudentListGenerator.CreateStudentListAsync(FilePath);
                ProgressBarStudentList.IsIndeterminate = false;
            }

            // Clear combobox and insert all student names in list, which can be selected to produce individual student data reports
            _studentNameList = StudentList.Select(student => student.Profile.Name).Distinct().ToList();
            ComboBoxControls.SetComboBox(studentBox, _studentNameList, false);

            // Set filter comboboxes (site, fellow, and grade), unless otherwise specified,
            // and return dictionary associating fellows with their sites
            if (setFilterBoxes)
            {
                _fellowSiteDict = await ComboBoxControls.SetFilterBoxes(StudentList, siteBox, fellowBox, gradeBox);
            }

            // filters student list according to settings and comboboxe selections
            _filteredStudentList = ListFilters.SetStudentListFilters(siteBox, fellowBox, gradeBox);
            
            // Set student list to datagrid(s)
            SetDatagrids();

            // calculate student totals to add to total boxes
            _studentTotals = await TotalsCalc.CalculateStudentTotalsAsync(_filteredStudentList);

            // Set text boxes presenting totals for student data 
            SetDataTotalBoxes(_studentTotals);

        }

        // Sets the two main datagrids with data from the loaded report.
        public void SetDatagrids()
        {
            // clear datatables to avoid stacking data on multiple file loads
            _dataTable1.Clear();
            _dataTable2.Clear();

            // Fill rows with students if 'Student' is selected in table settings window
            if (Settings.Default.RowItem == "Students" || Settings.Default.RowItem == "") 
            {
                _rowList = _filteredStudentList.Cast<RowItem>().ToList();
                
                DataGridControls.SplitDataGrids(_rowList, _dataTable1, _dataTable2, MainGrid);
            }
            else // Else fill rows with promise fellow items, 
            {
                _fellowList.Clear();
                _fellowList = FellowData.CreatePromiseFellowList(_filteredStudentList);

                _rowList = _fellowList.Cast<RowItem>().ToList(); 
                DataGridControls.SplitDataGrids(_rowList, _dataTable1, _dataTable2, MainGrid);        
            }

            // Loading to datagrids
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
        private void SetDataTotalBoxes(StudentTotals studentTotals)
        {

            var inSchoolBoxString = $"{studentTotals.InSchoolSupportMins} {MinsTag}";
            var outSchoolBoxString = $"{studentTotals.OutSchoolSupportMins} {MinsTag}";
            var careBoxString = $"{studentTotals.CaringAdultsmin} {MinsTag}";
            var serveBoxString = $"{studentTotals.ServiceMins} {MinsTag}";

            SetInlineExpression.SetFormattedText(inSchoolBox, inSchoolBoxString);
            SetInlineExpression.SetFormattedText(outSchoolBox, outSchoolBoxString);
            SetInlineExpression.SetFormattedText(careBox, careBoxString);
            SetInlineExpression.SetFormattedText(serveBox, serveBoxString);

            inSchoolPctBox.Text = 
                $"{TotalsCalc.IsNumberFilter(studentTotals.InSchoolSupportMins / (studentTotals.InSchoolSupportMins + studentTotals.OutSchoolSupportMins)):P0}";
            outSchoolPctBox.Text = 
                $"{TotalsCalc.IsNumberFilter(studentTotals.OutSchoolSupportMins / (studentTotals.InSchoolSupportMins + studentTotals.OutSchoolSupportMins)):P0}";

            // Calculate and display the percentage of students who need each of the intervention types. 

            double studentCount = _filteredStudentList.Count();

            IntNeededBoxAttend.Text =
                $"{TotalsCalc.IsNumberFilter(_filteredStudentList.Count(student => student.Intvns.Needed.Attend == "No") / studentCount):P0}";

            IntNeededBoxBehav.Text =
                $"{TotalsCalc.IsNumberFilter(_filteredStudentList.Count(student => student.Intvns.Needed.Behav == "Yes") / studentCount):P0}";

            IntNeededBoxAcad.Text =
                $"{TotalsCalc.IsNumberFilter(_filteredStudentList.Count(student => student.Intvns.Needed.AcadMath == "Yes" || student.Intvns.Needed.AcadReading == "Yes" || student.Intvns.Needed.AcadOther == "Yes") / studentCount):P0}";

            // Calculate and display the percentage of students in each grade. 

            DisplayGradePercentages(studentCount, Grade6Box, "6th");
            DisplayGradePercentages(studentCount, Grade7Box, "7th");
            DisplayGradePercentages(studentCount, Grade8Box, "8th");
            DisplayGradePercentages(studentCount, Grade9Box, "9th");
            DisplayGradePercentages(studentCount, Grade10Box, "10th");
           
            // Setting general information boxes

            string missingBaselineBoxString =
                $"<Span Foreground='{(studentTotals.MissingBaseline == 0 ? "Black" : "Red")}'>{studentTotals.MissingBaseline}</Span>";

            SetInlineExpression.SetFormattedText(missingBaselineBox, missingBaselineBoxString);

            improvedBox.Text = studentTotals.ImproveOverall.ToString();
            avgDaysReportedBox.Text = $"{TotalsCalc.IsNumberFilter(Math.Round(studentTotals.ReportDays / studentCount, 1))}";
            
        }

        // Displays the percentage of students in specified grade to appropriate textblock
        private void DisplayGradePercentages(double studentCount, TextBlock textblock, string grade)
        {
            textblock.Text = $"{TotalsCalc.IsNumberFilter(_filteredStudentList.Count(student => student.Grade == grade) /studentCount):P0}";
        }

        // Displays reportWindow for student selected by user
        public void GetReport()
        {
            if (studentBox.SelectedItem != null)
            {
                StudentForReport = studentBox.SelectedItem.ToString();

              var report = new ReportWindow
                {
                    Title = StudentForReport,
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
            StudentForReport = row["Name"].ToString();

            studentBox.SelectedValue = StudentForReport;
        }

        private void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ( dataGrid2.SelectedItems.Count <= 0) return; 

            var row = (DataRowView) dataGrid2.SelectedItems[0];
            StudentForReport = row["Name"].ToString();

            studentBox.SelectedValue = StudentForReport;
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            // Reload data, but don't reload StudentList, nor reset the combobox filters.
            await LoadData(false, false);

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

                siteBox.SelectedValue = _fellowSiteDict[fellowName];
            }
         

        }

        // If the user selects a site in the site combobox, reassign items to the fellow combobox so that invalid pairs cannot be selected.
        private void siteBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (siteBox.SelectedItem != null && siteBox.SelectedItem.ToString() != "All" && _siteBoxActive)
            {
                var siteName = siteBox.SelectedItem.ToString();
                fellowBox.Items.Clear();
                fellowBox.Items.Add("All");
                foreach (var item in _fellowSiteDict)
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
                foreach (var item in _fellowSiteDict)
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

        private void ExcludedDatesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var win = new DateSettingsWindow
            {
                Owner = this
            };

            win.Show();

            if (Settings.Default.ExcludeDate == default(DateTime))
            {
                Settings.Default.ExcludeDate = DateSettingsWindow.GetPreviousSeptemberDate();
                Settings.Default.Save();
            }
        }
    }

}
