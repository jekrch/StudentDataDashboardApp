using System.Linq;
using System.Windows;
using PFdata.Properties;

namespace PFdata
{
    /// <summary>
    /// Interaction logic for TableSettingsWindow.xaml
    /// </summary>
    public partial class TableSettingsWindow : Window
    {
        private static TableSettingsWindow window;
        
        // Allow only one table settings window to be open at a time
        public static TableSettingsWindow GetTsWindow
        {
            get
            {
                if (Application.Current.Windows.OfType<TableSettingsWindow>().Any())
                {
                    return null;
                }

                window = new TableSettingsWindow();
                
                return window;
            }
        }

        public TableSettingsWindow()
        {
            InitializeComponent();

            LoadSettings();
        }


        public void LoadSettings()
        {
            DaysSupportedCheckBox.IsChecked = Settings.Default.DaysSupported;
            InterventionMinCheckBox.IsChecked = Settings.Default.InterventionMin;
            AvgMinCheckBox.IsChecked = Settings.Default.AvgMin;

            MissingBaselineCheckBox.IsChecked = Settings.Default.MissingBaseline;
            ImprovementStatusCheckBox.IsChecked = Settings.Default.ImprovementStatus;
            DaysReportedCheckBox.IsChecked = Settings.Default.DaysReported;
            ServiceSiteCheckBox.IsChecked = Settings.Default.ServiceSite;
            PromiseFellowCheckBox.IsChecked = Settings.Default.PromiseFellow;

            showInactiveBox.IsChecked = Settings.Default.ShowInactive;

            RowItemComboBox.SelectedItem = Settings.Default.RowItem == "Students" ? Students : PromiseFellows;

            switch (Settings.Default.DataGridSplit)
            {
                case "Improved/Pending":
                    DataGridSplitComboBox.SelectedItem = ImprovedPending;
                    break;
                case "Missing Baseline":
                    DataGridSplitComboBox.SelectedItem = MissingBaseline;
                    break;
                case "No Split":
                    DataGridSplitComboBox.SelectedItem = NoSplit;
                    break;
                default:
                    DataGridSplitComboBox.SelectedItem = ActiveExited;
                    break;
            }

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.DaysSupported = (bool)DaysSupportedCheckBox.IsChecked;
            Settings.Default.InterventionMin = (bool)InterventionMinCheckBox.IsChecked;
            Settings.Default.AvgMin = (bool)AvgMinCheckBox.IsChecked;

            Settings.Default.MissingBaseline = (bool)MissingBaselineCheckBox.IsChecked;
            Settings.Default.ImprovementStatus = (bool)ImprovementStatusCheckBox.IsChecked;
            Settings.Default.DaysReported = (bool)DaysReportedCheckBox.IsChecked;
            Settings.Default.ServiceSite = (bool)ServiceSiteCheckBox.IsChecked;
            Settings.Default.PromiseFellow = (bool)PromiseFellowCheckBox.IsChecked;

            //Settings.Default.ShowInactive = (bool)showInactiveBox.IsChecked;

            Settings.Default.DataGridSplit = DataGridSplitComboBox.SelectionBoxItem.ToString();
            Settings.Default.RowItem = RowItemComboBox.SelectionBoxItem.ToString();

            Settings.Default.Save();

            if (Settings.Default.ShowInactive != (bool) showInactiveBox.IsChecked)
            {
                Settings.Default.ShowInactive = (bool)showInactiveBox.IsChecked;
                ((MainWindow)this.Owner).LoadData();
            }
            else
            {
                ((MainWindow)this.Owner).SetDatagrids();
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadSettings();
        }

        private void DefaultButton_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.DaysSupported = true;
            Settings.Default.InterventionMin = true;
            Settings.Default.AvgMin = true;
            Settings.Default.MissingBaseline = true;

            Settings.Default.ImprovementStatus = false;
            Settings.Default.DaysReported = false;
            Settings.Default.ServiceSite = false;
            Settings.Default.PromiseFellow = false;

            Settings.Default.DataGridSplit = "ActiveExited";
            Settings.Default.RowItem = "Students";

            Settings.Default.ShowInactive = true; 

            LoadSettings();
        }
    }
}
