﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave tilføj en Console.writeline med noget tekst og commit + push
            //se herefter på dit GitHub Classroom repo om ændringen er kommet op 
            demo ProgrammingClassDemo = new demo();
            ProgrammingClassDemo.ClassName = "Programming";
            ProgrammingClassDemo.TeacherName = "Martin";

            Console.WriteLine($"I'm sitting on a {ProgrammingClassDemo.TeacherName} class. The lecturer is {ProgrammingClassDemo.TeacherName} ");
            Console.ReadKey();
        }
    }
}
