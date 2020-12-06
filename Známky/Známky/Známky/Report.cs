using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UtilitiesMain;

namespace UtilitiesMain
{
    class Report
    {
        public string PathtoFile { get; set; }

        
        public Report(string path)
        {
            this.PathtoFile = path;
        }

        public List<Student> list()
        {
            StreamReader sr = null;
            List<Student> studentlist = new List<Student>();
            sr = new StreamReader(PathtoFile);
            while (!sr.EndOfStream)
            {
                string[] split = sr.ReadLine().Split(',');
                Student studentfromfile = new Student(split[0], split[2], Predmet(split[1]), Convert.ToInt32(split[3]));
                studentlist.Add(studentfromfile);
            }
            return studentlist;           
        }

        public Subjects Predmet(string predmet)
        {
            switch (predmet)
            {
                case "ČJ": return Subjects.Čeština;                
                case "AJ": return Subjects.Angličtina;
                case "M": return Subjects.Matika;
                case "Bi": return Subjects.Biologie;
                case "Děj": return Subjects.Dějepis;
                case "Zem": return Subjects.Zeměpis;
            }
            return Subjects.Čeština;
        }
               
        public List<StudentsBook> Serazenylist()
        {
            List<Student> seznam = list();
            List<StudentsBook> bakalar = new List<StudentsBook>();
    
            var studentsgrouped = seznam.GroupBy(zak => new { zak.Name, zak.Subject});   
            foreach (var group in studentsgrouped)
            {           
                List<int> znamky = new List<int>();
                foreach (var zak in group)
                {     
                    if(group.Key.Subject == zak.Subject)
                    {
                        znamky.Add(zak.Mark);    
                    } 
                }
                StudentsBook znamka = new StudentsBook(group.Key.Name, group.Key.Subject,znamky);
                bakalar.Add(znamka);
            }
            return bakalar ;
        }

        public void Průměr()
        {
            List<StudentsBook> finalreport = Serazenylist();          
            List<string> names = new List<string>();
            foreach(StudentsBook k in finalreport)
            {
                bool studentexists = false;
                foreach(string jmeno in names)
                {
                    if(k.Name == jmeno)
                    {
                        studentexists = true;
                    }
                }
                if(studentexists == false)
                {
                    names.Add(k.Name);
                }
                
            }
                     
           foreach(string jmeno in names)
           {
                Console.WriteLine("-----------------------");
                Console.WriteLine(jmeno);
                Console.WriteLine("-----------------------");
                double finalavg = 0;
                int entries = 0;
                double midavg = 0;
                bool mark = false;
                bool markgenius = false;
                foreach(StudentsBook students in finalreport)
                {
                    if(students.Name == jmeno)
                    {
                        Console.Write($"{students.Subject}: ");
                        Console.WriteLine(students.RoudedAvgSubject());
                        finalavg += students.RoudedAvgSubject();
                        entries++;
                        midavg = students.RoudedAvgSubject();
                        if(midavg >= 3)
                        {
                            markgenius = true;

                        }

                        if(midavg == 5)
                        {
                            mark = true;

                        }
                    }

                }
                Console.WriteLine("Pruměr: " + Math.Round((finalavg / entries),3));

                double avgfinal = finalavg / entries;
                if(avgfinal >=1.5 && mark == false)
                {
                    Console.WriteLine("Prospěl/a");

                }
                if(avgfinal < 1.5 && markgenius == false)
                {
                    Console.WriteLine("Prospěl/a s vyznamenanim");

                }
                if(mark == true)
                {
                    Console.WriteLine("Neprospěl/a");

                }
           }
           
        }

    }
}
