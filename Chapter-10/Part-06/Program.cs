#region Russian

// Воспользуемся свойством для дальнейшего усовершенствования отказоустойчивого
// массива. Как вам должно быть уже известно, у всех массивов имеется соответствующее
// свойство длины (Length). До сих пор в классе FailSoftArray для этой цели использовалось
// открытое целочисленное поле Length. Но это далеко не самый лучший
// подход, поскольку он допускает установку значений, отличающихся от длины отказоустойчивого
// массива. (Например, программист, преследующий злонамеренные цели,
// может умышленно ввести неверное значение в данном поле.) Для того чтобы исправить
// это положение, превратим поле Length в свойство "только для чтения", как показано
// в приведенном ниже, измененном варианте класса FailSoftArray.

//Добавить свойство Length в класс FailSoftArray.
using System;

class FailSoftArray
{
    int[] a; //ссылка на базовый массив
    int len; //длинна массива - служит основанием для свойства Length

    public bool ErrFlag; //обозначает результат последней операции

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
class ImprovedFSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;

        //Свойство Length доступно для чтения.
        for (int i = 0; i < fs.Length; i++)
        {
            fs[i] = i * 10;
        }

        for (int i = 0; i < fs.Length; i++)
        {
            x = fs[i];

            if (x != -1)
            {
                Console.Write(x + " ");
            }
        }

        Console.WriteLine();

        // fs.Length = 10; //Ошибка, запись запрещена!

        //Задержка программы.
        Console.ReadKey();
    }
}

// Теперь Length — это свойство, в котором местом для хранения данных служит
// закрытая переменная len. А поскольку в этом свойстве определен единственный аксессор get,
// то оно доступно только для чтения. Это означает, что значение свойства
// Length можно только читать, но не изменять. Для того чтобы убедиться в этом, попробуйте
// удалить символы комментария в начале следующей строки из приведенного выше кода.

// // fs.Length = 10; // Ошибка, запись запрещена!

// При попытке скомпилировать данный код вы получите сообщение об ошибке,
// уведомляющее о том, что Length является свойством, доступным только для чтения.

#endregion

#region English

// You can use a property to further improve the fail-soft array class. As you know, all
// arrays have a Length property associated with them. Up to now, the FailSoftArray class
// simply used a public integer field called Length for this purpose. This is not good practice,
// though, because it allows Length to be set to some value other than the length of the failsoft
// array. (For example, a malicious programmer could intentionally corrupt its value.) We
// can remedy this situation by transforming Length into a read-only property, as shown in
// the following version of FailSoftArray:

// Add Length property to FailSoftArray. 

// using System; 

// class FailSoftArray
// {
//    int[] a; // reference to underlying array  
//    int len; // length of array -- underlies Length property 

//    public bool ErrFlag; // indicates outcome of last operation 

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
// class ImprovedFSDemo
// {
//    static void Main()
//    {
//        FailSoftArray fs = new FailSoftArray(5);
//        int x;

//        // Can read Length. 
//        for (int i = 0; i < fs.Length; i++)
//            fs[i] = i * 10;

//        for (int i = 0; i < fs.Length; i++)
//        {
//            x = fs[i];
//            if (x != -1) Console.Write(x + " ");
//        }
//        Console.WriteLine();

//        // fs.Length = 10; // Error, illegal! 
//    }
// }

// Length is now a property that uses the private variable len for its storage. Length defines
// only a get accessor, which means that it is read - only.Thus, Length can be read, but not
// changed.To prove this to yourself, try removing the comment symbol preceding this line
// in the program:

// // fs.Length = 10; // Error, illegal!

// When you try to compile, you will receive an error message stating that Length is read-only.

#endregion