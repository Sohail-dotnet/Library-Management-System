using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Jsonserialization
    {
        public string name { get; set; } 
        public string product { get; set; } 
        public long phoneNo { get; set; } 
    }
}

//public class main
//{
//    static void Main(string[] args)
//    {
//        var js = new Jsonserialization { name = "Sohail", product = "Laptop", phoneNo = 6301310871 };
//        string json = JsonSerializer.Serialize(js);
//        Console.WriteLine(json);
//    }
//}
