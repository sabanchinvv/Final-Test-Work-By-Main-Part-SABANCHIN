// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходный массив строк
        string[] strings = {"Hello GeekBrains", "I Wanna McDonalds", "Ifh", "I Hate Instasamka", "Rose Is The Most Beautiful Flower"};

        // Создаем новый массив куда будем записывать строки длиной не более 3 символов
        string[] shortStrings = new string[strings.Length];
        int count = 0;

        // Проходим по всем элементам исходного массива
        for (int i = 0; i < strings.Length; i++)
        {
            // Если длина строки меньше или равна 3 символам,
            // то добавляем ее в новый массив
            if (strings[i].Length <= 3)
            {
                shortStrings[count] = strings[i];
                count++;
            }
        }

        // Создаем новый массив нужной длины из корректных строк
        string[] resultStrings = new string[count];
        Array.Copy(shortStrings, resultStrings, count);

        // Выводим получившийся массив
        Console.WriteLine("Массив строк длиной не более 3 символов: ");
        foreach (string str in resultStrings)
        {
            Console.WriteLine(str);
        }

        Console.ReadKey();
    }
}