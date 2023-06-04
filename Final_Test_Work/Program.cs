// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



using System;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = { "abc", "3719", "hi", "jklmn", "wtr", "-20" };
        string[] filteredStrings = new string[strings.Length];
        int index = 0;

        foreach (string s in strings)
        {
            if (s.Length <= 3)
            {
                filteredStrings[index] = s;
                index++;
            }
        }

        Array.Resize(ref filteredStrings, index);

        Console.WriteLine("Original Strings:");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("Filtered Strings:");
        foreach (string s in filteredStrings)
        {
            Console.WriteLine(s);
        }
    }
}
