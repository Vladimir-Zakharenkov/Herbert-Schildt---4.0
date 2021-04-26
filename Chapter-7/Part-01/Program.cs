#region Russian

// 7 ГЛАВА

//Массивы и строки

// В этой главе речь вновь пойдет о типах данных в С#.
// В ней рассматриваются массивы и тип string, а также
// оператор цикла foreach.

// Массивы

// Массив представляет собой совокупность переменных
// одного типа с общим для обращения к ним именем.
// В C# массивы могут быть как одномерными, так и многомерными,
// хотя чаще всего применяются одномерные массивы.
// Массивы служат самым разным целям, поскольку они предоставляют
// удобные средства для объединения связанных
// вместе переменных. Например, в массиве можно хранить
// максимальные суточные температуры, зарегистрированные
// в течение месяца, перечень биржевых курсов или же названия
// книг по программированию из домашней библиотеки.

// Главное преимущество массива — в организации данных
// таким образом, чтобы ими было проще манипулировать.
// Так, если имеется массив, содержащий дивиденды, выплачиваемые
// по определенной группе акций, то, организовав
// циклическое обращение к элементам этого массива, можно
// без особого труда рассчитать средний доход от этих акций.
// Кроме того, массивы позволяют организовать данные таким
// образом, чтобы легко отсортировать их.

// Массивами в C# можно пользоваться практически так
// же, как и в других языках программирования. Тем не менее
// у них имеется одна особенность: они реализованы в виде
// объектов. Именно поэтому их рассмотрение было отложено
// до тех пор, пока в этой книге не были представлены
// объекты.Реализация массивов в виде объектов дает ряд существенных преимуществ,
// и далеко не самым последним среди них является возможность утилизировать неиспользуемые
// массивы средствам "сборки мусора".

// Одномерные массивы

// Одномерный массив представляет собой список связанных переменных. Такие списки
// часто применяются в программировании. Например, в одномерном массиве можно
// хранить учетные номера активных пользователей сети или текущие средние уровни
// достижений бейсбольной команды.

// Для того чтобы воспользоваться массивом в программе, требуется двухэтапная процедура,
// поскольку в C# массивы реализованы в виде объектов. Во-первых, необходимо
// объявить переменную, которая может обращаться к массиву. И во-вторых, нужно создать
// экземпляр массива, используя оператор new. Так, для объявления одномерного
// массива обычно применяется следующая общая форма:

// тип[] имя_массива = new тип[размер];

// где тип объявляет конкретный тип элемента массива. Тип элемента определяет тип
// данных каждого элемента, составляющего массив. Обратите внимание на квадратные
// скобки, которые сопровождают тип. Они указывают на то, что объявляется одномерный
// массив. А размер определяет число элементов массива.

// ПРИМЕЧАНИЕ
// Если у вас имеется некоторый опыт программирования на С или C++, обратите особое
// внимание на то, как объявляются массивы в С#. В частности, квадратные скобки следуют
// после названия типа, а не имени массива.

// Обратимся к конкретному примеру. В приведенной ниже строке кода создается
// массив типа int, который составляется из десяти элементов и связывается с переменной
// ссылки на массив, именуемой sample.

// int[] sample = new int[10];

// В переменной sample хранится ссылка на область памяти, выделяемой для массива
// оператором new.Эта область памяти должна быть достаточно большой, чтобы в ней
// могли храниться десять элементов массива типа int.

// Как и при создании экземпляра класса, приведенное выше объявление массива
// можно разделить на два отдельных оператора. Например:

// int[] sample;
// sample = new int[10];

// В данном случае переменная sample не ссылается на какой-то определенный физический
// объект, когда она создается в первом операторе. И лишь после выполнения
// второго оператора эта переменная ссылается на массив.

// Доступ к отдельному элементу массива осуществляется по индексу: Индекс обозначает
// положение элемента в массиве. В языке C# индекс первого элемента всех массивов
// оказывается нулевым. В частности, массив sample состоит из 10 элементов с индексами
// от 0 до 9. Для индексирования массива достаточно указать номер требуемого элемента
// в квадратных скобках. Так, первый элемент массива sample обозначается как
// sample [0], а последний его элемент — как sample[9]. Ниже приведен пример программы,
// в которой заполняются все 10 элементов массива sample.

