using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UtilitiesMain
{
    class Student
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public Subjects Subject { get; set; }
        public int Mark { get; set; }

        public Student (string jmeno, string date , Subjects subject , int mark)
        {
            this.Name = jmeno;
            this.Date = date;
            this.Subject = subject;
            this.Mark = mark;
        }
    }
}
