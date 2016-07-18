using System;

namespace edXCourse
{
    public class Teacher
    {
        // Properties
        public string TeacherFirstName { get; set; }
        public string TeacherFamilyName { get; set; }

        // Constructors
        public Teacher(string teacherFirstName, string teacherFamilyName)
        {
            this.TeacherFirstName = teacherFirstName;
            this.TeacherFamilyName = teacherFamilyName;
        }

        public Teacher()
        {
        }

        public static String[] getTeacher(string teacherFirstName, string teacherFamilyName)
        {
            Teacher teacher = new Teacher();
            string[] arrTeacher = {teacher.TeacherFirstName, teacher.TeacherFamilyName};
            return arrTeacher;
        }
    }
}
