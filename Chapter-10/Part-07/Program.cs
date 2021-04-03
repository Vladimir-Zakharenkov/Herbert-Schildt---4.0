#region Russian

// Добавлением свойства Length в класс FailSoftArray усовершенствование рассматриваемого
// здесь примера кода с помощью свойств далеко не исчерпывается. Еще
// одним членом данного класса, подходящим для превращения в свойство, служит переменная
// ErrFlag, поскольку ее применение должно быть ограничено только чтением.
// Ниже приведен окончательно усовершенствованный вариант класса FailSoftArray,
// в котором создается свойство Error, использующее в качестве места для хранения данных
// исходную переменную ErrFlag, ставшую теперь закрытой.

//Превратить переменную ErrFlag в свойство.
using System;

class FailSoftArray
{
    int[] a; //ссылка на базовый массив
    int len; //длинна массива - служит основанием для свойства Length
    bool ErrFlag; //теперь это частная переменная, обозначающая результат последней операции

    //Построить массив заданного размера.
    public FailSoftArray(int size)
    {
        a = new int[size];
        len = size;
    }

    //Свойство Length только для чтения.
    public int Length
    {
        get
        {
            return len;
        }
    }

    //Свойство Error только для чтения.
    public bool Error
    {
        get
        {
            return ErrFlag;
        }
    }

    //Это индексатор для класса FailSoftArray.
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
                ErrFlag = false;
                a[index] = value;
            }
            else
            {
                ErrFlag = true;
            }
        }
    }

    //Возвратить логическое значение true, если индекс находится в установленных границах.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length)
        {
            return true;
        }

        return false;
    }
}

//Продемонстрировать применение усовершенствованного отказоустойчивого массива.
class FinalFSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        
        //Использовать свойство Error.
        for (int i = 0; i < fs.Length +1; i++)
        {
            fs[i] = i * 10;
            if (fs.Error)
            {
                Console.WriteLine("Ошибка в индексе " + i);
            }
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Создание свойства Error стало причиной двух следующих изменений в классе
// FailSoftArray. Во-первых, переменная ErrFlag была сделана закрытой, поскольку
// теперь она служит базовым местом хранения данных для свойства Error, а следовательно,
// она не должна быть доступна непосредственно. И во-вторых, было введено
// свойство Error "только для чтения". Теперь свойство Error будет опрашиваться в тех
// программах, где требуется организовать обнаружение ошибок. Именно это и было
// продемонстрировано выше в методе Main(), где намеренно сгенерирована ошибка
// нарушения границ массива, а для ее обнаружения использовано свойство Error.

#endregion

#region English

// Although the addition of the Length property improves FailSoftArray, it is not the only
// improvement that properties can make. The ErrFlag member is also a prime candidate for
// conversion into a property since access to it should also be limited to read-only. Here is the
// final improvement of FailSafeArray. It creates a property called Error that uses the original
// ErrFlag variable as its storage, and ErrFlag is made private to FailSoftArray.

// Convert ErrFlag into a property. 

// using System; 

// class FailSoftArray
// {
//    int[] a; // reference to underlying array  
//    int len; // length of array 

//    bool ErrFlag; // now private 

//    // Construct array given its size.  
//    public FailSoftArray(int size)
//    {
//        a = new int[size];
//        len = size;
//    }

//    // Read-only Length property. 
//    public int Length
//    {
//        get
//        {
//            return len;
//        }
//    }

//    // Read-only Error property. 
//    public bool Error
//    {
//        get
//        {
//            return ErrFlag;
//        }
//    }

//    // This is the indexer for FailSoftArray. 
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

//    // Return true if index is within bounds. 
//    private bool ok(int index)
//    {
//        if (index >= 0 & index < Length) return true;
//        return false;
//    }
// }

// // Demonstrate the improved fail-soft array. 
// class FinalFSDemo
// {
//    static void Main()
//    {
//        FailSoftArray fs = new FailSoftArray(5);

//        // Use Error property. 
//        for (int i = 0; i < fs.Length + 1; i++)
//        {
//            fs[i] = i * 10;
//            if (fs.Error)
//                Console.WriteLine("Error with index " + i);
//        }
//    }
// }

// The creation of the Error property has caused two changes to be made to FailSoftArray.
// First, ErrFlag has been made private because it is now used as the underlying storage for
// the Error property. Thus, it won’t be available directly. Second, the read-only Error property
// has been added. Now, programs that need to detect errors will interrogate Error. This is
// demonstrated in Main( ), where a boundary error is intentionally generated, and the Error
// property is used to detect it.

#endregion