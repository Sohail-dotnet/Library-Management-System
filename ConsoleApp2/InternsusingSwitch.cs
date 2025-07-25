using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InternsusingSwitch
    {
        public static void Interns2()
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Enter a Inter Name: ");
            string intername = Console.ReadLine().ToLower();

            switch (intername)
            {
                case "prathap":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "rohit":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "aankitha":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "paramesh":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "ramprasad":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "amarnath":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "chaitanya":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "abhinav":
                    Console.WriteLine("Prapunj Sir Student");
                    break;
                case "sohail":
                    Console.WriteLine("Hemant Sir Student");
                    break;
                case "rohit rathod":
                    Console.WriteLine("Hemant sir Student");
                    break;
                case "mahadev":
                    Console.WriteLine("Hemant sir Student");
                    break;
                case "karthik":
                    Console.WriteLine("Hemant sir Student");
                    break;
                case "srinivasulu":
                    Console.WriteLine("Hemant sir Student");
                    break;
                case "yeswanth":
                    Console.WriteLine("Hemant sir Student");
                    break;
                case "naresh":
                    Console.WriteLine("Hemant sir Student");
                    break;
                default: Console.WriteLine("Enter a Valid Inter Name");
                    break;

            }


            DateTime end = DateTime.Now;
            TimeSpan res = end - start;
            Console.WriteLine(res);

        }

    }
}
