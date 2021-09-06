using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int projectsNum = int.Parse(Console.ReadLine());
            int time = projectsNum * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {projectsNum} project/s. ");
        }
    }
}
