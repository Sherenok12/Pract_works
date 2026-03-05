using System;

class Task1
{
    delegate double MathOperation(double a, double b);
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ділити на 0 не можна");
            return 0;
        }
        return a / b;
    }

   /* static void Main()
    {
        MathOperation operation;

        double x = 4;
        double y = 2;

        operation = Add;
        Console.WriteLine($"Додавання: {operation(x, y)}");

        operation = Subtract;
        Console.WriteLine($"Віднімання: {operation(x, y)}");

        operation = Multiply;
        Console.WriteLine($"Множення: {operation(x, y)}");

        operation = Divide;
        Console.WriteLine($"Ділення: {operation(x, y)}");
    }*/
}