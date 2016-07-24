using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>> getDegree(string degreeName, int degreeCredit, string courseName, string[] studentArr, string[] teacherArr)
        {
            Degrees DegreeInfo = new Degrees();

            Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>> degreeInformation = new Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>>();
            Dictionary<string, Tuple<string[], string[]>> courseDict = new Dictionary<string, Tuple<string[], string[]>>();
            courseDict = Course.getCourse(courseName, studentArr, teacherArr);
            degreeInformation.Add(Tuple.Create(DegreeInfo.DegreesName, DegreeInfo.DegreesCredit),courseDict);
            
            return degreeInformation;
        }
    }
}
