#region Russian

// 10 ГЛАВА

// Индексаторы и свойства

// В этой главе рассматриваются две особые и тесно связанные друг с другом разновидности членов класса:
// индексаторы и свойства. Каждый из них по-своему расширяет возможности класса, способствуя более полной
// его интеграции в систему типов С# и повышая его гибкость. В частности, индексаторы предоставляют механизм
// для индексирования объектов подобно массивам, а свойства — рациональный способ управления доступом
// к данным экземпляра класса. Эти члены класса тесно связаны друг с другом,
// поскольку оба опираются на еще одно доступное в C# средство: аксессор.

// Индексаторы

// Как вам должно быть уже известно, индексирование массива осуществляется с помощью оператора []. Для
// создаваемых классов можно определить оператор [], но с этой целью вместо операторного метода создается
// индексатор, который позволяет индексировать объект, подобно массиву. Индексаторы применяются, главным образом,
// в качестве средства, поддерживающего создание специализированных массивов, на которые накладывается
// одно или несколько ограничений. Тем не менее индексаторы могут служить практически любым целям, для которых
// выгодным оказывается такой же синтаксис, как и у массивов. Индексаторы могут быть одно- или многомерными.
// Рассмотрим сначала одномерные индексаторы.

// Создание одномерных индексаторов

// Ниже приведена общая форма одномерного индексатора:

// тип_элемента this[int индекс]
// {
//    // Аксессор для получения данных.
//    get
//    {
//        // Возврат значения, которое определяет индекс.
//    }
//    // Аксессор для установки данных.
//    set
//    {
//        // Установка значения, которое определяет индекс.
//    }
// }

// где тип_элемента обозначает конкретный тип элемента индексатора. Следовательно,
// у каждого элемента, доступного с помощью индексатора, должен быть определенный
// тип_элемента. Этот тип соответствует типу элемента массива. Параметр индекс получает
// конкретный индекс элемента, к которому осуществляется доступ. Формально
// этот параметр совсем не обязательно должен иметь тип int, но поскольку индексаторы,
// как правило, применяются для индексирования массивов, то чаще всего используется
// целочисленный тип данного параметра.

// В теле индексатора определены два аксессора (т.е. средства доступа к данным): get
// и set. Аксессор подобен методу, за исключением того, что в нем не объявляется тип
// возвращаемого значения или параметры. Аксессоры вызываются автоматически при
// использовании индексатора, и оба получают индекс в качестве параметра. Так, если
// индексатор указывается в левой части оператора присваивания, то вызывается аксессор
// set и устанавливается элемент, на который указывает параметр индекс. В противном
// случае вызывается аксессор get и возвращается значение, соответствующее параметру
// индекс. Кроме того, аксессор set получает неявный параметр value, содержащий
// значение, присваиваемое по указанному индексу.

// Преимущество индексатора заключается, в частности, в том, что он позволяет полностью
// управлять доступом к массиву, избегая нежелательного доступа. В качестве
// примера рассмотрим программу, в которой создается класс FailSoftArray, реализующий
// массив для выявления ошибок нарушения границ массива, а следовательно,
// для предотвращения исключительных ситуаций, возникающих во время выполнения
// в связи с индексированием массива за его границами. Для этого массив инкапсулируется
// в качестве закрытого члена класса, а доступ к нему осуществляется только с помощью
// индексатора. При таком подходе исключается любая попытка получить доступ
// к массиву за его границами, причем эта попытка пресекается без катастрофических
// последствий для программы. А поскольку в классе FailSoftArray используется индексатор,
// то к массиву можно обращаться с помощью обычной формы записи.

//Использовать индексатор для создания отказоустойчивого массива.
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

//Продемонстрировать применение отказоустойчивого маассива.
class FSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;

        //Выявить скрыытые сбои.
        Console.WriteLine("Скрытый сбой.");

        for (int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;
        }

        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (x != -1)
            {
                Console.Write(x + " ");
            }
        }

        Console.WriteLine();

        //А теперь показать сбои.
        Console.WriteLine("\nСбой с уведомлением об ошибках.");

        for (int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;
            if (fs.ErrFlag)
            {
                Console.WriteLine("fs[" + i + "] вне границ");
            }
        }

        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (!fs.ErrFlag)
            {
                Console.Write(x + " ");
            }
            else
            {
                Console.WriteLine("fs[" + i + "] вне границ");
            }
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этой программы.

