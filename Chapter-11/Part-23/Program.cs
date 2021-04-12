#region Russian

// Упаковка и распаковка

// Как пояснялось выше, все типы в С#, включая и простые типы значений, являются
// производными от класса object. Следовательно, ссылкой типа object можно воспользоваться
// для обращения к любому другому типу, в том числе и к типам значений.
// Когда ссылка на объект класса object используется для обращения к типу значения,
// то такой процесс называется упаковкой. Упаковка приводит к тому, что значение простого
// типа сохраняется в экземпляре объекта, т.е. "упаковывается" в объекте, который
// затем используется как и любой другой объект. Но в любом случае упаковка происходит
// автоматически. Для этого достаточно присвоить значение переменной ссылочного
// типа object, а об остальном позаботится компилятор С#.

// Распаковка представляет собой процесс извлечения упакованного значения из
// объекта. Это делается с помощью явного приведения типа ссылки на объект класса
// object к соответствующему типу значения. Попытка распаковать объект в другой тип
// может привести к ошибке во время выполнения.

// Ниже приведен простой пример, демонстрирующий упаковку и распаковку.

//Простой пример упаковки и распаковки.
using System;

class BoxingDemo
{
    static void Main()
    {
        int x;
        object obj;

        x = 10;
        obj = x; //упаковать значение переменной x в объект

        int y = (int)obj; //распаковать значение из объекта, доступного по ссылке obj, в переменную типа int

        Console.WriteLine(y);

        //Задержка программы.
        Console.ReadKey();
    }
}

// В этом примере кода выводится значение 10. Обратите внимание на то, что значение
// переменной х упаковывается в объект простым его присваиванием переменной
// obj, ссылающейся на этот объект. А затем это значение извлекается из объекта, доступного
// по его ссылке obj, и далее приводится к типу int.

#endregion

#region English

// Boxing and Unboxing

// As explained, all C# types, including the value types, are derived from object. Thus, a
// reference of type object can be used to refer to any other type, including value types. When
// an object reference refers to a value type, a process known as boxing occurs. Boxing causes
// the value of a value type to be stored in an object instance. Thus, a value type is “boxed”
// inside an object. This object can then be used like any other object. In all cases, boxing occurs
// automatically. You simply assign a value to an object reference. C# handles the rest.

// Unboxing is the process of retrieving a value from a boxed object. This action is performed
// using an explicit cast from the object reference to its corresponding value type.Attempting
// to unbox an object into a different type will result in a runtime error.

// Here is a simple example that illustrates boxing and unboxing:

// A simple boxing/unboxing example. 

// using System; 

// class BoxingDemo
// {
//    static void Main()
//    {
//        int x;
//        object obj;

//        x = 10;
//        obj = x; // box x into an object 

//        int y = (int)obj; // unbox obj into an int 
//        Console.WriteLine(y);
//    }
// }

// This program displays the value 10. Notice that the value in x is boxed simply by assigning
// it to obj, which is an object reference. The integer value in obj is retrieved by casting obj
// to int.

#endregion