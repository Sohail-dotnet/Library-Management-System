using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ListPrograms
{
    public class InternNames
    {
        public static void Details()
        {
            List<string> Names = new List<string>();

            // To add elements
            Names.Add("Sohail");
            Names.Add("Rohit");
            Names.Add("Mahadev");
            Names.Add("Karthik");
            Names.Add("Srinu");

        // To access elements 
            Console.WriteLine(Names[3]);
            Console.WriteLine(Names[4]);

            // To print whole List elements
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

       //to count elements 
       Console.WriteLine(Names.Count);


            // to Remove elements in List 
            Console.WriteLine(Names.Remove("Mahadev"));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

        } 



    }
}
