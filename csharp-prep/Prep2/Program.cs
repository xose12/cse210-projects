using System;

class Program
{
    static void Main(string[] args)
    {
        //  grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        // variables for letter grade and grade sign
        string letterGrade = "";
        string gradeSign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // if the grade has a "+" or "-" sign
        if (letterGrade != "F") // No plus/minus for F
        {
            int lastDigit = gradePercentage % 10;
            
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit < 3)
            {
                gradeSign = "-";
            }
            else
            {
                gradeSign = ""; // No sign
            }
        }

        // Print the grade with sign (if any)
        string finalGrade = letterGrade + gradeSign;
        Console.WriteLine("Your grade is: " + finalGrade);

        // Check if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep going! Better luck next time.");
        }
    }
}
