using System;

namespace BonusLab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var grade = new GetGrade();

            string input;

            int studentGrade = 0;

            Console.WriteLine("Welcome to the Letter Grade Converter!");

            do
            {
                

                var graded = grade.StudentGrade(studentGrade);
                Console.WriteLine(graded);
                

                Console.WriteLine("Would you like to continue? ");
                input = Console.ReadLine();

            } while (input.Equals("y", StringComparison.OrdinalIgnoreCase));
        }
    }
}
