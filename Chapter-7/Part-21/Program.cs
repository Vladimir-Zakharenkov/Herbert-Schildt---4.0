#region Russian

// Массивы строк

// Аналогично данным любого другого типа, строки могут быть организованы в массивы.
// Ниже приведен соответствующий пример.

//Продемонстрировать массивы строк.
using System;

class StringArrays
{
    static void Main()
    {
        string[] str = { "Это", "очень", "простой", "тест." };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " ");
        }

        Console.WriteLine("\n");

        //Изменить строку.
        str[1] = "тоже";
        str[3] = "до предела тест!";

        Console.WriteLine("Видоизмененный массив: ");
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " ");
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот какой результат дает выполнение приведенного выше кода.

// Исходный массив:
// Это очень простой тест.

// Видоизмененный массив:
// Это тоже простой до предела тест!

#endregion

#region English

// Arrays of Strings

// Like any other data type, strings can be assembled into arrays. For example:

//Demonstrate string arrays.  
// using System; 

// class StringArrays
// {
//    static void Main()
//    {
//        string[] str = { "This", "is", "a", "test." };

//        Console.WriteLine("Original array: ");
//        for (int i = 0; i < str.Length; i++)
//            Console.Write(str[i] + " ");
//        Console.WriteLine("\n");

//        // Change a string. 
//        str[1] = "was";
//        str[3] = "test, too!";

//        Console.WriteLine("Modified array: ");
//        for (int i = 0; i < str.Length; i++)
//            Console.Write(str[i] + " ");
//    }
// }

// Here is the output from this program:

// Original array:
// This is a test.

// Modified array:
// This was a test, too!

#endregion