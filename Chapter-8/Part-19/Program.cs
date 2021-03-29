// Перегрузка конструкторов

// Как и методы, конструкторы также могут перегружаться. Это дает возможность
// конструировать объекты самыми разными способами. В качестве примера рассмотрим
// следующую программу.

//Продемонстрировать перегрузку конструктора.
using System;

class MyClass
{
    public int x;

    public MyClass()
    {
        Console.WriteLine("В конструкторе MyClass().");
        x = 0;
    }

    public MyClass(int i)
    {
        Console.WriteLine("В конструкторе MyClass(int).");
        x = i;
    }

    public MyClass(double d)
    {
        Console.WriteLine("В конструкторе MyClass(double).");
        x = (int)d;
    }

    public MyClass(int i, int j)
    {
        Console.WriteLine("В конструкторе MyClass(int, int).");
        x = i * j;
    }
}

class OverloadConsDemo
{
    static void Main()
    {
        MyClass t1 = new MyClass();
        MyClass t2 = new MyClass(88);
        MyClass t3 = new MyClass(17.23);
        MyClass t4 = new MyClass(2, 4);

        Console.WriteLine("t1.x: " + t1.x);
        Console.WriteLine("t2.x: " + t2.x);
        Console.WriteLine("t3.x: " + t3.x);
        Console.WriteLine("t4.x: " + t4.x);

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// В конструкторе MyClass().
// В конструкторе MyClass(int).
// В конструкторе MyClass(double).
// В конструкторе MyClass(int, int).
// t1.x: 0
// t2.x: 88
// t3.x: 17
// t4.x: 8

// В данном примере конструктор MyClass() перегружается четыре раза, всякий раз
// конструируя объект по-разному. Подходящий конструктор вызывается каждый раз,
// исходя из аргументов, указываемых при выполнении оператора new. Перегрузка конструктора
// класса предоставляет пользователю этого класса дополнительные преимущества
// в конструировании объектов.