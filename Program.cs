﻿//Задача. Написать программу, которая из имеющего массива строк формирует массив 
// строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
using System.Linq;
string[] FillArray(string text)
{
    if (text == "") return new string[] {""};
    else
    {    
    string[] textArray = text.Split(" ")
                            .ToArray();
    return textArray;
    }
}

void PrintArray(string[] array)
{
    foreach (string el in array)
    { 
        Console.Write($"{el} ");
        if (array.Length == 0) Console.Write("Проверьте правильность ввода данных");
   }
    Console.WriteLine();
}
