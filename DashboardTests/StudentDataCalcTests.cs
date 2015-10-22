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
    public class StudentDataCalcTests
    {
        Application app = new Application();
        List<Student> studentList = 
            StudentListGenerator.CreateStudentList(@"../../TestReport/TestData.xml");
        Student student = new Student();

        // Test whether report loads properly, and resulting list contains correct number of 
        // students, fellows (youth-workers), and sites.
        [TestCase(12, 2, 2)]
        public void GetList(int expectedStudentCount, int expectedFellowCount, int expectedSiteCount)
        {
            // Act
            var actualStudentCount = studentList.Count();
            var actualFellowCount = studentList
                .Select(student => student.Profile.Fellow).Distinct().Count();
            var actualSiteCount = studentList
                .Select(student => student.Profile.Site).Distinct().Count();

            // Assert
            Assert.AreEqual(expectedStudentCount, actualStudentCount);
            Assert.AreEqual(expectedFellowCount, actualFellowCount);
            Assert.AreEqual(expectedSiteCount, actualSiteCount);
        }

        // Test whether SetImprovementBools correctly identifies whether a student
        // has improved in each of the ABC category areas. 
        [TestCase("Janet Improvement", true)]
        [TestCase("Allen Data", false)]
        public void ImprovedInAllAreas(string studentName, bool expectedImprovedInAllAreas)
        {      
            // Arrange            
            student = studentList.First(s => s.Profile.Name == studentName);

            // Act
            StudentDataCalc.SetImprovementBools(student);

            // Assert
            Assert.AreEqual(student.Improvement.All, expectedImprovedInAllAreas);
        }

        // Test whether CalculateMissingBaselineTotal correctly counts how many missing
        // baseline fields a students has. 
        [TestCase("Allen Data", 0)]
        [TestCase("Jane Mindata", 9)]
        public void CalculateMissingBaselineData(string studentName, int expectedMissingBaselineCount)
        {
            // Arrange    
            student = studentList.First(s => s.Profile.Name == studentName);
            student.MissingBaselineCount = 0;

            // Act
            StudentDataCalc.CalculateMissingBaselineTotal(student);
            var actualMissingBaselineCount = student.MissingBaselineCount;

            // Assert
            Assert.AreEqual(expectedMissingBaselineCount, actualMissingBaselineCount);
        }

        // Test whether CalculateAvgMinPerWEek correctly calculates the avg
        // interventions a student has received per week of support.
        [TestCase("Allen Data", 34.2)]
        [TestCase("Jane Mindata", 0)]
        public void AvgMinPerWeek(string studentName, double expectedAvgMinPerWeek)
        {
            // Arrange
            student = studentList.First(s => s.Profile.Name == studentName);

            // Act
            StudentDataCalc.CalculateAvgMinPerWeek(student);
            var actualAvgMinPerWeek = student.AvgIntvMin;

            // Assert
            Assert.AreEqual(expectedAvgMinPerWeek, actualAvgMinPerWeek);
        }

        // Test whether SetRateChanges correctly calculates the percentage
        // difference between a student's baseline and current stat rates. 
        [TestCase("Allen Data", 1.00, -0.34)]
        [TestCase("Janet Improvement", 3.00, -0.80)]
        public void SetRateChanges(string studentName,
            double expectedAcadScoreChange,
            double expectedDetenRateChange)
        {
            // Arrange
            student = studentList.First(s => s.Profile.Name == studentName);

            // Act
            StudentDataCalc.SetRateChanges(student);
            var actualAcadScoreChange = student.Ytd.Change.AcadScore;
            var actualDetenRateChange = student.Ytd.Change.DetenRate;

            // Assert
            Assert.AreEqual(expectedAcadScoreChange, actualAcadScoreChange);
            Assert.AreEqual(expectedDetenRateChange, actualDetenRateChange);
        }


        // Test whether CalculateTotalDaysSupported correctly calculates the total
        // days a student has been support given the student's varied sets of 
        // start dates and end dates (only testing students who were marked inactive  
        // at the time that the test report was created).
        [TestCase("Allen Data", 36)]
        [TestCase("NEW student 2015", 287)]
        public void DaysSupported(string studentName, int expectedDaysSupported)
        {
            // Arrange
            student = studentList.First(s => s.Profile.Name == studentName);

            // Act
            StudentDataCalc.CalculateTotalDaysSupported(student);
            var actualdaysSupported = student.TotalDays;

            // Assert
            Assert.AreEqual(expectedDaysSupported, actualdaysSupported);
        }

    }
}
