using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int slovedProblemsCount = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTimes++;
                }

                gradeSum += grade;
                slovedProblemsCount++;
                lastProblem = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }

            else
            {
                Console.WriteLine($"Average score: {gradeSum / slovedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {slovedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
