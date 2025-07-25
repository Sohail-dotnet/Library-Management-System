using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Practice2
    {
        public static void ans()
        {
            int x = 10;
            int y = 20;
            int z = x;
            Console.WriteLine(z);
            x = 20;
            Console.WriteLine(z);

            int[] a = { 1, 2, 3, 4, 5, };
            foreach (int n in a)
            {
                Console.WriteLine(n);
            }

        }

    }
}
