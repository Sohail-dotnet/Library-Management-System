using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DateandTime
    {

       public static void info()
        {

            DateTime mydate = DateTime.Now;
            Console.WriteLine(mydate);
            mydate = mydate.AddDays(20);
            Console.WriteLine(mydate);
            string mystring = mydate.Year.ToString();
            Console.WriteLine(mystring);
            DateTime mydate2 = DateTime.Now;
            DateTime mydate3 = DateTime.Now.AddHours(3000);
            Console.WriteLine(mydate2);
            Console.WriteLine(mydate3);
        } 
    }
}
