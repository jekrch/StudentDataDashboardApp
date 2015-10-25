using System;
using System.Windows;
using PFdata.Properties;

namespace PFdata
{
    /// <summary>
    /// Interaction logic for DateSettings.xaml
    /// </summary>
    public partial class DateSettingsWindow : Window
    {
        public DateSettingsWindow()
        {
            InitializeComponent();

            //Set fields to saved settings

            ExcludeDatePicker.SelectedDate = Settings.Default.ExcludeDate;
            ExcludeYouthPriorToDate.IsChecked = Settings.Default.ExcludeYouthPriorToDate;
            ExcludeYouthWithNegDays.IsChecked = Settings.Default.ExcludeYouthWithNegDays;
        }

        // Get the most recent previous September 1st date 
        public static DateTime GetPreviousSeptemberDate()
        {
            if (DateTime.Now.Month >= 9 && DateTime.Now.Month <= 12)
            {
                return new DateTime(DateTime.Now.Year, 9, 1);
            }

            return new DateTime(DateTime.Now.Year - 1, 9, 1);
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ExcludeDatePicker.SelectedDate != null)
                Settings.Default.ExcludeDate = (DateTime)ExcludeDatePicker.SelectedDate;

            if (ExcludeYouthPriorToDate.IsChecked != null)
                Settings.Default.ExcludeYouthPriorToDate = (bool)ExcludeYouthPriorToDate.IsChecked;

            if (ExcludeYouthWithNegDays.IsChecked != null)
                Settings.Default.ExcludeYouthWithNegDays = (bool)ExcludeYouthWithNegDays.IsChecked;

            Settings.Default.Save();

            // Only reload if data is currently loaded into Dashboard
            if (MainWindow.StudentList.Count != 0)
            {
                // Reload data, but don't reload StudentList, nor the combobox filters.
                await ((MainWindow)this.Owner).LoadData(false, false);
            }
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void DefaultButton_Click(object sender, RoutedEventArgs e)
        {
            
            ExcludeDatePicker.SelectedDate = GetPreviousSeptemberDate();

            ExcludeYouthPriorToDate.IsChecked = true;

            ExcludeYouthWithNegDays.IsChecked = true;

        }
    }
}
