#region Russian

// Перегрузка индексаторов

// Индексатор может быть перегружен. В этом случае для выполнения выбирается
// тот вариант индексатора, в котором точнее соблюдается соответствие его параметра и
// аргумента, указываемого в качестве индекса. Ниже приведен пример программы, в которой
// индексатор массива класса FailSoftArray перегружается для индексов типа
// double. При этом индексатор типа double округляет свой индекс до ближайшего
// целого значения.

//Перегрузить индексатор массива класса FailSoftArray.
using System;

class FailSoftArray
{
    int[] a; //ссылка на базовыйй массив

    public int Length; //открытая переменная длины массива

    public bool ErrFlag; //обозначает результат последней операции

    //Построить массив заданного размера.
    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }

    //Это индексатор типа int для массива FailSoftArray.
    public int this[int index]
    {
        //Это аксессор get.
        get
        {
            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
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
            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }

    //Это еще один индексатор для массива FailSoftArray.
    //Он округляет свой аргумент до ближайшего целого индекса.
    public int this[double idx]
    {
        //Это аксессор get.
        get
        {
            int index;

            //Округлить до ближайшего целого.
            if ((idx - (int)idx) < 0.5)
            {
                index = (int)idx;
            }
            else
            {
                index = (int)idx + 1;
            }

            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
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
            int index;

            //Округлить до ближайшего целого.
            if ((idx - (int)idx) < 0.5)
            {
                index = (int)idx;
            }
            else
            {
                index = (int)idx + 1;
            }

            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }

    //Возвратить логическое значение true, если индекс находится в установленных приделах.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length)
        {
            return true;
        }

        return false;
    }
}

//Продемонстрировать применение отказоустойчивого массива.
class FSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);

        //Поместить ряд значений в массив fs.
        for (int i = 0; i < fs.Length; i++)
        {
            fs[i] = i;
        }

        //А теперь воспользоваться индексами типа int и double для обращения к массиву.
        Console.WriteLine("fs[1] : " + fs[1]);
        Console.WriteLine("fs[2] : " + fs[2]);

        Console.WriteLine("fs[1.1] : " + fs[1.1]);
        Console.WriteLine("fs[1.6] : " + fs[1.6]);

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// fs[1]: 1
// fs[2]: 2
// fs[1.1]: 1
// fs[1.6]: 2

// Как показывает приведенный выше результат, индексы типа double округляются
// до ближайшего целого значения. В частности, индекс 1.1 округляется до 1, а индекс
// 1.6 — до 2.

// Представленный выше пример программы наглядно демонстрирует правомочность
// перегрузки индексаторов, но на практике она применяется нечасто. Как правило,
// индексаторы перегружаются для того, чтобы использовать объект определенного
// класса в качестве индекса, вычисляемого каким-то особым образом.

#endregion

#region English

// Indexers Can Be Overloaded

// An indexer can be overloaded. The version executed will be the one that has the closest
// type-match between its parameter and the argument used as an index. Here is an example
// that overloads the FailSoftArray indexer for indexes of type double. The double indexer
// rounds its index to the nearest integer value.

// Overload the FailSoftArray indexer. 

// using System;  

// class FailSoftArray
// {
//    int[] a;    // reference to underlying array   

//    public int Length; // Length is public  

//    public bool ErrFlag; // indicates outcome of last operation  

//    // Construct array given its size.  
//    public FailSoftArray(int size)
//    {
//        a = new int[size];
//        Length = size;
//    }

//    // This is the int indexer for FailSoftArray.  
//    public int this[int index]
//    {
//        // This is the get accessor.  
//        get
//        {
//            if (ok(index))
//            {
//                ErrFlag = false;
//                return a[index];
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
//            if (ok(index))
//            {
//                a[index] = value;
//                ErrFlag = false;
//            }
//            else ErrFlag = true;
//        }
//    }

//    /* This is another indexer for FailSoftArray. 
//       This index takes a double argument.  It then 
//       rounds that argument to the nearest integer index. */
//    public int this[double idx]
//    {
//        // This is the get accessor.  
//        get
//        {
//            int index;

//            // Round to nearest int. 
//            if ((idx - (int)idx) < 0.5) index = (int)idx;
//            else index = (int)idx + 1;

//            if (ok(index))
//            {
//                ErrFlag = false;
//                return a[index];
//            }
//            else
//            {
//                ErrFlag = true;
//                return 0;
//            }
//        }

//        // This is the set accessor  
//        set
//        {
//            int index;

//            // Round to nearest int. 
//            if ((idx - (int)idx) < 0.5) index = (int)idx;
//            else index = (int)idx + 1;

//            if (ok(index))
//            {
//                a[index] = value;
//                ErrFlag = false;
//            }
//            else ErrFlag = true;
//        }
//    }

//    // Return true if index is within bounds.  
//    private bool ok(int index)
//    {
//        if (index >= 0 & index < Length) return true;
//        return false;
//    }
// }

// // Demonstrate the fail-soft array.  
// class FSDemo
// {
//    static void Main()
//    {
//        FailSoftArray fs = new FailSoftArray(5);

//        // Put some values in fs. 
//        for (int i = 0; i < fs.Length; i++)
//            fs[i] = i;

//        // Now index with ints and doubles. 
//        Console.WriteLine("fs[1]: " + fs[1]);
//        Console.WriteLine("fs[2]: " + fs[2]);

//        Console.WriteLine("fs[1.1]: " + fs[1.1]);
//        Console.WriteLine("fs[1.6]: " + fs[1.6]);
//    }
// }

// This program produces the following output:

// fs[1]: 1
// fs[2]: 2
// fs[1.1]: 1
// fs[1.6]: 2

// As the output shows, the double indexes are rounded to their nearest integer value.
// Specifically, 1.1 is rounded to 1, and 1.6 is rounded to 2.

// Although overloading an indexer as shown in this program is valid, it is not common.
// Most often, an indexer is overloaded to enable an object of a class to be used as an index,
// with the index computed in some special way.

#endregion