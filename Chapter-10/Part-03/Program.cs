#region Russian

// Индексаторы без базового массива

// Следует особо подчеркнуть, что индексатор совсем не обязательно должен оперировать
// массивом. Его основное назначение — предоставить пользователю функциональные
// возможности, аналогичные массиву. В качестве примера в приведенной ниже
// программе демонстрируется индексатор, выполняющий роль массива только для чтения,
// содержащего степени числа 2 от 0 до 15. Обратите внимание на то, что в этой
// программе отсутствует конкретный массив. Вместо этого индексатор просто вычисляет
// подходящее значение для заданного индекса.

//Индексаторы совсем не обязательно должны оперировать отдельными массивами.
using System;

class PwrOfTwo
{
    //Доступ к логическому массиву, содержащему степени числа 2 от 0 до 15.
    public int this[int index]
    {
        //Вычислить и возвратить степень числа 2.
        get
        {
            if ((index >= 0) && (index < 16))
            {
                return pwr(index);
            }
            else
            {
                return -1;
            }
        }

        //Аксессор set отсутствует.
    }

    int pwr(int p)
    {
        int result = 1;

        for (int i = 0; i < p; i++)
        {
            result *= 2;
        }

        return result;
    }
}

class UsePwrOfTwo
{
    static void Main()
    {
        PwrOfTwo pwr = new PwrOfTwo();

        Console.Write("Первые 8 степеней числа 2: ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(pwr[i] + " ");
        }
        Console.WriteLine();

        Console.Write("А вот некоторые ошибки: ");
        Console.Write(pwr[-1] + " " + pwr[17]);

        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этой программы.

// Первые 8 степеней числа 2: 1 2 4 8 16 32 64 128
// А это некоторые ошибки: -1 - 1

// Обратите внимание на то, что в индексатор класса PwrOfTwo включен только аксессор
// get, но в нем отсутствует аксессор set. Как пояснялось выше, такой индексатор
// служит только для чтения. Следовательно, объект класса PwrOfTwo может указываться
// только в правой части оператора присваивания, но не в левой его части. Например,
// попытка ввести следующую строку кода в приведенную выше программу не приведет
// к желаемому результату.

// pwr[0] = 11; // не подлежит компиляции

// Такой оператор присваивания станет причиной появления ошибки во время компиляции,
// поскольку для индексатора не определен аксессор set.

// На применение индексаторов накладываются два существенных ограничения.
// Во-первых, значение, выдаваемое индексатором, нельзя передавать методу в качестве
// параметра ref или out, поскольку в индексаторе не определено место в памяти для
// его хранения. И во-вторых, индексатор должен быть членом своего класса и поэтому
// не может быть объявлен как static.

#endregion

#region English

// Indexers Do Not Require an Underlying Array

// It is important to understand that there is no requirement that an indexer actually operate
// on an array. It simply must provide functionality that appears “array-like” to the user of the
// indexer. For example, the following program has an indexer that acts like a read-only array
// that contains the powers of 2 from 0 to 15. Notice, however, that no actual array exists.
// Instead, the indexer simply computes the proper value for a given index.

// Indexers don't have to operate on actual arrays. 

// using System; 

// class PwrOfTwo
// {

//    /* Access a logical array that contains 
//       the powers of 2 from 0 to 15. */
//    public int this[int index]
//    {
//        // Compute and return power of 2. 
//        get
//        {
//            if ((index >= 0) && (index < 16)) return pwr(index);
//            else return -1;
//        }

//        // There is no set accessor. 
//    }

//    int pwr(int p)
//    {
//        int result = 1;

//        for (int i = 0; i < p; i++)
//            result *= 2;

//        return result;
//    }
// }

// class UsePwrOfTwo
// {
//    static void Main()
//    {
//        PwrOfTwo pwr = new PwrOfTwo();

//        Console.Write("First 8 powers of 2: ");
//        for (int i = 0; i < 8; i++)
//            Console.Write(pwr[i] + " ");
//        Console.WriteLine();

//        Console.Write("Here are some errors: ");
//        Console.Write(pwr[-1] + " " + pwr[17]);

//        Console.WriteLine();
//    }
// }

// The output from the program is shown here:

// First 8 powers of 2: 1 2 4 8 16 32 64 128
// Here are some errors: -1 - 1

// Notice that the indexer for PwrOfTwo includes a get accessor, but no set accessor. As
// explained, this means that the indexer is read-only. Thus, a PwrOfTwo object can be used
// on the right side of an assignment statement, but not on the left. For example, attempting
// to add this statement to the preceding program won’t work:

// pwr[0] = 11; // won't compile

// This statement will cause a compilation error because no set accessor is defined for the
// indexer.

// There are two important restrictions to using indexers. First, because an indexer does
// not define a storage location, a value produced by an indexer cannot be passed as a ref or
// out parameter to a method. Second, an indexer must be an instance member of its class; it
// cannot be declared static.

#endregion