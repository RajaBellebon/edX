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

        public static Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>> getDegree(string degreeName, int degreeCredit)
        {
            Degrees DegreeInfo = new Degrees();
            Course courseInfo = new Course();
            
            Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>> degreeInformation = new Dictionary<Tuple<string, int>, Dictionary<string, Tuple<string[], string[]>>>();
            degreeInformation.Add(Tuple.Create(DegreeInfo.DegreesName, DegreeInfo.DegreesCredit), Course.getCourse(courseInfo.courseName,courseInfo.StudentArr,courseInfo.TeachArr));
            
            return degreeInformation;
        }
    }
}
