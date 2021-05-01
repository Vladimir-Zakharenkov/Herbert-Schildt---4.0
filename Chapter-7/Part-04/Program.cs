#region Russian

// Соблюдение границ массива

// Границы массива в C# строго соблюдаются. Если границы массива не достигаются
// или же превышаются, то возникает ошибка при выполнении. Для того чтобы убедиться
// в этом, попробуйте выполнить приведенную ниже программу, в которой намеренно
// превышаются границы массива.

//Продемонстрировать превышение границ массива.
using System;

class ArrayErr
{
    static void Main()
    {
        int[] sample = new int[10];
        int i;

        //Воссоздать превышение границ массива.
        for (i = 0; i < 100; i++)
        {
            sample[i] = i;
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Как только значение переменной i достигает 10, возникнет исключительная ситуация
// типа IndexOutOfRangeException, связанная с выходом за пределы индексирования
// массива, и программа преждевременно завершится. (Подробнее об исключительных
// ситуациях и их обработке речь пойдет в главе 13.)

#endregion

#region English

// Boundaries Are Enforced

// Array boundaries are strictly enforced in C#; it is a runtime error to overrun or underrun
// the ends of an array. If you want to confirm this for yourself, try the following program that
// purposely overruns an array:

// Demonstrate an array overrun. 

// using System; 

// class ArrayErr
// {
//    static void Main()
//    {
//        int[] sample = new int[10];
//        int i;

//        // Generate an array overrun. 
//        for (i = 0; i < 100; i = i + 1)
//            sample[i] = i;
//    }
// }

// As soon as i reaches 10, an IndexOutOfRangeException is generated and the program is
// terminated. (See Chapter 13 for a discussion of exceptions and exception handling.)

#endregion