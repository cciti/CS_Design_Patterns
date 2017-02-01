using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Curriculum : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        List<Course> courses;

        courses = DataManager.GetData(@"first_semester.csv");
        AddDataToTable(courses, Table1);

        courses = DataManager.GetData(@"second_semester.csv");
        AddDataToTable(courses, Table2);

        courses = DataManager.GetData(@"third_semester.csv");
        AddDataToTable(courses, Table3);

        courses = DataManager.GetData(@"fourth_semester.csv");
        AddDataToTable(courses, Table4);

    }

    protected void AddDataToTable(List<Course> courses, Table table)
    {
        foreach (Course course in courses)
        {
            //Create a row for the course
            TableRow row = new TableRow();

            //Add strong tag to course number
            string[] courseWords = course.courseName.Split(' ');
            string courseName = "<strong>" + courseWords[0] + "</strong>";
            for (int i = 1; i < courseWords.Length; i++)
            {
                courseName += " " + courseWords[i];
            }

            //Populate the row with data
            TableCell cell1 = new TableCell();
            cell1.Controls.Add(new LiteralControl(courseName));
            row.Controls.Add(cell1);

            TableCell cell2 = new TableCell();
            cell2.Controls.Add(new LiteralControl(course.hours.ToString()));
            row.Controls.Add(cell2);

            //Add the row
            table.Controls.Add(row);
            Debug.WriteLine(course.courseName);
        }
    }
}