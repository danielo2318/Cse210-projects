using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the Exercise2 Project.");

    Console.Write("Please write your grade percentage ");
    string grade = Console.ReadLine();
    int gradePercentage = int.Parse(grade);

    string letter = "";

     if (gradePercentage >= 90)
    {
      letter = "A";
    }
    else if (gradePercentage >= 80)
    {
      letter = "B";
    }
    else if (gradePercentage >= 70)
    {
      letter = "C";
    }
    else if (gradePercentage >= 60)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }

    Console.WriteLine($"Your grade is: {letter}");

     if (gradePercentage >= 70)
    {
      Console.Write("Congratulations! you passed the class!");
    }
    else
    {
      Console.Write("Sorry you didn't pass the class, but try again! I know we can do it better next time! ");
    } 

    
  }
}