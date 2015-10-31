using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using PFdata.Dashboard.Models;
using PFdata.Properties;

namespace PFdata.Dashboard.Presentation
{
    public class DataGridControls
    {

        public static string DataGridLabel1;
        public static string DataGridLabel2;

        // sets column tooltips explaining the distinction between 'days supported' and 'days reported'
        public static void SetColumnToolTips(DataGrid dataGrid)
        {
            TextBlock ds = new TextBlock() {Text = "Days Supported"};

            ToolTipService.SetToolTip(ds, "Number of days for which youth have been active in the program");
            dataGrid.Columns[1].Header = ds;

            TextBlock dr = new TextBlock() { Text = "Days Reported" };

            ToolTipService.SetToolTip(dr, "Number of days for which youth have data reported");
            dataGrid.Columns[7].Header = dr;
        }

        // Sets column width, buffer and visibility according to user specified settings (from TableSettingsWindow)
        public static void SetDataGridColumns(DataGrid dataGrid)
        {

            SetColumnVisibility(1, Settings.Default.DaysSupported, dataGrid);
            SetColumnVisibility(2, Settings.Default.InterventionMin, dataGrid);
            SetColumnVisibility(3, Settings.Default.AvgMin, dataGrid);
            SetColumnVisibility(4, Settings.Default.MissingBaseline, dataGrid);

            // For students list areas in which improvement has occurred
            SetColumnVisibility(5, Settings.Default.ImprovementStatus && Settings.Default.RowItem == "Students", dataGrid);

            // For promise fellows, show total numbers of students who have improved
            SetColumnVisibility(6, Settings.Default.ImprovementStatus && Settings.Default.RowItem == "Promise Fellows", dataGrid);

            SetColumnVisibility(7, Settings.Default.DaysReported, dataGrid);
            SetColumnVisibility(8, Settings.Default.ServiceSite, dataGrid);

            // Don't show promise fellow name for promise fellows
            SetColumnVisibility(9, Settings.Default.PromiseFellow && Settings.Default.RowItem == "Students", dataGrid);

            // Set the minimum width for each column
            SetGridColumnMinWidth(dataGrid);

            // Set buffer/emtpy column. this ensures that selection highlighting covers whole row
            dataGrid.Columns[10].Width = new DataGridLength(120, DataGridLengthUnitType.Star);
            dataGrid.Columns[10].Header = " ";

        }

        private static void SetColumnVisibility(int columnNumber, bool setting, DataGrid dataGrid)
        {
            dataGrid.Columns[columnNumber].Visibility = setting ? Visibility.Visible : Visibility.Hidden;
        }

        // Sets the minimum width for each of the two datatables' columns
        public static void SetGridColumnMinWidth(DataGrid dataGridInput)
        {

            for (int i = 0; i < 11; i++)
            {
                dataGridInput.Columns[i].MinWidth = 120;

            }
            dataGridInput.Columns[5].MinWidth = 140;
        }

        public static void SetDatagridLabels(Grid mainGrid, Label gridLabel1, Label gridLabel2)
        {
           
            switch (Settings.Default.DataGridSplit)
            {
                case "Improved/Pending":
                    DataGridLabel1 = "Improved";
                    DataGridLabel2 = "Pending";
                    break;
                case "Missing Baseline":
                    DataGridLabel1 = "All Data Entered";
                    DataGridLabel2 = "Missing Baseline Data";
                    break;
                case "No Split":
                    break;
                default:
                    DataGridLabel1 = "Active";
                    DataGridLabel2 = "Inactive";
                    break;
            }

            //mainGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);

            if (string.IsNullOrEmpty(Settings.Default.RowItem))
                Settings.Default.RowItem = "Students";

            gridLabel1.Content = $"{DataGridLabel1}";
            gridLabel2.Content = $"{DataGridLabel2}";
        }

        public static void SplitDataGrids(List<RowItem> itemList, DataTable myDataTable1, DataTable myDataTable2, Grid mainGrid)
        {

            switch (Settings.Default.DataGridSplit)
            {
                case "Improved/Pending":
                    AddDataTableRows(myDataTable1, itemList, s => s.Improvement.All);
                    AddDataTableRows(myDataTable2, itemList, s => !s.Improvement.All);
                    DataGridLabel1 = "Improved All";
                    DataGridLabel2 = "Pending";
                    mainGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                    break;
                case "Missing Baseline":
                    AddDataTableRows(myDataTable1, itemList, s => s.MissingBaselineCount == 0);
                    AddDataTableRows(myDataTable2, itemList, s => s.MissingBaselineCount > 0);
                    DataGridLabel1 = "All Data Entered";
                    DataGridLabel2 = "Missing Baseline Data";
                    mainGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                    break;
                case "No Split":
                    AddDataTableRows(myDataTable1, itemList, s => !string.IsNullOrEmpty(s.Profile.Name));
                    mainGrid.ColumnDefinitions[1].Width = new GridLength(10);
                    DataGridLabel1 = Settings.Default.RowItem == "Students" ? "Youth" : "Promise Fellows";
                    break;
                default:
                    AddDataTableRows(myDataTable1, itemList, s => s.Profile.Status == "Active");
                    AddDataTableRows(myDataTable2, itemList, s => s.Profile.Status != "Active");
                    DataGridLabel1 = "Active";
                    DataGridLabel2 = "Inactive";
                    mainGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                    break;
            }


        }

        private static void AddDataTableRows(DataTable datatable, List<RowItem> itemList, Func<RowItem, bool> predicate)
        {
            foreach (RowItem s in itemList)
            {
                if (predicate(s))
                {
                    datatable.Rows.Add(s.Profile.Name,
                        s.TotalDays,
                        s.InterventionTotal,
                        s.AvgIntvMin,
                        s.MissingBaselineCount,
                        ImprovementLabel(s),
                        s.ImproveOverallCount,
                        s.TotalInstructDays,
                        s.Profile.Site,
                        s.Profile.Fellow
                        );
                }

            }
        }

        // Returns a string representing the categories in which a student has improved. 
        private static string ImprovementLabel(RowItem s)
        {
            string label = "";
            if (s.Improvement.Attend) label += "A ";
            if (s.Improvement.Deten && s.Improvement.OfficeRefs && s.Improvement.Suspend) label += "B ";
            if (s.Improvement.Acad) label += "C";

            return label;
        }

    }
}
