using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Enter Your Age----");
            string age = Console.In.ReadLine();
            int int_age = int.Parse(age);
            int yearOfBirh = 2021 - int_age;
            Console.WriteLine("----Year Of Birth----");
            Console.WriteLine(yearOfBirh);

        }
    }
}
