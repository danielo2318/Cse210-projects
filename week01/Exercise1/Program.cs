using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the Exercise1 Project.");
    Console.Write("What is your first name? ");
    String name = Console.ReadLine();

    Console.Write("What is your last name? ");
    String lastName = Console.ReadLine();

    Console.Write($"Your name is {name}, {lastName} {name}.");
  }
}