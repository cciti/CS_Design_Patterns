using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

/// <summary>
/// Summary description for DataManager
/// </summary>
public class DataManager
{

	public DataManager()
	{
	}

    public static List<Course> GetData(string filename)
    {
        string appDirectory = 
            AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
        string fullname = appDirectory + "\\" + filename;

        StreamReader reader = new StreamReader(File.OpenRead(fullname));
        List<Course> courses = new List<Course>();
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] values = line.Split(',');
            Course course = new Course();

            try
            {
                course.courseName = values[0];
                course.hours = Int32.Parse(values[1]);
            }
            catch (FormatException e)
            {
                Debug.WriteLine(e.Message + ": " + values[1]);
                continue;
            }

            courses.Add(course);

        }
    
        return courses;
 
    }
    
}