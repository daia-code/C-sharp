using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    class Data_uni
    {
        private int year_study;
        private String study_subject;
        private String university;

   

        public int Year_study { get => year_study; set => year_study = value; }
        public string Study_subject { get => study_subject; set => study_subject = value; }
        public string University { get => university; set => university = value; }

        public Data_uni Add_Data()
        {
            Data_uni data = new Data_uni();
            Console.WriteLine("Enter the year of study:");
            int year = Int16.Parse(Console.ReadLine());
            data.Year_study = year;
            Console.WriteLine("Enter the study subject:");
            String subject = Console.ReadLine();
            data.Study_subject = subject;
            Console.WriteLine("Enter the university:");
            String university = Console.ReadLine();
            data.University = university;
            return data;
        }
       
    }
}
