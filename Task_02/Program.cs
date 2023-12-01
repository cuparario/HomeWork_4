/* Задача 2: Задайте массив заполненный случайными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве. */

using System;

class Program 
{ 
    public static void Main (string[] args) 
    { 
        const int size = 5;

        Random random = new Random();

    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = random.Next(100, 999);

    Console.WriteLine("Сгенерированный массив:");
    foreach(int num in array)
        Console.Write($"{num} ");

    int evenCount = 0;
    foreach(int num in array)
        if(num % 2 == 0)
            evenCount++;

    Console.WriteLine($"Количество четных чисел: {evenCount}");
    }

}

