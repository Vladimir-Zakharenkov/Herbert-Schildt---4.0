#region Russian

// Наследование интерфейсов

// Один интерфейс может наследовать другой. Синтаксис наследования интерфейсов
// такой же, как и у классов. Когда в классе реализуется один интерфейс, наследующий
// другой, в нем должны быть реализованы все члены, определенные в цепочке наследования
// интерфейсов, как в приведенном ниже примере.

//Пример наследования интерфейсов.
using System;

public interface IA
{
    void Meth1();
    void Meth2();
}

//В базовом интерфейсе включены методы Meth1() и Meth2(),
//а в производный интерфейс добавлен еще один метод - Meth3().
public interface IB : IA
{
    void Meth3();
}

//В этом классе должны быть реализованы все методы интерфейсов Ia и IB.
class MyClass : IB
{
    public void Meth1()
    {
        Console.WriteLine("Реализовать метод Meth1().");
    }

    public void Meth2()
    {
        Console.WriteLine("Реализовать метод Meth2().");
    }

    public void Meth3()
    {
        Console.WriteLine("Реализовать метод Meth3().");
    }
}

class IFExtend
{
    static void Main()
    {
        MyClass ob = new MyClass();

        ob.Meth1();
        ob.Meth2();
        ob.Meth3();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Ради интереса попробуйте удалить реализацию метода Meth1() из класса MyClass.
// Это приведет к ошибке во время компиляции. Как пояснялось ранее, в любом классе,
// реализующем интерфейс, должны быть реализованы все методы, определенные в этом
// интерфейсе, в том числе и те, что наследуются из других интерфейсов.

#endregion

#region English

// Interfaces Can Be Inherited

// One interface can inherit another. The syntax is the same as for inheriting classes. When a
// class implements an interface that inherits another interface, it must provide implementations
// for all the members defined within the interface inheritance chain. Here is an example:

// One interface can inherit another. 

// using System; 

// public interface IA
// {
//    void Meth1();
//    void Meth2();
// }

// // B now includes Meth1() and Meth2() -- it adds Meth3(). 
// public interface IB : IA
// {
//    void Meth3();
// }

// // This class must implement all of IA and IB 
// class MyClass : IB
// {
//    public void Meth1()
//    {
//        Console.WriteLine("Implement Meth1().");
//    }

//    public void Meth2()
//    {
//        Console.WriteLine("Implement Meth2().");
//    }

//    public void Meth3()
//    {
//        Console.WriteLine("Implement Meth3().");
//    }
// }

// class IFExtend
// {
//    static void Main()
//    {
//        MyClass ob = new MyClass();

//        ob.Meth1();
//        ob.Meth2();
//        ob.Meth3();
//    }
// }

// As an experiment, you might try removing the implementation for Meth1() in MyClass.
// This will cause a compile-time error. As stated earlier, any class that implements an interface
// must implement all methods defined by that interface, including any that are inherited from
// other interfaces.

#endregion