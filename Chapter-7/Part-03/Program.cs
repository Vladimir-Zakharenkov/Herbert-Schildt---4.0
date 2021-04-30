#region Russian

// Инициализация массива

// В приведенной выше программе первоначальные значения были заданы для элементов
// массива nums вручную в десяти отдельных операторах присваивания. Конечно,
// такая инициализация массива совершенно правильна, но то же самое можно сделать
// намного проще. Ведь массивы могут инициализироваться, когда они создаются. Ниже
// приведена общая форма инициализации одномерного массива:

// тип[] имя_массива = { val1, val2, val3, ..., valN };

// где val1-valN обозначают первоначальные значения, которые присваиваются по очереди,
// слева направо и по порядку индексирования. Для хранения инициализаторов
// массива в C# автоматически распределяется достаточный объем памяти. А необходимость
// пользоваться оператором new явным образом отпадает сама собой. В качестве
// примера ниже приведен улучшенный вариант программы, вычисляющей среднее арифметическое.

//Вычислить среднее арифметическое ряда значений.
using System;

class Average
{
    static void Main()
    {
        int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

        int avg = 0;

        for (int i = 0; i < 10; i++)
        {
            avg = avg + nums[i];
        }

        avg = avg / 10;

        Console.WriteLine("Среднее: " + avg);

        //Задержка программы.
        Console.ReadKey();
    }
}

// юбопытно, что при инициализации массива можно также воспользоваться оператором
// new, хотя особой надобности в этом нет. Например, приведенный ниже фрагмент
// кода считается верным, но избыточным для инициализации массива nums в упомянутой
// выше программе.

// int[] nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

// Несмотря на свою избыточность, форма инициализации массива с оператором new
// оказывается полезной в том случае, если новый массив присваивается уже существующей
// переменной ссылки на массив. Например:

// int[] nums;
// nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

// В данном случае переменная nums объявляется в первом операторе и инициализируется
// во втором.

// И последнее замечание: при инициализации массива его размер можно указывать
// явным образом, но этот размер должен совпадать с числом инициализаторов. В качестве
// примера ниже приведен еще один способ инициализации массива nums.

// int[] nums = new int[10] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 );

// В этом объявлении размер массива nums задается равным 10 явно.

#endregion

#region English

// Initializing an Array

// In the preceding program, the nums array was given values by hand, using ten separate
// assignment statements.While that is perfectly correct, there is an easier way to accomplish
// this. Arrays can be initialized when they are created. The general form for initializing a onedimensional
// array is shown here:

// type[] array-name = { val1, val2, val3, ..., valN };

// Here, the initial values are specified by val1 through valN. They are assigned in sequence,
// left to right, in index order. C# automatically allocates an array large enough to hold the
// initializers that you specify. There is no need to use the new operator explicitly.For example,
// here is a better way to write the Average program:

// Compute the average of a set of values. 

// using System; 

// class Average
// {
//    static void Main()
//    {
//        int[] nums = { 99, 10, 100, 18, 78, 23,
//                   63, 9, 87, 49 };
//        int avg = 0;

//        for (int i = 0; i < 10; i++)
//            avg = avg + nums[i];

//        avg = avg / 10;

//        Console.WriteLine("Average: " + avg);
//    }
// }

// As a point of interest, although not needed, you can use new when initializing an array.
// For example, this is a proper, but redundant, way to initialize nums in the foregoing
// program:

// int[] nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

// Although redundant here, the new form of array initialization is useful when you are
// assigning a new array to an already-existent array reference variable. For example:

// int[] nums;
// nums = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

// In this case, nums is declared in the first statement and initialized by the second.

// One last point: It is permissible to specify the array size explicitly when initializing an
// array, but the size must agree with the number of initializers. For example, here is another
// way to initialize nums:

// int[] nums = new int[10] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

// In this declaration, the size of nums is explicitly stated as 10.

#endregion