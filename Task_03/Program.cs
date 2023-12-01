/* Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.) */


using System;

class Program
{
    public static void Main(string[] args) 
    {
        int[] array = { 1, 2, 3, 4, 6 };
        ReverseArray(array);
        foreach (int i in array) 
        {
            Console.Write(i + " ");
        }
    }
    private static void ReverseArray(int[] array) 
    {
        for (int i = 0, j = array.Length - 1; i < j; i++, j--) 
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }       
    }

}

