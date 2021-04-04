#region Russian

// Для любого производного класса можно указать только один базовый класс. В C# не
// предусмотрено наследование нескольких базовых классов в одном производном классе.
// (В этом отношении C# отличается от C++, где допускается наследование нескольких
// базовых классов. Данное обстоятельство следует принимать во внимание при переносе
// кода C++ в С#.) Тем не менее можно создать иерархию наследования, в которой производный
// класс становится базовым для другого производного класса. (Разумеется, ни
// один из классов не может быть базовым для самого себя как непосредственно, так и
// косвенно.) Но в любом случае производный класс наследует все члены своего базового
// класса, в том числе переменные экземпляра, методы, свойства и индексаторы.

// Главное преимущество наследования заключается в следующем: как только будет
// создан базовый класс, в котором определены общие для множества объектов атрибуты,
// он может быть использован для создания любого числа более конкретных производных
// классов. А в каждом производном классе может быть точно выстроена своя
// собственная классификация. В качестве примера ниже приведен еще один класс, производный
// от класса TwoDShape и инкапсулирующий прямоугольники.

// Класс для прямоугольников, производный от класса TwoDShape.
// class Rectangle : TwoDShape
// {
//    // Возвратить логическое значение true, если прямоугольник является квадратом.
//    public bool IsSquare()
//    {
//        if (Width == Height) return true;
//        return false;
//    }

//    // Возвратить площадь прямоугольника.
//    public double Area()
//    {
//        return Width * Height;
//    }
// }

// В класс Rectangle входят все члены класса TwoDShape, к которым добавлен метод
// IsSquare(), определяющий, является ли прямоугольник квадратом, а также метод
// Area(), вычисляющий площадь прямоугольника.

// Доступ к членам класса и наследование

// Как пояснялось в главе 8, члены класса зачастую объявляются закрытыми, чтобы
// исключить их несанкционированное или незаконное использование. Но наследование
// класса не отменяет ограничения, накладываемые на доступ к закрытым членам класса.
// Поэтому если в производный класс и входят все члены его базового класса, в нем все
// равно оказываются недоступными те члены базового класса, которые являются закрытыми.
// Так, если сделать закрытыми переменные класса TwoDShape, они станут недоступными
// в классе Triangle, как показано ниже.

//Доступ к закрытым членам класса не наследуется.
//Этот пример не подлежит компиляции.

using System;

//Класс для двумерных объектов.
class TwoDShape
{
    double Width; //теперь это закрытая переменная
    double Height; //теперь это закрытая переменная

    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }
}

//Класс Triangle, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    public string Style; //тип треугольника

    //Возвратить площадь треугольника.
    public double Area()
    {
        return Width * Height / 2; //Ошибка, доступ к закрытому члену класса запрещен.
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}

// Класс Triangle не будет компилироваться, потому что обращаться к переменным
// Width и Height из метода Area() запрещено.А поскольку переменные Width и
// Height теперь являются закрытыми, то они доступны только для других членов своего
// класса, но не для членов производных классов.

// ПРИМЕЧАНИЕ
// Закрытый член класса остается закрытым в своем классе. Он не доступен из кода за
// пределами своего класса, включая и производные классы.

// На первый взгляд, ограничение на доступ к частным членам базового класса из производного
// класса кажется трудно преодолимым, поскольку оно не дает во многих случаях
// возможности пользоваться частными членами этого класса. Но на самом деле это
// не так. Для преодоления данного ограничения в C# предусмотрены разные способы.
// Один из них состоит в использовании защищенных (protected) членов класса, рассматриваемых
// в следующем разделе, а второй — в применении открытых свойств для
// доступа к закрытым данным.

#endregion

#region English

// You can specify only one base class for any derived class that you create.C# does not
// support the inheritance of multiple base classes into a single derived class. (This differs
// from C++, in which you can inherit multiple base classes. Be aware of this when converting
// C++ code to C#.) You can, however, create a hierarchy of inheritance in which a derived
// class becomes a base class of another derived class. (Of course, no class can be a base class
// of itself, either directly or indirectly.) In all cases, a derived class inherits all of the members
// of its base class. This includes instance variables, methods, properties, and indexers.

// A major advantage of inheritance is that once you have created a base class that defines
// the attributes common to a set of objects, it can be used to create any number of more
// specific derived classes. Each derived class can precisely tailor its own classification. For
// example, here is another class derived from TwoDShape that encapsulates rectangles:

// // A derived class of TwoDShape for rectangles.
// class Rectangle : TwoDShape
// {
//    // Return true if the rectangle is square.
//    public bool IsSquare()
//    {
//        if (Width == Height) return true;
//        return false;
//    }
//    // Return area of the rectangle.
//    public double Area()
//    {
//        return Width * Height;
//    }
// }

// The Rectangle class includes TwoDShape and adds the methods IsSquare( ), which
// determines if the rectangle is square, and Area( ), which computes the area of a rectangle.

// Member Access and Inheritance

// As explained in Chapter 8, members of a class are often declared private to prevent their
// unauthorized use or tampering. Inheriting a class does not overrule the private access
// restriction.Thus, even though a derived class includes all of the members of its base class,
// it cannot access those members of the base class that are private. For example, if, as shown
// here, Width and Height are made private in TwoDShape, then Triangle will not be able to
// access them:

// Access to private members are not inherited.  
// This example will not compile. 
// using System; 

// // A class for two-dimensional objects. 
// class TwoDShape
// {
//    double Width;  // now private 
//    double Height; // now private 

//    public void ShowDim()
//    {
//        Console.WriteLine("Width and height are " +
//                           Width + " and " + Height);
//    }
// }

// // Triangle is derived from TwoDShape. 
// class Triangle : TwoDShape
// {
//    public string Style; // style of triangle 

//    // Return area of triangle. 
//    public double Area()
//    {
//        return Width * Height / 2; // Error, can't access private member 
//    }

//    // Display a triangle's style. 
//    public void ShowStyle()
//    {
//        Console.WriteLine("Triangle is " + Style);
//    }
// }

// The Triangle class will not compile because the use of Width and Height inside the
// Area( ) method is illegal.Since Width and Height are now private, they are accessible only
// to other members of their own class. Derived classes have no access to them.

// REMEMBER
// A private class member will remain private to its class. It is not accessible to any code
// outside its class, including derived classes.

// At first, you might think that it is a serious restriction that derived classes do not have
// access to the private members of base classes because it would prevent the use of private
// members in many situations.However, this is not true; C# provides various solutions. One
// is to use protected members, which is described in the next section. A second is to use public
// properties to provide access to private data.

#endregion