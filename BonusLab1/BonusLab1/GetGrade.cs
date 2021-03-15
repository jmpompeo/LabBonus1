using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab1
{
    public class GetGrade
    {

        public string StudentGrade(int grade)
        {

            Console.WriteLine("Enter a numerical grade");
            var response = int.TryParse(Console.ReadLine(), out grade) ? grade : default;


            if (grade >= 88 && grade <= 100)
            {

                return "Congrats! you got an A";
            }
            else if (grade >= 80 && grade <= 87)
            {

                return "Congrats! You got a B";
            }
            else if (grade >= 67 && grade <= 79)
            {
                return "You got a C";
            }
            else if (grade >= 60 && grade <= 66)
            {
                return "You got a D";
            }
            else if (grade > 0 && grade <= 59)
            {
                return "You got an F";
            }
            else
            {
                throw new ArgumentException();
            }
        }

    }


}

