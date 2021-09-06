using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 1;
            int excludet = 0;
            double evaluation = 0;
            while (true)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    evaluation += grade;

                    if (clas == 12)
                    {
                        evaluation = evaluation / 12;
                        Console.WriteLine($"{name} graduated. Average grade: {evaluation:F2}");
                        break;
                    }
                }

                else
                {
                    excludet++;

                    if (excludet > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas - 1} grade");
                        break;
                    }
                }

                clas++;
            }
        }
    }
}
