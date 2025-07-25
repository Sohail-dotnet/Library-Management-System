using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InternsusingIf
    {
        public static void Interns()
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Enter a Intern Name");
            String name = Console.ReadLine().ToLower();

            if(name == "Prathap".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if(name == "Rohit".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if( name == "Aankitha".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if (name == "Paramesh".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if (name == "Ramprasad".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if (name == "Amarnath".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if (name == "Chaitanya".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if(name == "abhinav".ToLower())
            {
                Console.WriteLine("Prapunj sir Student");
            }
            else if (name == "Sohail".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Rohit Rathod".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Mahadev".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Karthik".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Srinivasulu".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Yeswanth".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else if (name == "Naresh".ToLower())
            {
                Console.WriteLine("Hemant sir Student");
            }
            else
            {
                Console.WriteLine("Intern name is invalid");
            }

            DateTime end = DateTime.Now;

            TimeSpan res = end - start;
            Console.WriteLine(res);
        }
       
    }
}
