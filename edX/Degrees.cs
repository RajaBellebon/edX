using System;
using System.Collections;
using System.Collections.Generic;


namespace edXCourse
{
    class Degrees
    {
        // Properties
        public string DegreesName { get; set; }
        public int DegreesCredit { get; set; }

        // Constructors
        public Degrees(string degreeName, int degreeCredit)
        {
            this.DegreesName = degreeName;
            this.DegreesCredit = degreeCredit;
        }

        public Degrees()
        {
        }

        public static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<List<string>, List<string>>>> getDegree(string degreeName, int degreeCredit, string courseName, List<string> studentArr, List<string> teacherArr)
        {
            Degrees DegreeInfo = new Degrees();

            Dictionary<Tuple<string, int>, Dictionary<string, Tuple<List<string>, List<string>>>> degreeInformation = new Dictionary<Tuple<string, int>, Dictionary<string, Tuple<List<string>, List<string>>>>();
            Dictionary<string, Tuple<List<string>, List<string>>> courseDict = new Dictionary<string, Tuple<List<string>, List<string>>>();
            courseDict = Course.getCourse(courseName, studentArr, teacherArr);
            degreeInformation.Add(Tuple.Create(DegreeInfo.DegreesName, DegreeInfo.DegreesCredit),courseDict);
            
            return degreeInformation;
        }
    }
}
