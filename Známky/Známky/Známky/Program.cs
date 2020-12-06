using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtilitiesMain
{
    class Program
    {
        static void Main(string[] args)
        {

            Report spust = new Report(@"C:\Users\stand\Documents\C# Utilities\Známky\students-marks_v03.csv");
            spust.Průměr();

            Console.ReadKey(true);


        }
    }
}    

