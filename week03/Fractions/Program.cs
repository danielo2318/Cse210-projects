using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear fracciones con los tres constructores
        Fraction f1 = new Fraction();         // 1/1
        Fraction f2 = new Fraction(5);        // 5/1
        Fraction f3 = new Fraction(3, 4);     // 3/4
        Fraction f4 = new Fraction(1, 3);     // 1/3

        // Mostrar fracciones y su valor decimal
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Verificar getters y setters
        Console.WriteLine("\nPrueba de setters y getters:");
        f3.SetTop(7);
        f3.SetBottom(8);
        Console.WriteLine($"Nueva fracción: {f3.GetFractionString()}");
        Console.WriteLine($"Valor decimal: {f3.GetDecimalValue()}");
        Console.WriteLine($"Top: {f3.GetTop()}, Bottom: {f3.GetBottom()}");
    }
}
