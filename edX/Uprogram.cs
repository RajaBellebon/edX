using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edXCourse
{
    class Uprogram
    {
        // Properties
        public string ProgramName { get; set; }

        // Constructors
        public Uprogram(string programName)
        {
            this.ProgramName = programName;            
        }

        public Uprogram()
        {
        }

        public static List<Tuple<string, string, int>> getUprogram(string programName)
        {
            Uprogram theme = new Uprogram();
            Degrees degree = new Degrees();
            List<Tuple<string, string, int>> listProgram = new List<Tuple<string, string,int>> ();
            listProgram.Add(Tuple.Create(theme.ProgramName, degree.DegreesName, degree.DegreesCredit));
            return listProgram;
        }

    }
}
