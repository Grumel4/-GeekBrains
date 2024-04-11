using System;
using System.Runtime.CompilerServices;
Public class Program
{
    public static void Main(string[] args)
    {
        //Ввод строк.
        string[] initialstrings = GetInitialStrings();

        //Формирование нового массива
        string[] strings = new string[initialstrings.Length];

        //Вывод результата
        Console.WriteLine("Новый массив:");
        foreach (string str in shortStrings)
        {
            Console.WriteLine(str);
        }
    }
    private static string[] GetInitialStrings();
    {
        //ввод с клавиатуры
        Console.WriteLine("Введите значения через запятую:");
        string input = Console.ReadLine();
        string[] strings = input.Split(',');

        return strings;
    }
private static string[] GetShortStrings(string[] initialStrings)
    {
      int count = 0;
      for (int i = 0; i < initialStrings.Length; i++) 
      {
        if (initialStrings[i].Length <= 3)
        {
          count++;
        }
      }

        string[] shortStrings = new string[count];
        int j = 0;
        for (int i = 0; i < initialStrings.Length; i++)
        {
         if (initialStrings[i].Length <= 3)
        {
            shortStrings[j++] = initialStrings[i];
      }
    }
      return shortStrings;
    }
}