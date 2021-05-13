#region Russian

// Применение свойства Length

// Реализация в C# массивов в виде объектов дает целый ряд преимуществ. Одно из
// них заключается в том, что с каждым массивом связано свойство Length, содержащее
// число элементов, из которых может состоять массив. Следовательно, у каждого массива
// имеется специальное свойство, позволяющее определить его длину. Ниже приведен
// пример программы, в которой демонстрируется это свойство.

//Использовать свойство Length массива.
using System;

class LengthDemo
{
    static void Main()
    {
        int[] nums = new int[10];

        Console.WriteLine("Длина массива nums равна " + nums.Length);

        //Использовать свойство Length для инициализации массива nums.
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i * i;
        }

        //А теперь воспользоваться свойством Length для вывода содержимого массива nums.
        Console.Write("Содержимое массива nums: ");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// Длина массива nums равна 10
// Содержимое массива nums: 0 1 4 9 16 25 36 49 64 81

// Обратите внимание на то, как в классе LengthDemo свойство nums.Length используется
// в циклах for для управления числом повторяющихся шагов цикла. У каждого
// массива имеется своя длина, поэтому вместо отслеживания размера массива вручную
// можно использовать информацию о его длине. Следует, однако, иметь в виду, что значение
// свойства Length никак не отражает число элементов, которые в нем используются
// на самом деле. Свойство Length содержит лишь число элементов, из которых
// может состоять массив.

#endregion

#region English


// Using the Length Property

// A number of benefits result because C# implements arrays as objects. One comes from the
// fact that each array has associated with it a Length property that contains the number of
// elements that an array can hold. Thus, each array provides a means by which its length can
// be determined. Here is a program that demonstrates this property:

// Use the Length array property.  

// using System; 

// class LengthDemo
// {
//    static void Main()
//    {
//        int[] nums = new int[10];

//        Console.WriteLine("Length of nums is " + nums.Length);

//        // Use Length to initialize nums. 
//        for (int i = 0; i < nums.Length; i++)
//            nums[i] = i * i;

//        // Now use Length to display nums. 
//        Console.Write("Here is nums: ");
//        for (int i = 0; i < nums.Length; i++)
//            Console.Write(nums[i] + " ");

//        Console.WriteLine();
//    }
// }

// This program displays the following output:

// Length of nums is 10
// Here is nums: 0 1 4 9 16 25 36 49 64 81

// In LengthDemo notice the way that nums.Length is used by the for loops to govern the
// number of iterations that take place. Since each array carries with it its own length, you can
// use this information rather than manually keeping track of an array’s size. Keep in mind
// that the value of Length has nothing to do with the number of elements that are actually in
// use. Length contains the number of elements that the array is capable of holding.

#endregion