using System.Collections.Generic;
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

            list = list.OrderBy(e => e);  // order numbers by numbers

            // order gradeBox by item length so that 10th grade comes last (after 9th)
            if (comboBox.Name == "gradeBox") list = list.OrderBy(e => e.Length);  

            comboBox.Items.Clear(); // Make sure we aren't just added to what was there before. 

            if (includeAll) comboBox.Items.Add("All");

            foreach (var site in list)
            {
                comboBox.Items.Add(site);
            }

        }

        // Creates a dictionary identifying each fellow with his or her service site.
        public static Task CreateFellowSiteDict(IEnumerable<string> fellowNameList)
        {
            return Task.Run(() => MainWindow.FellowSiteDict = 
                FellowSiteDictGenerator(fellowNameList, MainWindow.StudentList));
        }

        public static Dictionary<string, string> FellowSiteDictGenerator(IEnumerable<string> fellowNameList, List<Student> studentList )
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

    }
}
