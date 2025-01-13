using System;

class Program
{
    static void Main(string[] args)
    {
        //asking for their grade percentage
        Console.Write("Enter your grade percentage ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        //Letter grade
        string Letter = "";

        if (gradePercentage >= 90)
        {
            Letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            Letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            Letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        //print the letter grade
        Console.WriteLine($"Your letter grade is: {Letter}");

        //cheking if you passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed the course");
        }
        else
        {
           Console.WriteLine("Sorry, you did not pass the course");
        }
    



    }
}