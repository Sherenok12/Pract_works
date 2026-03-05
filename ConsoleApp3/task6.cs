using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public delegate bool Validator(string input);

    static Validator GetValidator(int minLength)
    {
        return input => input.Length >= minLength;
    }

    static void Main()
    {
        Validator passwordValidator = GetValidator(8);
        Validator loginValidator = GetValidator(3);   

        string[] passwords = { "qwerty", "qwerty123", "123456" };
        string[] logins = { "Sasha", "Pasha", "Masha" };

        Console.WriteLine("Перевірка паролів:");
        foreach (var pwd in passwords)
        {
            Console.WriteLine($"{pwd}: {passwordValidator(pwd)}");
        }

        Console.WriteLine("\nПеревірка логінів:");
        foreach (var login in logins)
        {
            Console.WriteLine($"{login}: {loginValidator(login)}");
        }
    }
}
