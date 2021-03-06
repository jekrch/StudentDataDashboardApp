﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using PFdata.Dashboard.Models;

namespace PFdata.Dashboard.Presentation
{
    public class ComboBoxControls
    {
        // Sets all items in a list to the specified combobox.
        public static void SetComboBox(ComboBox comboBox, IEnumerable<string> list, bool includeAll = true)
        {

            list = list.OrderBy(e => e); 

            // order gradeBox by item length so that 10th grade comes last (after 9th)
            if (comboBox.Name == "gradeBox") list = list.OrderBy(e => e.Length);

            comboBox.Items.Clear();  

            if (includeAll) comboBox.Items.Add("All");

            foreach (var site in list)
            {
                comboBox.Items.Add(site);
            }

        }

        // Creates a dictionary identifying each fellow with his or her service site.
        public static Task<Dictionary<string, string>> CreateFellowSiteDictAsync(List<Student> studentList,
            List<string> fellowNameList)
        {
            return Task.Run(() => FellowSiteDictGenerator(studentList, fellowNameList));
        }

        public static Dictionary<string, string> FellowSiteDictGenerator(List<Student> studentList,
            List<string> fellowNameList)
        {
            var fellowSiteDict = new Dictionary<string, string>();

            foreach (string fellow in fellowNameList)
            {
                var siteName = (studentList.Where(student => student.Profile.Fellow == fellow)
                    .Select(student => student.Profile.Site)).First();

                fellowSiteDict.Add(fellow, siteName);
            }

            return fellowSiteDict;
        }

        // Sets the filter comboboxes from the loaded data
        public static async Task<Dictionary<string, string>> SetFilterBoxes(
            List<Student> StudentList, ComboBox siteBox, ComboBox fellowBox, ComboBox gradeBox)
        {
            // Get distinct sites and fellow names from students and listing them in comboboxes to be selected for sorting the datagrid
            var siteList = StudentList.Select(student => student.Profile.Site).Distinct().ToList();
            var fellowNameList = StudentList.Select(student => student.Profile.Fellow).Distinct().ToList();
            var gradeList = StudentList.Select(student => student.Grade).Distinct().ToList();

            // Generate dictionary associating each fellow with his or her site
            var fellowSiteDict = await CreateFellowSiteDictAsync(StudentList, fellowNameList);

            SetComboBox(siteBox, siteList);
            SetComboBox(fellowBox, fellowNameList);
            SetComboBox(gradeBox, gradeList);

            return fellowSiteDict;
        }
    }
}
