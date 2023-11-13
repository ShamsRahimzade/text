using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHOMETASK2.Models
{
    internal class Student
    {
        public Student(string name, string surname, decimal avgPoint)
        {
            Name = name;
            Surname = surname;
            AvgPoint = avgPoint;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private decimal _avgpoint;

        public decimal AvgPoint
        {
            get { return _avgpoint; }
            set {
                if (value>=0 && value<=100)
                {
                    _avgpoint = value;
                }
            }
        }

    }
}
