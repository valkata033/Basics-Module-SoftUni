﻿using System;

namespace _08Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarshipForExcellentResult = Math.Floor(averageGrade * 25);
            double socialScholarship = Math.Floor(0.35 * minimalSalary);

            if (income >= minimalSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResult} BGN");
            }
            else if (income >= minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income < minimalSalary && averageGrade >= 5.5 && socialScholarship <= scholarshipForExcellentResult)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResult} BGN");
            }
            else if (income < minimalSalary && averageGrade < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
