using System;
namespace ConsoleApplication1
{
    public class DataStudy
    {
        private String _faculty;
        private String _degree;
        private int _year;

        public DataStudy(String faculty, String degree, int year)
        {
            this._faculty = faculty;
            this._degree = degree;
            this._year = year;
        }
        public string Faculty
        {
            get => _faculty;
            set => _faculty = value;
        }

        public string Degree
        {
            get => _degree;
            set => _degree = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

      
        

     
    }
}
