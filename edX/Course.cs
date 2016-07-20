using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourse
{
    public class Course
    {
        // Properties
        public List<string> StudentArr { get; set; }
        public string[] TeachArr { get; set; }
        public string courseName { get; set; }

        // Constructors
        public Course(string courseName, List<string> studentArr, string[] teacherArr)
        {
            this.StudentArr = studentArr;
            this.TeachArr = teacherArr;
        }

        public Course()
        {
        }

        public static Dictionary<string, Tuple<List<string>, string[]>> getCourse(string courseName, List<string> studentArr, string[] teacherArr)
        {
            Course course = new Course();
            Dictionary<string, Tuple<List<string>, string[]>> courseDict = new Dictionary<string, Tuple<List<string>, string[]>>();
            course.StudentArr = studentArr;
            course.TeachArr = teacherArr;
            course.courseName = courseName;
            courseDict.Add(courseName, Tuple.Create(studentArr, teacherArr));
            return courseDict;
        }
    }
}
