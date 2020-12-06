using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain
{
    public class StudentsBook
    {
        public string Name { get; set; }
        public Subjects Subject { get; set; }
        public List<int> Marks { get; set; }

        public StudentsBook(string jmeno, Subjects subject, List<int> marks)
        {
            this.Name = jmeno;
            this.Subject = subject;
            this.Marks = marks;
        }

        public double RoudedAvgSubject()
        {
            var prum = Marks;
            double prumer = Queryable.Average(prum.AsQueryable());
            
            return Math.Round(prumer);
        }

    }
}
