using CourseManagementApp.Enums;
using System;

namespace CourseManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[]
            {
                new Group(GroupType.Programming),
                new Group(GroupType.Design),
                new Group(GroupType.System),
                new Group(GroupType.Programming),
                new Group(GroupType.Programming)
            };


            foreach (Group group in groups)
            {
                if(group.Type == GroupType.Programming)
                {
                    Console.WriteLine(group.No);
                }
            }


            Console.WriteLine("Group novu secin:");
            foreach (var item in Enum.GetValues(typeof(GroupType)))
            {
                Console.WriteLine($"{(byte)item} - {item}");
            }

            string optStr;
            byte opt;

            do
            {
                optStr = Console.ReadLine();
            } while (!Byte.TryParse(optStr,out opt) || !Enum.IsDefined(typeof(GroupType),opt));


            GroupType type = (GroupType)opt;

            Console.WriteLine(Enum.GetName(typeof(GroupType), type));

            Group group1 = new Group(type);

            Console.WriteLine(group1.No+" - "+group1.Type);



        }
    }
}
