#region Russian

// Ступенчатые массивы

// В приведенных выше примерах применения двумерного массива, по существу, создавался
// так называемый прямоугольный массив. Двумерный массив можно представить
// в виде таблицы, в которой длина каждой строки остается неизменной по всему массиву.
// Но в C# можно также создавать специальный тип двумерного массива, называемый
// ступенчатым массивом. Ступенчатый массив представляет собой массив массивов, в котором
// длина каждого массива может быть разной. Следовательно, ступенчатый массив
// может быть использован для составления таблицы из строк разной длины.

// Ступенчатые массивы объявляются с помощью ряда квадратных скобок, в которых
// указывается их размерность. Например, для объявления двумерного ступенчатого массива
// служит следующая общая форма:

// тип[][] имя_массива = new тип[размер][];

// где размер обозначает число строк в массиве. Память для самих строк распределяется
// индивидуально, и поэтому длина строк может быть разной. Например, в приведенном
// ниже фрагменте кода объявляется ступенчатый массив jagged. Память сначала распределяется
// для его первого измерения автоматически, а затем для второго измерения вручную.

// int[][] jagged = new int[3][];
// jagged[0] = new int[4];
// jagged[1] = new int[3];
// jagged[2] = new int[5];

// Теперь нетрудно понять, почему такие массивы называются ступенчатыми! После
// создания ступенчатого массива доступ к его элементам осуществляется по индексу,
// указываемому в отдельных квадратных скобках. Например, в следующей строке кода
// элементу массива jagged, находящемуся на позиции с координатами (2,1), присваивается
// значение 10.

// jagged[2][1] = 10;

// Обратите внимание на синтаксические отличия в доступе к элементу ступенчатого
// и прямоугольного массива.

// В приведенном ниже примере программы демонстрируется создание двумерного
// ступенчатого массива.

//Продемонстрировать применение ступенчатых массивов.
using System;

class Jagged
{
    static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];

        int i;

        //Сохранить значения в первом массиве.
        for (i = 0; i < 4; i++)
        {
            jagged[0][i] = i;
        }

        //Сохранить значения во втором массиве.
        for (i = 0; i < 3; i++)
        {
            jagged[1][i] = i;
        }

        //Сохранить значения в третьем массиве.
        for (i = 0; i < 5; i++)
        {
            jagged[2][i] = i;
        }

        //Вывести значения из первого массива.
        for (i = 0; i < 4; i++)
        {
            Console.Write(jagged[0][i] + " ");
        }

        Console.WriteLine();

        //Вывести значения из второго массива.
        for (i = 0; i < 3; i++)
        {
            Console.Write(jagged[1][i] + " ");
        }

        Console.WriteLine();

        //Вывести значения из третьего массива.
        for (i = 0; i < 5; i++)
        {
            Console.Write(jagged[2][i] + " ");
        }

        //Задержка программы
        Console.ReadKey();
    }
}

// Выполнение этой программы приводит к следующему результату.

// 0 1 2 3
// 0 1 2
// 0 1 2 3 4

// Ступенчатые массивы находят полезное применение не во всех, а лишь в некоторых
// случаях. Так, если требуется очень длинный двумерный массив, который заполняется
// не полностью, т.е. такой массив, в котором используются не все, а лишь отдельные его
// элементы, то для этой цели идеально подходит ступенчатый массив.

// И последнее замечание: ступенчатые массивы представляют собой массивы массивов,
// и поэтому они не обязательно должны состоять из одномерных массивов. Например,
// в приведенной ниже строке кода создается массив двумерных массивов.

// int[][,] jagged = new int[3][,];

// В следующей строке кода элементу массива jagged[0] присваивается ссылка на
// массив размерами 4×2.

// jagged[0] = new int[4, 2];

// А в приведенной ниже строке кода элементу массива jagged[0][1,0] присваивается
// значение переменной i.

// jagged[0][1,0] = i;

#endregion

#region English

// Jagged Arrays

// In the preceding examples, when you created a two-dimensional array, you were creating
// what is called a rectangular array. Thinking of two-dimensional arrays as tables, a rectangular
// array is a two-dimensional array in which the length of each row is the same for the entire
// array. However, C# also allows you to create a special type of two-dimensional array called
// a jagged array. A jagged array is an array of arrays in which the length of each array can differ.
// Thus, a jagged array can be used to create a table in which the lengths of the rows are not

// Jagged arrays are declared by using sets of square brackets to indicate each dimension.
// For example, to declare a two-dimensional jagged array, you will use this general form:

// type[][] array-name = new type[size][];

// Here, size indicates the number of rows in the array. The rows, themselves, have not been
// allocated. Instead, the rows are allocated individually. This allows for the length of each row
// to vary. For example, the following code allocates memory for the first dimension of jagged
// when it is declared. It then allocates the second dimensions manually.

// int[][] jagged = new int[3][];
// jagged[0] = new int[4];
// jagged[1] = new int[3];
// jagged[2] = new int[5];

// It is easy to see how jagged arrays got their name!

// Once a jagged array has been created, an element is accessed by specifying each index
// within its own set of brackets. For example, to assign the value 10 to element 2, 1 of jagged,
// you would use this statement:

// jagged[2][1] = 10;

// Note that this differs from the syntax that is used to access an element of a rectangular array.
// The following program demonstrates the creation of a jagged two-dimensional array:

// Demonstrate jagged arrays. 

// using System; 

// class Jagged
// {
//    static void Main()
//    {
//        int[][] jagged = new int[3][];
//        jagged[0] = new int[4];
//        jagged[1] = new int[3];
//        jagged[2] = new int[5];

//        int i;

//        // Store values in first array. 
//        for (i = 0; i < 4; i++)
//            jagged[0][i] = i;

//        // Store values in second array. 
//        for (i = 0; i < 3; i++)
//            jagged[1][i] = i;

//        // Store values in third array. 
//        for (i = 0; i < 5; i++)
//            jagged[2][i] = i;


//        // Display values in first array. 
//        for (i = 0; i < 4; i++)
//            Console.Write(jagged[0][i] + " ");

//        Console.WriteLine();

//        // Display values in second array. 
//        for (i = 0; i < 3; i++)
//            Console.Write(jagged[1][i] + " ");

//        Console.WriteLine();

//        // Display values in third array. 
//        for (i = 0; i < 5; i++)
//            Console.Write(jagged[2][i] + " ");

//        Console.WriteLine();
//    }
// }

// The output is shown here:

// 0 1 2 3
// 0 1 2
// 0 1 2 3 4

// Jagged arrays are not used by all applications, but they can be effective in some
// situations. For example, if you need a very large two-dimensional array that is sparsely
// populated (that is, one in which not all of the elements will be used), then a jagged array
// might be a perfect solution.

// One last point: Because jagged arrays are arrays of arrays, there is no restriction that
// requires that the arrays be one-dimensional. For example, the following creates an array
// of two-dimensional arrays:

// int[][,] jagged = new int[3][,];

// The next statement assigns jagged[0] a reference to a 4×2 array:

// jagged[0] = new int[4, 2];

// The following statement assigns a value to jagged[0] [1,0]:

// jagged[0][1, 0] = i;

#endregion