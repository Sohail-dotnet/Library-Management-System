using ConsoleApp2.LibraryManagementSystem.Services;
using ConsoleApp2.LibraryManagementSystem.Models;
using ConsoleApp2.ListPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MAINMETHOD
    {
        static void Main(string[] args)
        {

                // LIBRARY MANAGEMENT SYSTEM 
                Console.WriteLine("Welcome to the Library Management System");
                Console.WriteLine("-----------------------------------------");
                //Object Creation for BookSerivce Class
                BookService bookService = new BookService();

                //Giving Access to the filePath of the book.json data file
                string filePath = @"C:\Users\VSOFT\source\repos\ConsoleApp2\ConsoleApp2\LibraryManagementSystem\Books.json";

                //Reading Books Data from Json File 
                bookService.LoadBooksFromJson(filePath);
                //Showing Books Data 
                bookService.ViewBooks();
                                 Console.WriteLine("====================================");
                //Object Creation for MemberSerivce Class
                MemberService memberService = new MemberService();

                //Giving Access to the filePath of the member.json data file
                string filePath2 = @"C:\Users\VSOFT\source\repos\ConsoleApp2\ConsoleApp2\LibraryManagementSystem\members.json";

                //Reading Members Data from Json File 
                memberService.LoadMembersFromJson(filePath2);
                // Showing Members Data
                memberService.ViewMembers();


            //  Practice2.ans();


            //    Person person = new Person();
            //    string json = JsonSerializer.Serialize(person);
            //    Console.WriteLine(json);

            //    //Date and Time 
            //    DateandTime.info();


            // Serialization of Object to string 
            //Jsonserialization js = new Jsonserialization
            //        {
            //            name = " sohail",
            //            product = "Moblie",
            //            phoneNo = 6301310871
            //        };
            //        string json2 = JsonSerializer.Serialize(js);
            //        Console.WriteLine(json2);

            //        // DeSerialization of String into Object 
            //        string jds = "{\"name\":\"chris\",\"age\":10}";
            //        Jsondeserialization newjs = JsonSerializer.Deserialize<Jsondeserialization>(jds);
            //        Console.WriteLine($"name:{newjs.name}");
            //        Console.WriteLine($"age:{newjs.age}");

            // Interns program using IF
            //InternsusingIf.Interns();

            // Interns Program using Switch
            //InternsusingSwitch.Interns2();

            // Json file saving and serializing 
            //string filepath = @"C:\Users\VSOFT\source\repos\ConsoleApp2\ConsoleApp2\Interndata.json";
            //string file = File.ReadAllText(filepath);

            //InternDetails id = JsonSerializer.Deserialize<InternDetails>(file);
            //Console.WriteLine("Getting details of interns");
            //Console.WriteLine($"Name:{id.name}");
            //Console.WriteLine($"Name:{id.id}");
            //Console.WriteLine($"Name:{id.reportingManager}");

            // List Programs

            //InternNames.Details();


        }
    }
}
