#region Russian

// В качестве примера ниже приведен вариант предыдущей программы, где демонстрируется
// присваивание переменных ссылки на объекты определенного класса.

//Использовать ссылки на объекты определенного класса.
using System;

//Создать класс.
class MyClass
{
    public int x;
}

//Показать присваивание разных объектов данного класса.
class ClassAssignment
{
    static void Main()
    {
        MyClass a = new MyClass();
        MyClass b = new MyClass();

        a.x = 10;
        b.x = 20;

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

        a = b;
        b.x = 30;

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

        //Задержка программы.
        Console.ReadKey();
    }

    // Выполнение этой программы приводит к следующему результату.

    // a.х 10, b.x 20
    // а.х 30, b.x 30

    // Как видите, после того как переменная b будет присвоена переменной а, обе переменные
    // станут указывать на один и тот же объект, т.е.на тот объект, на который первоначально
    // указывала переменная b.
}

#endregion

#region English

// For example, here is the class version of the preceding program:

// Copy a class. 
 
// using System; 
 
// // Now a class. 
// class MyClass
// {
//    public int x;
// }

// // Now show a class object assignment. 
// class ClassAssignment
// {
//    static void Main()
//    {
//        MyClass a = new MyClass();
//        MyClass b = new MyClass();

//        a.x = 10;
//        b.x = 20;

//        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

//        a = b;
//        b.x = 30;

//        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
//    }
// }

// The output from this version is shown here:

// a.x 10, b.x 20
// a.x 30, b.x 30

// As you can see, after the assignment of b to a, both variables refer to the same object—the
// one originally referred to by b.

#endregion