// Скрытый сбой.
// 0 10 20 30 40 0 0 0 0 0
// Сбой с уведомлением об ошибках.
// fs[5] вне границ
// fs[6] вне границ
// fs[7] вне границ
// fs[8] вне границ
// fs[9] вне границ
// 0 10 20 30 40 fs[5] вне границ
// fs[6] вне границ
// fs[7] вне границ
// fs[8] вне границ
// fs[9] вне границ

// Индексатор препятствует нарушению границ массива. Внимательно проанализируем
// каждую часть кода индексатора. Он начинается со следующей строки.

// public int this[int index]
// {

// В этой строке кода объявляется индексатор, оперирующий элементами типа int.
// Ему передается индекс в качестве параметра index. Кроме того, индексатор объявляется
// открытым (public), что дает возможность использовать этот индексатор в коде за
// пределами его класса.

// Рассмотрим следующий код аксессора get.

// get {
// if(ok(index)) {
//    ErrFlag = false;
//    return a[index];
// } else
// {
//    ErrFlag = true;
//    return 0;
// }
// }

// Аксессор get предотвращает ошибки нарушения границ массива, проверяя в первую
// очередь, находится ли индекс в установленных границах. Эта проверка границ выполняется
// в методе ok(), который возвращает логическое значение true, если индекс
// правильный, а иначе — логическое значение false. Так, если указанный индекс находится
// в установленных границах, то по этому индексу возвращается соответствующий
// элемент. А если индекс оказывается вне установленных границ, то никаких операций
// не выполняется, но в то же время не возникает никаких ошибок переполнения.
// В данном варианте класса FailSoftArray переменная ErrFlag содержит результат
// каждой операции. Ее содержимое может быть проверено после каждой операции на
// предмет удачного или неудачного выполнения последней. (В главе 13 будет представлен
// более совершенный способ обработки ошибок с помощью имеющейся в C# подсистемы
// обработки исключительных ситуаций, а до тех пор можно вполне обойтись
// установкой и проверкой признака ошибки.)

// А теперь рассмотрим следующий код аксессора set, предотвращающего ошибки нарушения границ массива.

// set {
// if(ok(index)) {
//    a[index] = value;
//    ErrFlag = false;
// }
// else ErrFlag = true;
// }

// Если параметр index метода ok() находится в установленных пределах, то соответствующему
// элементу массива присваивается значение, передаваемое из параметра
// value. В противном случае устанавливается логическое значение true переменной
// ErrFlag. Напомним, что value в любом аксессорном методе является неявным параметром,
// содержащим присваиваемое значение. Его не нужно (да и нельзя) объявлять отдельно.

// Наличие обоих аксессоров, get и set, в индексаторе не является обязательным.
// Так, можно создать индексатор только для чтения, реализовав в нем один лишь аксессор
// get, или же индексатор только для записи с единственным аксессором set.

#endregion

#region English

// 10 CHAPTER

// Indexers and Properties

// This chapter examines two special types of class members that have a close relationship
// to each other: indexers and properties. Each expands the power of a class by
// enhancing its integration into C#’s type system and improving its resiliency. Indexers
// provide the mechanism by which an object can be indexed like an array. Properties offer a
// streamlined way to manage access to a class’ instance data.They relate to each other because
// both rely upon another feature of C#: the accessor.

// Indexers

// As you know, array indexing is performed using the[] operator. It is possible to define the
// [] operator for classes that you create, but you don’t use an operator method. Instead, you
// create an indexer. An indexer allows an object to be indexed like an array. The main use of
// indexers is to support the creation of specialized arrays that are subject to one or more
// constraints. However, you can use an indexer for any purpose for which an array-like
// syntax is beneficial. Indexers can have one or more dimensions. We will begin with onedimensional
// indexers.

// Creating One-Dimensional Indexers

// A simple one-dimensional indexer has this general form:

// element - type this[int index] {
//    // The get accessor
//    get {
//        // return the value specified by index
//    }
//    // The set accessor
//    set {
//        // set the value specified by index
//    }
// }

// Here, element - type is the element type of the indexer. Thus, each element accessed by the
// indexer will be of type element-type. This type corresponds to the element type of an array.
// The parameter index receives the index of the element being accessed. Technically, this
// parameter does not have to be of type int, but since indexers are typically used to provide
// array indexing, using an integer type is quite common.

