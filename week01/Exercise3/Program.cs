using System;

class Program
{
/*     static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    } */
/*     static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    //la línea int guess = -1; es necesaria para inicializar la variable GUESS antes de usarla en el bloque WHILE, y el valor -1 es simplemente un valor inicial injustificado que garantiza que guee != magicNumber al principio. 
    // ¿Qué significa? int guess =-1; Esto declara una variable entera llamada guess con el valor -1, -1 solo es un valor que seguramente no sera igual a magicNumber que se genere o el usuario ingrese, (ya que se espera que se ingrese un numero positivo)
    //¿Por qué se necesita? El ciclo while tiene la sig condición while (guess != magicNumber), si no se inicializa guess antes del bucle, el compilador mostrará un error, porque guess podría usarse sin haber sido asignado, Usar -1 garantiza que el bucle se ejecuteal menos una vez ya que en ese momento  guess != magicNumber.
    
        int guess = -1;

        while (guess != magicNumber)
    {
      Console.Write("What is your guess? ");
      guess = int.Parse(Console.ReadLine());

      if (magicNumber > guess)
      {
        Console.WriteLine("Higher");
      }
      else if (magicNumber < guess)
      {
        Console.WriteLine("Lower");
      }
      else
      {
        Console.WriteLine("You guessed it!");
      }

    }                    
    } */
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);
    }
}