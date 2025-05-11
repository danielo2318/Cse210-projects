using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the Exercise4 Project.");

    List<int> numbers = new List<int>();
    int userNumber;

    do
    {
      Console.WriteLine("Enter a list of numbers, type 0 when finished");
      userNumber = int.Parse(Console.ReadLine());

      if (userNumber != 0)
      {
        numbers.Add(userNumber);
      }
    } while (userNumber != 0);

    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number;
    }
    Console.WriteLine($"The sum is {sum}");

    // El float average = ((float) sum) / numbers.Count; sum se asume que es una variable que contiene la suma de todos los elementos de la coleccion numbers. ((float)sum) es una conversion de tipo Convierte sum (probablemente un entero int) a tipo float, que permite decimales.
    float average = ((float)sum) / numbers.Count; 
    Console.WriteLine($"The average is {average}");
    
    //se inicia con el primer elemento, se toma como punto de partida para comparar los demas valores.
    int max = numbers[0];

    foreach (int number in numbers)
    {
      //Si el numero actual (number) es amyor que el valor almacenado en max, entonces se actualiza max con ese número, asi se asegura que max siempre tenga el valor mas alto encontrado hasta el momento.
      if (number > max)
      {
        max = number;
      }
    }
    Console.WriteLine($"The max number is {max}");


  }
}