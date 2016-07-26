using System;
using System.Collections;
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
        public List<string> TeachArr { get; set; }
        public string courseName { get; set; }

        // Constructors
        public Course(string courseName, List<string> studentArr, List<string> teacherArr)
        {
            this.StudentArr = studentArr;
            this.TeachArr = teacherArr;
        }

        public Course()
        {
        }

        public static Dictionary<string, Tuple<List<string>, List<string>>> getCourse(string courseName, List<string> studentArr, List<string> teacherArr)
        {
            Course course = new Course();
            Dictionary<string, Tuple<List<string>, List<string>>> courseDict = new Dictionary<string, Tuple<List<string>, List<string>>>();
            course.StudentArr = studentArr;
            course.TeachArr = teacherArr;
            course.courseName = courseName;
            courseDict.Add(courseName, Tuple.Create(studentArr, teacherArr));
            return courseDict;
        }
    }
}
