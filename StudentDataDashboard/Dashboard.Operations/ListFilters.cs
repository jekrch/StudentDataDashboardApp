using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using PFdata.Dashboard.Models;
using PFdata.Properties;

namespace PFdata.Dashboard.Operations
{
    // These methods filter the studentlist which is later displayed in the datagrid on the MainWindow
    class ListFilters
    {
        // filters student list according to user specifications
        public static List<Student> SetStudentListFilters( 
            ComboBox siteBox, ComboBox fellowBox, ComboBox gradeBox)
        {
            var filteredStudentList = (MainWindow.StudentList.Select(student => student)).ToList();

            // Filter _filteredStudentList by site and promise fellow - as specified in comboboxes
            filteredStudentList = SiteAndFellowFilter(filteredStudentList, siteBox, fellowBox, gradeBox);

            // Filter _filteredStudentList by start date - as specified in DateSettings window
            if (Settings.Default.ExcludeYouthPriorToDate)
            {
                filteredStudentList = ExcludedStartDateFilter(filteredStudentList);
            }

            // Filter _filteredStudentList by number of support days - as specified in DateSettings window
            if (Settings.Default.ExcludeYouthWithNegDays)
            {
                filteredStudentList = ExcludeNegativeSupportDaysFilter(filteredStudentList);
            }

            return filteredStudentList; 
        }

        // Exclude all youth with start dates prior to date set in date settings
        private static List<Student> ExcludedStartDateFilter(List<Student> filteredStudentList)
        {
            filteredStudentList.RemoveAll(s =>
                IsBeforeExcludeDate(s.SupportDates.Start1) ||
                IsBeforeExcludeDate(s.SupportDates.Start2) ||
                IsBeforeExcludeDate(s.SupportDates.Start3));

            return filteredStudentList;
        }

        // Exclude all youth with negative number of days supported (bad data)
        private static List<Student> ExcludeNegativeSupportDaysFilter(List<Student> filteredStudentList)
        {
            filteredStudentList.RemoveAll(s =>
                s.TotalDays < 0);
            return filteredStudentList;
        }

        // Identify whether startDate string contains date prior to exclude date
        private static bool IsBeforeExcludeDate(string startDateString)
        {
            if (!string.IsNullOrEmpty(startDateString))
            {
                DateTime startDate;
                DateTime.TryParse(startDateString, out startDate);
                {
                    return startDate < Settings.Default.ExcludeDate;
                }
            }

            return false;
        }

        // Sorts the datagrid by site and promise fellow - as specified in comboboxes
        private static List<Student> SiteAndFellowFilter(List<Student> filteredStudentList, ComboBox siteBox, ComboBox fellowBox, ComboBox gradeBox)
        {
            if (siteBox.SelectedItem != null && siteBox.SelectedItem.ToString() != "All")
            {
                string site = siteBox.SelectedItem.ToString();

                filteredStudentList = (filteredStudentList.Where(student => student.Profile.Site == site)).ToList();

                filteredStudentList = filteredStudentList.Where(s => s.Profile.Site == site).ToList();

            }

            if (fellowBox.SelectedItem != null && fellowBox.SelectedItem.ToString() != "All")
            {
                string fellow = fellowBox.SelectedItem.ToString();

                filteredStudentList = (filteredStudentList.Where(student => student.Profile.Fellow == fellow)).ToList();
            }

            if (gradeBox.SelectedItem != null && gradeBox.SelectedItem.ToString() != "All")
            {
                string grade = gradeBox.SelectedItem.ToString();

                filteredStudentList = (filteredStudentList.Where(student => student.Grade == grade)).ToList();
            }

            if (!Settings.Default.ShowInactive && Settings.Default.RowItem == "Students")
            {
                filteredStudentList = (filteredStudentList.Where(student => student.Profile.Status == "Active")).ToList();
            }

            return filteredStudentList; 
        }
    }
}
