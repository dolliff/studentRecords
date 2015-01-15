using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentRecords
{
    class student
    {
        private string _firstName;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private int _grade;

        public int grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public override string ToString()
        {
            return _firstName + " " + _grade.ToString();
        }
        
    }
}
