#region Russian

// Многомерные индексаторы

// Индексаторы можно создавать и для многомерных массивов. В качестве примера
// ниже приведен двумерный отказоустойчивый массив. Обратите особое внимание на
// объявление индексатора в этом примере.

//Двумерный отказоустойчивый массив.
using System;

class FailSoftArray2D
{
    int[,] a; //ссылка на базовый двумерный массив
    int rows, cols; //размеры массива
    public int Length; //открытая переменная длины массива
    public bool ErrFlag; //обозначает результат последней операции

    //Построить массив заданных размеров.
    public FailSoftArray2D(int r, int c)
    {
        rows = r;
        cols = c;
        a = new int[rows, cols];
        Length = rows * cols;
    }

    //Это индексатор для класса FailSoftArray2D.
    public int this[int index1, int index2]
    {
        //Это аксессор get.
        get
        {
            if (ok(index1, index2))
            {
                ErrFlag = false;
                return a[index1, index2];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }

        //Это аксессор set.
        set
        {
            if (ok(index1, index2))
            {
                a[index1, index2] = value;
                ErrFlag = false;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }

    //Возвратить логическое значение true, если индексы находятся в установленных приделах.
    private bool ok(int index1, int index2)
    {
        if (index1 >= 0 & index1 < rows & index2 >= 0 & index2 < cols)
        {
            return true;
        }

        return false;
    }
}

//Продемонстрировать применение двумерного индексатора.
class TwoDIndexerDemo
{
    static void Main()
    {
        FailSoftArray2D fs = new FailSoftArray2D(3, 5);
        int x;

        //Выявить скрытые сбои.
        Console.WriteLine("Скрытый сбой.");
        for (int i = 0; i < 6; i++)
        {
            fs[i, i] = i * 10;
        }

        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (x != -1)
            {
                Console.Write(x + " ");
            }
        }
        Console.WriteLine();

        //А теперь показать сбои.
        Console.WriteLine("\nСбой с уведомлением об ошибках.");
        for (int i = 0; i < 6; i++)
        {
            fs[i, i] = i * 10;

            if (fs.ErrFlag)
            {
                Console.WriteLine("fs[" + i + ", " + i + "] вне границ");
            }
        }

        for (int i = 0; i < 6; i++)
        {
            x = fs[i, i];
            if (!fs.ErrFlag)
            {
                Console.Write(x + " ");
            }
            else
            {
                Console.WriteLine("fs[" + i + ", " + i + "] вне границ");
            }
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этого кода:

// Скрытый сбой.
// 0 10 20 0 0 0

// Сбой с уведомлением об ошибках.
// fs[3, 3] вне границ
// fs[4, 4] вне границ
// fs[5, 5] вне границ
// 0 10 20 fs[3, 3] вне границ
// fs[4, 4] вне границ
// fs[5, 5] вне границ

#endregion

#region English

// Multidimensional Indexers

// You can create indexers for multidimensional arrays, too. For example, here is a twodimensional
// fail-soft array. Pay close attention to the way that the indexer is declared.

// A two-dimensional fail-soft array. 

// using System; 

// class FailSoftArray2D
// {
//    int[,] a; // reference to underlying 2D array  
//    int rows, cols; // dimensions 
//    public int Length; // Length is public 

//    public bool ErrFlag; // indicates outcome of last operation 

//    // Construct array given its dimensions. 
//    public FailSoftArray2D(int r, int c)
//    {
//        rows = r;
//        cols = c;
//        a = new int[rows, cols];
//        Length = rows * cols;
//    }

//    // This is the indexer for FailSoftArray2D. 
//    public int this[int index1, int index2]
//    {
//        // This is the get accessor. 
//        get
//        {
//            if (ok(index1, index2))
//            {
//                ErrFlag = false;
//                return a[index1, index2];
//            }
//            else
//            {
//                ErrFlag = true;
//                return 0;
//            }
//        }

//        // This is the set accessor. 
//        set
//        {
//            if (ok(index1, index2))
//            {
//                a[index1, index2] = value;
//                ErrFlag = false;
//            }
//            else ErrFlag = true;
//        }
//    }

//    // Return true if indexes are within bounds. 
//    private bool ok(int index1, int index2)
//    {
//        if (index1 >= 0 & index1 < rows &
//           index2 >= 0 & index2 < cols)
//            return true;

//        return false;
//    }
// }

// // Demonstrate a 2D indexer. 
// class TwoDIndexerDemo
// {
//    static void Main()
//    {
//        FailSoftArray2D fs = new FailSoftArray2D(3, 5);
//        int x;

//        // Show quiet failures. 
//        Console.WriteLine("Fail quietly.");
//        for (int i = 0; i < 6; i++)
//            fs[i, i] = i * 10;

//        for (int i = 0; i < 6; i++)
//        {
//            x = fs[i, i];
//            if (x != -1) Console.Write(x + " ");
//        }
//        Console.WriteLine();

//        // Now, display failures. 
//        Console.WriteLine("\nFail with error reports.");
//        for (int i = 0; i < 6; i++)
//        {
//            fs[i, i] = i * 10;
//            if (fs.ErrFlag)
//                Console.WriteLine("fs[" + i + ", " + i + "] out-of-bounds");
//        }

//        for (int i = 0; i < 6; i++)
//        {
//            x = fs[i, i];
//            if (!fs.ErrFlag) Console.Write(x + " ");
//            else
//                Console.WriteLine("fs[" + i + ", " + i + "] out-of-bounds");
//        }
//    }
// }

// The output from this program is shown here:

// Fail quietly.
// 0 10 20 0 0 0

// Fail with error reports.
// fs[3, 3] out-of-bounds
// fs[4, 4] out-of-bounds
// fs[5, 5] out-of-bounds
// 0 10 20 fs[3, 3] out-of-bounds
// fs[4, 4] out-of-bounds
// fs[5, 5] out-of-bounds

#endregion