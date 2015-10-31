using System.Collections.Generic;
using System.Linq;
using System.Windows;
using NUnit.Framework;
using PFdata.Dashboard.Data;
using PFdata.Dashboard.Models;
using PFdata.Dashboard.Operations;

namespace DashboardTests
{
    [TestFixture]
    public class TotalsCalcTests
    {
        Application app = new Application(); //todo: use mock interface
        List<Student> studentList =
            StudentListGenerator.CreateStudentList(@"../../TestReport/TestData.xml");
        Student student = new Student();

        // Test whether CalculateStudentTotals correctly calculates aggregate fields
        // from all data in studentList
        [TestCase(7, 55, 659)]
        public void StudentTotals(int expectedImproveOverall, double expectedReportDays, double expectedSupportMins)
        {
            // Act
            StudentTotals totals = TotalsCalc.CalculateStudentTotals(studentList);

            var actualImproveOverall = totals.ImproveOverall;
            var actualReportDays = totals.ReportDays;
            var actualSupportMins = totals.SupportMins;
           
            // Assert
            Assert.AreEqual(actualImproveOverall, expectedImproveOverall);
            Assert.AreEqual(actualReportDays, expectedReportDays);
            Assert.AreEqual(actualSupportMins, expectedSupportMins);
        }

        // Test whether CreatePromiseFellowList correctly generates a list
        // of all the fellows referenced in the studentList
        [TestCase(2, "Jane Fellow", "Test Member")]
        public void PromiseFellowTotals(int expectedFellowCount, 
            string expectedFellowName1, string expectedFellowName2)
        {
            // Arrange
            List<PromiseFellow> fellowList = FellowData.CreatePromiseFellowList(studentList);
            fellowList = fellowList.OrderBy(f => f.Profile.Name).ToList();

            // Act 
            var actualFellowCount = fellowList.Count();
            var actualFellowName1 = fellowList[0].Profile.Name;
            var actualFellowName2 = fellowList[1].Profile.Name;

            // Assert
            Assert.AreEqual(actualFellowCount, expectedFellowCount);
            Assert.AreEqual(actualFellowName1, expectedFellowName1);
            Assert.AreEqual(actualFellowName2, expectedFellowName2);
        }
    }
}
