#region Russian

// Несмотря на то что цикл foreach повторяется до тех пор, пока не будут опрошены
// все элементы массива, его можно завершить преждевременно, воспользовавшись оператором
// break. Ниже приведен пример программы, в которой суммируются только
// пять первых элементов массива nums.

// Использовать оператор break для преждевременного завершения цикла foreach.
using System;

class ForeachDemo
{
    static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];

        //Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
        }

        //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы.
        foreach (int x in nums)
        {
            Console.WriteLine("Значение элемента равно: " + x);
            sum += x;

            if (x == 4)
            {
                break; //прервать цикл, как только индекс массива достигнет 4
            }
        }

        Console.WriteLine("Сумма первых 5 элементов: " + sum);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот какой результат дает выполнение этой программы.

// Значение элемента равно: 0
// Значение элемента равно: 1
// Значение элемента равно: 2
// Значение элемента равно: 3
// Значение элемента равно: 4
// Сумма первых 5 элементов: 10

// Совершенно очевидно, что цикл foreach завершается после выбора и вывода значения
// пятого элемента массива.

#endregion

#region English

// Although the foreach loop iterates until all elements in an array have been examined, it
// is possible to terminate a foreach loop early by using a break statement.For example, this
// program sums only the first five elements of nums:

// Use break with a foreach. 
// using System; 

// class ForeachDemo
// {
//    static void Main()
//    {
//        int sum = 0;
//        int[] nums = new int[10];

//        // Give nums some values. 
//        for (int i = 0; i < 10; i++)
//            nums[i] = i;

//        // Use foreach to display and sum the values. 
//        foreach (int x in nums)
//        {
//            Console.WriteLine("Value is: " + x);
//            sum += x;
//            if (x == 4) break; // stop the loop when 4 is obtained 
//        }
//        Console.WriteLine("Summation of first 5 elements: " + sum);
//    }
// }

// This is the output produced:

// Value is: 0
// Value is: 1
// Value is: 2
// Value is: 3
// Value is: 4
// Summation of first 5 elements: 10

// As is evident, the foreach loop stops after the fifth element has been obtained.

#endregion