// Inside the body of the indexer two accessors are defined that are called get and set. An
// accessor is similar to a method except that it does not declare a return type or parameters.
// The accessors are automatically called when the indexer is used, and both accessors receive
// index as a parameter. If the indexer is on the left side of an assignment statement, then the
// set accessor is called and the element specified by index must be set. Otherwise, the get
// accessor is called and the value associated with index must be returned. The set method also
// receives an implicit parameter called value, which contains the value being assigned to the
// specified index.

// One of the benefits of an indexer is that you can control precisely how an array is accessed,
// heading off improper access. Here is an example. In the following program, the FailSoftArray
// class implements an array that traps boundary errors, thus preventing runtime exceptions if
// the array is indexed out-of-bounds. This is accomplished by encapsulating the array as a
// private member of a class, allowing access to the array only through the indexer. With this
// approach, any attempt to access the array beyond its boundaries can be prevented, with such
// an attempt failing gracefully (resulting in a “soft landing” rather than a “crash”). Since
// FailSoftArray uses an indexer, the array can be accessed using the normal array notation.

// Use an indexer to create a fail-soft array. 

//using System; 

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

// //Demonstrate the fail-soft array. 
// class FSDemo
// {
//    static void Main()
//    {
//        FailSoftArray fs = new FailSoftArray(5);
//        int x;

//        // Show quiet failures. 
//        Console.WriteLine("Fail quietly.");
//        for (int i = 0; i < (fs.Length * 2); i++)
//            fs[i] = i * 10;

//        for (int i = 0; i < (fs.Length * 2); i++)
//        {
//            x = fs[i];
//            if (x != -1) Console.Write(x + " ");
//        }
//        Console.WriteLine();

//        // Now, display failures. 
//        Console.WriteLine("\nFail with error reports.");
//        for (int i = 0; i < (fs.Length * 2); i++)
//        {
//            fs[i] = i * 10;
//            if (fs.ErrFlag)
//                Console.WriteLine("fs[" + i + "] out-of-bounds");
//        }

//        for (int i = 0; i < (fs.Length * 2); i++)
//        {
//            x = fs[i];
//            if (!fs.ErrFlag) Console.Write(x + " ");
//            else
//                Console.WriteLine("fs[" + i + "] out-of-bounds");
//        }
//    }
// }

// The output from the program is shown here:

// Fail quietly.
// 0 10 20 30 40 0 0 0 0 0
// Fail with error reports.
// fs[5] out-of - bounds
// fs[6] out-of - bounds
// fs[7] out-of - bounds
// fs[8] out-of - bounds
// fs[9] out-of - bounds
// 0 10 20 30 40 fs[5] out-of - bounds
// fs[6] out-of - bounds
// fs[7] out-of - bounds
// fs[8] out-of - bounds
// fs[9] out-of - bounds

// The indexer prevents the array boundaries from being overrun. Let’s look closely at
// each part of the indexer. It begins with this line:

// public int this[int index]
// {

// This declares an indexer that operates on int elements. The index is passed in index. The
// indexer is public, allowing it to be used by code outside of its class.

// The get accessor is shown here:

// get
// {
//    if (ok(index))
//    {
//        ErrFlag = false;
//        return a[index];
//    }
//    else
//    {
//        ErrFlag = true;
//        return 0;
//    }
// }

// The get accessor prevents array boundary errors by first confirming that the index is not
// out-of-bounds. This range check is performed by the ok( ) method, which returns true if the
// index is valid and false otherwise. If the specified index is within bounds, the element
// corresponding to the index is returned. If it is out of bounds, no operation takes place and
// no overrun occurs. In this version of FailSoftArray, a variable called ErrFlag contains the
// outcome of each operation. This field can be examined after each operation to assess the
// success or failure of the operation. (In Chapter 13, you will see a better way to handle errors
// by using C#’s exception subsystem, but for now, using an error flag is an acceptable
// approach.)

// The set accessor is shown here. It too prevents a boundary error.

// set {
// if(ok(index)) {
//    a[index] = value;
//    ErrFlag = false;
// }
// else ErrFlag = true;
// }

// Here, if index is within bounds, the value passed in value is assigned to the corresponding
// element. Otherwise, ErrFlag is set to true. Recall that in an accessor method, value is an
// implicit parameter that contains the value being assigned. You do not need to (nor can you)
// declare it.

// It is not necessary for an indexer to support both get and set. You can create a read-only
// indexer by implementing only the get accessor. You can create a write-only indexer by
// implementing only set.

#endregion