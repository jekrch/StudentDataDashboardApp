# Student Data Dashboard v1.1

This WPF application was developed to facilitate a user-base of roughly 210 youth-workers in tracking data on the ~6,300 youth supported through Minnesota Alliance With Youth. It loads an XML report that includes both monthly and YTD data on all of the youth that the youth-worker has currently and previously supported, and performs a variety of aggregate and individual calculations, while also enabling student data to be organized and analyzed in a streamlined, user-friendly way. 

####Table of Contents 

#####[1. Main Window](#)

[1.1 Overview](#11-overview)

[1.2 Grid filters](#12-grid-filters)

[1.3 Grid categories](#13-grid-categories)

[1.4 Opening an individual student report](#14-opening-an-individual-student-report)

[1.5 Saving a screenshot of the main window](#15-saving-a-screenshot-of-the-main-window)

#####[2. Table Settings](#2-table-Settings)

[2.1 Overview](#21-overview)

[2.2 Table Categories](#22-table-categories)

[2.3 Row Items](#23-row-items)

[2.4 Table Columns](#24-table-columns)

[2.5 Show Inactive Youth](#25-show-inactive-youth)

#####[3. Report Window](#3-report-window)

[3.1 Overview](#31-overview)

[3.2 Baseline, YTD / Month numbers](#32-baseline-ytd--month-numbers)
[3.3 Change stats](#33-change-stats)
[3.4 Missing baseline data](#34-missing-baseline-data)

#####[4. Error Logging](#4-error-Logging)

[4.1 Overview](#41-overview)

##1. Main Window

![alt tag](http://i.imgur.com/i1zEO5w.png)

####1.1 Overview
When a report is loaded, student data is presented in the data grid(s). Aggregate calculations are displayed at the bottom of the window. These numbers are calculated using data from all and only the students currently displayed in the data grid(s). 

####1.2 Grid filters
The data grid(s) can be filtered using the combo boxes at the top left of the main window. Users can filter the students displayed in the data grid(s) by 
*the specific youth-worker they are paired with
*the site at which they are being supported
*the grade level of the students in the report
(The first two filters are used for administrative purposes with aggregate, state-wide reports). Each of these combo boxes are automatically filled according to the data available in the report. 

####1.3 Grid categories 
In the scenario displayed above, all of the students who are 'active' in the program are placed in the left grid, while all of the 'inactive' students are placed in the right grid. How and whether students are split between the two grids is set in the Table Settings window, which will be described below. 

####1.4 Opening an individual student report
There are two general ways to open an individual student Report Window: 
1. by double-clicking on the row for that student 
2. by selecting the student's name from combo box at the bottom right of the window and clicking 'Get Report.' 
Clicking on a student row once will also automatically select the student’s name in the combo box. 

####1.5 Saving a screenshot of the main window 
A screenshot of the main window can be saved by clicking File > 'Save Window.' This will save a jpg image of the Main Window. For privacy reasons, the name columns are covered by white blocks in the saved image. The application will adjust the location, number, and size of these blocks, according to the size, placement, and number of name columns currently displayed. 

##2. Table Settings
![alt tag](http://i.imgur.com/Qg1zspl.png)

####2.1 Overview
The Table Settings window is opened via Settings > Table Settings. It allows the user to determine how student data is presented in the data grid(s). If the user saves new settings, they will persist between runs of the application.

####2.2 Table Categories 
In the top left combo box, users can select how students are divided between the two data grids. The available options include:
* **Active / Inactive** 

* **Improved / Pending** : *students are marked as improved if they have improved in one or more of the ABC categories*

* **All Data Entered / Missing Baseline** : *students are marked as missing baseline data if any BL fields are empty*

* **No Split** : *all students are placed in [one grid](http://i.imgur.com/AKIFpDd.png" width="100px) which stretches across the width of the Main Window*

####2.3 Row Items 
In the top right combo box, users can select how rows are defined in the data grid(s). The two available options are

* **Students** : *Each row represents data from one student. This is the default setting*

* **Promise Fellows** : *Each row represents a youth-worker, with each field displaying an aggregate representation of all of the students associated with the youth-worker. (This is mainly used for administrative purposes, with reports containing state-wide data-sets)* 

####2.4 Table Columns 
Using the checkboxes in the center of the window, users can decide which fields are displayed in the columns of the data grid(s). [Click here to see all columns displayed](http://i.imgur.com/AKIFpDd.png). These include:

* **Days Supported** : *Total days that a student has been active in the program. Determined using multiple start- and end- dates, and in most cases, extending to the current date.* 

* **Intervention Min** : *Total minutes of interventions recorded for the student.* 

* **Avg Min per Week** : *Average intervention minutes recorded for the student per week of support period.* 

* **Missing Baseline** : *Total number of baseline data fields--representing student performance prior to receiving support--that have not been recorded for the student.*

* **Improvement Areas** : *Lists the areas in which the student has shown improvement, as defined by the program. A: Attendance; B: Behavior; C: Course Performance.*

* **Days Reported** : *The total number of days that the student has data recorded for.*

* **Service Site** : *The name of the site at which the student is receiving support.*

* **Promise Fellow** : *The name of the youth-worker that is providing the student with support.*
 
####2.5 Show Inactive Youth
If this is checked, students who are marked as inactive will be displayed in the data grid(s), if it is not checked, inactive students will be excluded. 

##3. Report Window
![alt tag](http://i.imgur.com/9eADQnc.png)

####3.1 Overview
The Report Window is displayed upon selecting an individual student from the Main Window. 

####3.2 Baseline, YTD / Month numbers
At the bottom of the window, performance numbers are displayed for the student both for the baseline period (i.e. the period prior to the student entering the program) and for the 'YTD' period, which is calculated using all of the data recorded for the student since he/she entered the program. Data recorded for just the month of the report being analyzed can be used instead by clicking on 'YTD' and selecting 'Month.' 

####3.3 Change stats
The third column of the table displays the percent change between the student's baseline and current (YTD or Month) data. This is calculated using the following formula: (current - baseline) / baseline. Whether the change field is displayed in red or green is determined by whether or not the change is counted as improvement according to the program. 

####3.4 Missing baseline data
![alt tag](http://i.imgur.com/Vp2Kbcp.png) 

The example above demonstrates how missing baseline data is reported in the report window. This student is missing all baseline fields.


##4. Error Logging 
![alt tag](http://i.imgur.com/OYlr1ti.png) ![alt tag](http://i.imgur.com/8vFs7vY.png)

####4.1 Overview
If a student xml report fails to load, the window on the left is displayed to the user. The user may either save a **file** containing the exception details, send an **email** containing the exception details (using SmtpClient), or both. If the user decides to email the exception details, he/she can include a message by clicking 'attach msg.' The user's message is entered into the window, displayed on the right.
