// Name: Maxwell Ahmadi
// Date: 01/19/2023
// Project: Deliverable #2
// Description: This C# Console application code will provide the letter grade for a student, based on their numeric grade.


using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expected numeric grade for the ISM 4300 class: ");

            try
            {
                decimal numberGrade = decimal.Parse(Console.ReadLine());

                string letterGrade;

                if (numberGrade > 100)
                {
                    Console.WriteLine("Your expected letter grade for ISM 4300 is over 100!");
                    Console.ReadKey(true);
                }

                else if (numberGrade >=90)
                {
                    letterGrade = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 " +
                        "is a " + String.Format("{0:C}", letterGrade));
                    Console.ReadKey(true);
                }

                else if (numberGrade >=80 && numberGrade < 90)
                {
                    letterGrade = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 " +
                        "is a " + String.Format("{0:C}", letterGrade));
                    Console.ReadKey(true);
                }

                else if (numberGrade >= 70 && numberGrade < 80)
                {
                    letterGrade = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 " +
                        "is a " + String.Format("{0:C}", letterGrade));
                    Console.ReadKey(true);
                }

                else if (numberGrade >=60 && numberGrade < 70)
                {
                    letterGrade = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 " +
                        "is a " + String.Format("{0:C}", letterGrade));
                    Console.ReadKey(true);
                }

                else if (numberGrade < 60)
                {
                    letterGrade = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 " +
                        "is a " + String.Format("{0:C}", letterGrade));
                    Console.ReadKey(true);
                }

            } // End of try statement

            catch
            {
                Console.WriteLine("Use the decimal data type for the numeric grade!");
                Console.ReadKey(true);
            } // End of catch statement
        }
    }
}
