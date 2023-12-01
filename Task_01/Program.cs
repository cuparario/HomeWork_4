/* Задача 1: Напишите программу, которая бесконечно запрашивает целые 
числа с консоли. Программа завершается при вводе символа ‘q’ или при 
вводе числа, сумма цифр которого чётная. */

using System;

class Program 
{
    public static void Main (string[] args) 
    {
        Console.WriteLine("Введите числа или ‘q’ для завершения:");

        while (true) 
        {
            var input = Console.ReadLine();
            if (input == "q") 
            {
                break;
            }
                else if (SumOfDigits(int.Parse(input)) % 2 == 0) 
            {
                Console.WriteLine($"Введенное число {input} имеет четную сумму цифр.");
                break;
            } 
                else 
                {
                    Console.WriteLine($"{input} - число с нечетной суммой цифр. Продолжайте ввод чисел...");
                }  
        }

    }

    static int SumOfDigits (int number) 
    {
        int sum = 0;
        while (number != 0) 
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
