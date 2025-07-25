using ConsoleApp2.LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.Json;

namespace ConsoleApp2.LibraryManagementSystem.Services
{
    public class MemberService
    {
        List<Member> members = new List<Member>();

        public void LoadMembersFromJson(string filePath2)
        {
            if (File.Exists(filePath2))
            {
                string json2 = File.ReadAllText(filePath2);
                List<Member> loadedMembers = JsonSerializer.Deserialize<List<Member>>(json2);
                members.AddRange(loadedMembers);
                Console.WriteLine("Members Loaded from Json");
            }
            else
            {
                Console.WriteLine("Member Not Found :" + filePath2);
            }
        }

        public void ViewMembers()
        {
            Console.WriteLine("Members List : ");
            foreach (var mem in members)
            {
                Console.WriteLine($"ID: {mem.MemberId}, Name: {mem.Name}");
            }
        }

        //public void SearchMember(string filePath2)
        //{
        //    if (File.Exists(filePath2))
        //    {
        //        string json3 = File.ReadAllText(filePath2);
        //        Console.WriteLine("Search by Id or Name or Author Name ");
        //        string search = Console.ReadLine();

        //    }
        //}
    }
}
