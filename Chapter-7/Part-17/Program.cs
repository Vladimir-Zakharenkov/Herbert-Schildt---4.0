#region Russian

// Оператор цикла foreach можно также использовать для циклического обращения
// к элементам многомерного массива. В этом случае элементы многомерного массива
// возвращаются по порядку следования строк от первой до последней, как демонстрирует
// приведенный ниже пример программы.

//Использовать оператор цикла foreach для обращения к двумерному массиву.
using System;

class ForeachDemo2
{
    static void Main()
    {
        int sum = 0;
        int[,] nums = new int[3, 5];

        //Задать первоначальные значения элементов массива типа nums.
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                nums[i, j] = (i + 1) * (j + 1);
            }
        }

        //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы.
        foreach (int x in nums)
        {
            Console.WriteLine("Значение элемента равно: " + x);
            sum += x;
        }

        Console.WriteLine("Сумма равна: " + sum);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этой программы дает следующий результат.

// Значение элемента равно: 1
// Значение элемента равно: 2
// Значение элемента равно: 3
// Значение элемента равно: 4
// Значение элемента равно: 5
// Значение элемента равно: 2
// Значение элемента равно: 4
// Значение элемента равно: 6
// Значение элемента равно: 8
// Значение элемента равно: 10
// Значение элемента равно: 3
// Значение элемента равно: 6
// Значение элемента равно: 9
// Значение элемента равно: 12
// Значение элемента равно: 15
// Сумма равна: 90

#endregion

#region English

// The foreach loop also works on multidimensional arrays.It returns those elements in
// row order, from first to last.

// Use foreach on a two-dimensional array. 
// using System; 

// class ForeachDemo2
// {
//    static void Main()
//    {
//        int sum = 0;
//        int[,] nums = new int[3, 5];

//        // Give nums some values. 
//        for (int i = 0; i < 3; i++)
//            for (int j = 0; j < 5; j++)
//                nums[i, j] = (i + 1) * (j + 1);

//        // Use foreach to display and sum the values. 
//        foreach (int x in nums)
//        {
//            Console.WriteLine("Value is: " + x);
//            sum += x;
//        }
//        Console.WriteLine("Summation: " + sum);
//    }
// }

// The output from this program is shown here:

// Value is: 1
// Value is: 2
// Value is: 3
// Value is: 4
// Value is: 5
// Value is: 2
// Value is: 4
// Value is: 6
// Value is: 8
// Value is: 10
// Value is: 3
// Value is: 6
// Value is: 9
// Value is: 12
// Value is: 15
// Summation: 90

#endregion