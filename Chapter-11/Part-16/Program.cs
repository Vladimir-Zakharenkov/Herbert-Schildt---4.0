#region Russian

// Виртуальные методы и их переопределение

// Виртуальным называется такой метод, который объявляется как virtual в базовом
// классе. Виртуальный метод отличается тем, что он может быть переопределен в одном
// или нескольких производных классах. Следовательно, у каждого производного класса
// может быть свой вариант виртуального метода. Кроме того, виртуальные методы интересны
// тем, что именно происходит при их вызове по ссылке на базовый класс. В этом
// случае средствами языка C# определяется именно тот вариант виртуального метода,
// который следует вызывать, исходя из типа объекта, к которому происходит обращение
// по ссылке, причем это делается во время выполнения. Поэтому при ссылке на разные
// типы объектов выполняются разные варианты виртуального метода. Иными словами,
// вариант выполняемого виртуального метода выбирается по типу объекта, а не по типу
// ссылки на этот объект. Так, если базовый класс содержит виртуальный метод и от него
// получены производные классы, то при обращении к разным типам объектов по ссылке
// на базовый класс выполняются разные варианты этого виртуального метода.

// Метод объявляется как виртуальный в базовом классе с помощью ключевого слова
// virtual, указываемого перед его именем. Когда же виртуальный метод переопределяется
// в производном классе, то для этого используется модификатор override.
// А сам процесс повторного определения виртуального метода в производном классе
// называется переопределением метода. При переопределении имя, возвращаемый тип
// и сигнатура переопределяющего метода должны быть точно такими же, как и у того
// виртуального метода, который переопределяется. Кроме того, виртуальный метод не
// может быть объявлен как static или abstract (подробнее данный вопрос рассматривается
// далее в этой главе).

// Переопределение метода служит основанием для воплощения одного из самых
// эффективных в C# принципов: динамической диспетчеризации методов, которая представляет
// собой механизм разрешения вызова во время выполнения, а не компиляции.
// Значение динамической диспетчеризации методов состоит в том, что именно благодаря
// ей в C# реализуется динамический полиморфизм.

// Ниже приведен пример, демонстрирующий виртуальные методы и их переопределение.

//Продемонстрировать виртуальный метод.
using System;

class Base
{
    //Создать виртуальный метод в базовом классе.
    public virtual void Who()
    {
        Console.WriteLine("Метод Who() в классе Base");
    }
}

class Derived1 : Base
{
    //Переопределить метод Who() в производном классе.
    public override void Who()
    {
        Console.WriteLine("Метод Who() в классе Derived1");
    }
}

class Derived2 : Base
{
    //Вновь переопределить метод Who() в еще одном производном классе.
    public override void Who()
    {
        Console.WriteLine("Метод Who() в классе Derived2");
    }
}

class OverrideDemo
{
    static void Main()
    {
        Base baseOb = new Base();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();

        Base baseRef; //ссылка на базовый класс

        baseRef = baseOb;
        baseRef.Who();

        baseRef = dOb1;
        baseRef.Who();

        baseRef = dOb2;
        baseRef.Who();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этого кода.

// Метод Who() в классе Base.
// Метод Who() в классе Derived1
// Метод Who() в классе Derived2

// В коде из приведенного выше примера создаются базовый класс Base и два производных
// от него класса — Derived1 и Derived2. В классе Base объявляется виртуальный
// метод Who(), который переопределяется в обоих производных классах. Затем в
// методе Main() объявляются объекты типа Base, Derived1 и Derived2. Кроме того,
// объявляется переменная baseRef ссылочного типа Base. Далее ссылка на каждый тип
// объекта присваивается переменной baseRef и затем используется для вызова метода
// Who(). Как следует из результата выполнения приведенного выше кода, вариант
// выполняемого метода Who() определяется по типу объекта, к которому происходит
// обращение по ссылке во время вызова этого метода, а не по типу класса переменной
// baseRef.

#endregion

#region English

// Virtual Methods and Overriding

// A virtual method is a method that is declared as virtual in a base class. The defining
// characteristic of a virtual method is that it can be redefined in one or more derived classes.
// Thus, each derived class can have its own version of a virtual method. Virtual methods are
// interesting because of what happens when one is called through a base class reference. In
// this situation, C# determines which version of the method to call based upon the type of the
// object referred to by the reference—and this determination is made at runtime.Thus, when
// different objects are referred to, different versions of the virtual method are executed.In
// other words, it is the type of the object being referred to (not the type of the reference) that
// determines which version of the virtual method will be executed. Therefore, if a base class
// contains a virtual method and classes are derived from that base class, then when different
// types of objects are referred to through a base class reference, different versions of the
// virtual method can be executed.

// You declare a method as virtual inside a base class by preceding its declaration with the
// keyword virtual. When a virtual method is redefined by a derived class, the override modifier
// is used.Thus, the process of redefining a virtual method inside a derived class is called method
// overriding.When overriding a method, the name, return type, and signature of the overriding
// method must be the same as the virtual method that is being overridden. Also, a virtual
// method cannot be specified as static or abstract (discussed later in this chapter).

// Method overriding forms the basis for one of C#’s most powerful concepts: dynamic
// method dispatch. Dynamic method dispatch is the mechanism by which a call to an overridden
// method is resolved at runtime, rather than compile time. Dynamic method dispatch is
// important because this is how C# implements runtime polymorphism.

// Here is an example that illustrates virtual methods and overriding:

// Demonstrate a virtual method. 

// using System; 

// class Base
// {
//    // Create virtual method in the base class.  
//    public virtual void Who()
//    {
//        Console.WriteLine("Who() in Base");
//    }
// }

// class Derived1 : Base
// {
//    // Override Who() in a derived class. 
//    public override void Who()
//    {
//        Console.WriteLine("Who() in Derived1");
//    }
// }

// class Derived2 : Base
// {
//    // Override Who() again in another derived class. 
//    public override void Who()
//    {
//        Console.WriteLine("Who() in Derived2");
//    }
// }

// class OverrideDemo
// {
//    static void Main()
//    {
//        Base baseOb = new Base();
//        Derived1 dOb1 = new Derived1();
//        Derived2 dOb2 = new Derived2();

//        Base baseRef; // a base-class reference 

//        baseRef = baseOb;
//        baseRef.Who();

//        baseRef = dOb1;
//        baseRef.Who();

//        baseRef = dOb2;
//        baseRef.Who();
//    }
// }

// The output from the program is shown here:

// Who() in Base
// Who() in Derived1
// Who() in Derived2

// This program creates a base class called Base and two derived classes, called Derived1
// and Derived2. Base declares a method called Who( ), and the derived classes override it.
// Inside the Main( ) method, objects of type Base, Derived1, and Derived2 are declared. Also,
// a reference of type Base, called baseRef, is declared. The program then assigns a reference
// to each type of object to baseRef and uses that reference to call Who( ). As the output
// shows, the version of Who( ) executed is determined by the type of object being referred
// to at the time of the call, not by the class type of baseRef.

#endregion