//Продемонстрировать одномерный массив.
using System;

class ArrayDemo
{
    static void Main()
    {
        int[] sample = new int[10];
        int i;

        for (i = 0; i < 10; i = i + 1)
        {
            sample[i] = i;
        }

        for (i = 0; i < 10; i = i + 1)
        {
            Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// sample[0]: 0
// sample[1]: 1
// sample[2]: 2
// sample[3]: 3
// sample[4]: 4
// sample[5]: 5
// sample[6]: 6
// sample[7]: 7
// sample[8]: 8
// sample[9]: 9

#endregion

#region English

// 7 CHAPTER

// Arrays and Strings

// This chapter returns to the subject of C#’s data types. It discusses arrays and the string
// type. The foreach loop is also examined.

// Arrays

// An array is a collection of variables of the same type that are referred to by a common name.
// In C#, arrays can have one or more dimensions, although the one-dimensional array is the
// most common. Arrays are used for a variety of purposes because they offer a convenient
// means of grouping together related variables. For example, you might use an array to hold
// a record of the daily high temperature for a month, a list of stock prices, or your collection
// of programming books.

// The principal advantage of an array is that it organizes data in such a way that it can
// be easily manipulated. For example, if you have an array containing the dividends for a
// selected group of stocks, it is easy to compute the average income by cycling through the
// array. Also, arrays organize data in such a way that it can be easily sorted.
// Although arrays in C# can be used just like arrays in many other programming languages,
// they have one special attribute: They are implemented as objects. This fact is one reason that
// a discussion of arrays was deferred until objects had been introduced. By implementing
// arrays as objects, several important advantages are gained, not the least of which is that
// unused arrays can be garbage-collected.

// One-Dimensional Arrays

// A one-dimensional array is a list of related variables. Such lists are common in programming.
// For example, you might use a one-dimensional array to store the account numbers of the
// active users on a network. Another array might store the current batting averages for a
// baseball team.

// Because arrays in C# are implemented as objects, two steps are needed to obtain an
// array for use in your program. First, you must declare a variable that can refer to an array.
// Second, you must create an instance of the array by use of new.Therefore, to declare a onedimensional
// array, you will typically use this general form:

//type[] array-name = new type[size];

// Here, type declares the element type of the array. The element type determines the data type
// of each element that comprises the array. Notice the square brackets that follow type. They
// indicate that a one-dimensional array is being declared. The number of elements that the
// array will hold is determined by size.

// NOTE If you come from a C or C++ background, pay special attention to the way arrays are
// declared. Specifically, the square brackets follow the type name, not the array name.

// Here is an example. The following creates an int array of ten elements and links it to an
// array reference variable named sample.

// int[] sample = new int[10];

// The sample variable holds a reference to the memory allocated by new.This memory is
// large enough to hold ten elements of type int.
// As is the case when creating an instance of a class, it is possible to break the preceding
// declaration in two. For example:

// int[] sample;
// sample = new int[10];

// In this case, when sample is first created, it refers to no physical object. It is only after the
// second statement executes that sample refers to an array.

// An individual element within an array is accessed by use of an index. An index describes
// the position of an element within an array.In C#, all arrays have 0 as the index of their first
// element.Because sample has 10 elements, it has index values of 0 through 9. To index an
// array, specify the number of the element you want, surrounded by square brackets. Thus,
// the first element in sample is sample[0], and the last element is sample[9]. For example, the
// following program loads sample with the numbers 0 through 9:

// Demonstrate a one-dimensional array. 

// using System; 

// class ArrayDemo
// {
//    static void Main()
//    {
//        int[] sample = new int[10];
//        int i;

//        for (i = 0; i < 10; i = i + 1)
//            sample[i] = i;

//        for (i = 0; i < 10; i = i + 1)
//            Console.WriteLine("sample[" + i + "]: " + sample[i]);
//    }
// }

// The output from the program is shown here:

// sample[0]: 0
// sample[1]: 1
// sample[2]: 2
// sample[3]: 3
// sample[4]: 4
// sample[5]: 5
// sample[6]: 6
// sample[7]: 7
// sample[8]: 8
// sample[9]: 9

#endregion