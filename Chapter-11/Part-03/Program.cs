#region Russian

// Как пояснялось в предыдущей главе, свойство позволяет управлять доступом к переменной
// экземпляра. Например, с помощью свойства можно ввести ограничения на
// доступ к значению переменной или же сделать ее доступной только для чтения. Так,
// если сделать свойство открытым, но объявить его базовую переменную закрытой, то
// этим свойством можно будет воспользоваться в производном классе, но нельзя будет
// получить непосредственный доступ к его базовой закрытой переменной.

// Ниже приведен вариант класса TwoDShape, в котором переменные Width и Height
// превращены в свойства. По ходу дела в этом классе выполняется проверка: являются ли
// положительными значения свойств Width и Height. Это дает, например, возможность
// указывать свойства Width и Height в качестве координат формы в любом квадранте
// прямоугольной системы координат, не получая заранее их абсолютные значения.

//Использовать открытые свойства для установки и получения значений закрытых членов класса.
using System;

//Класс для двумерных объектов.
class TwoDShape
{
    double pri_width; //теперь это закрытая переменная
    double pri_height; //теперь это закрытая переменная

    //Свойства ширины и высоты двумерного объекта.
    public double Width
    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }

    public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }

    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " " + Height);
    }
}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    public string Style; //тип треугольника

    //Возвратить площадь треугольника.
    public double Area()
    {
        return Width * Height / 2;
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник: " + Style);
    }
}


class Shapes2
{
    static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();

        t1.Width = 4.0;
        t1.Height = 4.0;
        t1.Style = "равнобедренный";

        t2.Width = 8.0;
        t2.Height = 12.0;
        t2.Style = "прямоугольный";

        Console.WriteLine("Сведения об объекте t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Площадь равна " + t2.Area());

        //Задержка программы.
        Console.ReadKey();
    }
}

// В этом варианте свойства Width и Height предоставляют доступ к закрытым членам
// pri_width и pri_height класса TwoDShape, в которых фактически хранятся
// значения ширины и высоты двумерного объекта. Следовательно, значения членов
// pri_width и pri_height класса TwoDShape могут быть установлены и получены с
// помощью соответствующих открытых свойств, несмотря на то, что сами эти члены по-
// прежнему остаются закрытыми.

// Базовый и производный классы иногда еще называют суперклассом и подклассом
// соответственно. Эти термины происходят из практики программирования на Java.
// То, что в Java называется суперклассом, в C# обозначается как базовый класс. А то, что
// в Java называется подклассом, в C# обозначается как производный класс. Оба ряда терминов
// часто применяются к классу в обоих языках программирования, но в этой книге
// по-прежнему употребляются общепринятые в C# термины базового и производного
// классов, которые принято употреблять и в C++.

#endregion

#region English

// As explained in the previous chapter, a property allows you to manage access to an
// instance variable. For example, you can enforce constraints on its values, or you can make
// the variable read-only. By making a property public, but declaring its underlying variable
// private, a derived class can still use the property, but it cannot directly access the underlying
// private variable.

// Here is a rewrite of the TwoDShape class that makes Width and Height into properties.
// In the process, it ensures that the values of Width and Height will be positive. This would
// allow you, for example, to specify the Width and Height using the coordinates of the shape
// in any quadrant of the Cartesian plane without having to first obtain their absolute values.

// Use public properties to set and get private members. 

// using System; 

// // A class for two-dimensional objects. 
// class TwoDShape
// {
//    double pri_width;  // now private 
//    double pri_height; // now private  

//    // Properties for width and height. 
//    public double Width
//    {
//        get { return pri_width; }
//        set { pri_width = value < 0 ? -value : value; }
//    }

//    public double Height
//    {
//        get { return pri_height; }
//        set { pri_height = value < 0 ? -value : value; }
//    }

//    public void ShowDim()
//    {
//        Console.WriteLine("Width and height are " +
//                           Width + " and " + Height);
//    }
// }

// // A derived class of TwoDShape for triangles. 
// class Triangle : TwoDShape
// {
//    public string Style; // style of triangle 

//    // Return area of triangle. 
//    public double Area()
//    {
//        return Width * Height / 2;
//    }

//    // Display a triangle's style. 
//    public void ShowStyle()
//    {
//        Console.WriteLine("Triangle is " + Style);
//    }
// }

// class Shapes2
// {
//    static void Main()
//    {
//        Triangle t1 = new Triangle();
//        Triangle t2 = new Triangle();

//        t1.Width = 4.0;
//        t1.Height = 4.0;
//        t1.Style = "isosceles";

//        t2.Width = 8.0;
//        t2.Height = 12.0;
//        t2.Style = "right";

//        Console.WriteLine("Info for t1: ");
//        t1.ShowStyle();
//        t1.ShowDim();
//        Console.WriteLine("Area is " + t1.Area());

//        Console.WriteLine();

//        Console.WriteLine("Info for t2: ");
//        t2.ShowStyle();
//        t2.ShowDim();
//        Console.WriteLine("Area is " + t2.Area());
//    }
// }

// In this version, the properties Width and Height provide access to the private members,
// pri_width and pri_height, which actually store the values. Therefore, even though
// pri_width and pri_height are private to TwoDShape, their values can still be set and
// obtained through their corresponding public properties.

// When referring to base and derived classes, sometimes the terms superclass and subclass
// are used. These terms come from Java programming. What Java calls a superclass, C# calls
// a base class. What Java calls a subclass, C# calls a derived class. You will commonly hear
// both sets of terms applied to a class of either language, but this book will continue to use
// the standard C# terms. C++ also uses the base-class/derived-class terminology.

#endregion