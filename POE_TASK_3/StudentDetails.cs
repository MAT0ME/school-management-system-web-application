using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POE_TASK_3
{
    public class StudentDetails
    {
        //private String name, surname;
        public static int mark;
        public static double percentage;
        //private String studentNumber;

        //public string Name { get => name; set => name = value; }
        //public string Surname { get => surname; set => surname = value; }
        public int Mark { get => mark; set => mark = value; }
        public double Percentage { get => percentage; set => percentage = value; }
        //public string StudentNumber { get => studentNumber; set => studentNumber = value; }

        public static string StudentNumber, Name, Surname;
    }
}