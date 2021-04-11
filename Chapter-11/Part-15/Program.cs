#region Russian

// Один из самых важных моментов для присваивания ссылок на объекты производного
// класса переменным базового класса наступает тогда, когда конструкторы вызываются
// в иерархии классов. Как вам должно быть уже известно, в классе нередко
// определяется конструктор, принимающий объект своего класса в качестве параметра.
// Благодаря этому в классе может быть сконструирована копия его объекта. Этой особенностью
// можно выгодно воспользоваться в классах, производных от такого класса.
// В качестве примера рассмотрим очередные варианты классов TwoDShape и Triangle.
// В оба класса добавлены конструкторы, принимающие объект в качестве параметра.

//Передать ссылку на объект производного класса переменной ссылки на объект базового класса.
using System;

class TwoDShape
{
    double pri_width;
    double pri_height;

    //Свойства ширины и высоты объекта.
    public double Width
    {
        get
        {
            return pri_width;
        }
        set
        {
            pri_width = value < 0 ? -value : value;
        }
    }

    public double Height
    {
        get
        {
            return pri_height;
        }
        set
        {
            pri_height = value < 0 ? -value : value;
        }
    }

    //Конструктор по умолчанию.
    public TwoDShape()
    {
        Width = Height = 0.0;
    }

    //Конструктор для класса TwoDShape.
    public TwoDShape(double w, double h)
    {
        Width = w;
        Height = h;
    }

    //Сконструировать объект равной ширины и высоты.
    public TwoDShape(double x)
    {
        Width = Height = x;
    }

    //Сконструировать копию объекта TwoDShape.
    public TwoDShape(TwoDShape ob)
    {
        Width = ob.Width;
        Height = ob.Height;
    }

    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }
}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string Style;

    //Конструктор, используемый по умолчанию.
    public Triangle()
    {
        Style = null;
    }

    //Конструктор для класса Triangle.
    public Triangle(string s, double w, double h) : base(w, h)
    {
        Style = s;
    }

    //Сконструировать равнобедренный треугольник.
    public Triangle(double x) : base(x)
    {
        Style = "равнобедренный";
    }

    //Сконструировать копию объекта типа Triangle.
    public Triangle(Triangle ob) : base(ob)
    {
        Style = ob.Style;
    }

    //Возвратить площадь треугольника.
    public double Area()
    {
        return Width * Height / 2;
    }

    //Показать тип треугольника.
    public void ShowStyle()
    {
        Console.WriteLine("Треугольник " + Style);
    }
}

class Shapes7
{
    static void Main()
    {
        Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);

        //Сделать копию объекта t1.
        Triangle t2 = new Triangle(t1);

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

// В представленном выше примере объект t2 конструируется из объекта t1 и поэтому
// подобен ему. Ниже приведен результат выполнения кода из данного примера.

// Сведения об объекте t1:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Площадь равна 48

// Сведения об объекте t2:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Площадь равна 48

// Обратите особое внимание на следующий конструктор класса Triangle:

// public Triangle(Triangle ob) : base(ob) {
//    Style = ob.Style;
// }

// Он принимает объект типа Triangle в качестве своего параметра и передает его
// (с помощью ключевого слова base) следующему конструктору класса TwoDShape.

// public TwoDShape(TwoDShape ob)
// {
//    Width = ob.Width;
//    Height = ob.Height;
// }

// Самое любопытное, что конструктор TwoDShape() предполагает получить объект
// класса TwoDShape, тогда как конструктор Triangle() передает ему объект класса
// Triangle. Как пояснялось выше, такое вполне допустимо, поскольку по ссылке на
// объект базового класса можно обращаться к объекту производного класса. Следовательно,
// конструктору TwoDShape() можно на совершенно законных основаниях передать
// ссылку на объект класса, производного от класса TwoDShape. А поскольку конструктор
// TwoDShape() инициализирует только те части объекта производного класса,
// которые являются членами класса TwoDShape, то для него не имеет никакого значения,
// содержит ли этот объект другие члены, добавленные в производном классе.

#endregion

#region English

// An important place where derived class references are assigned to base class variables
// is when constructors are called in a class hierarchy. As you know, it is common for a class
// to define a constructor that takes an object of its class as a parameter.This allows the class to
// construct a copy of an object. Classes derived from such a class can take advantage of this
// feature. For example, consider the following versions of TwoDShape and Triangle. Both
// add constructors that take an object as a parameter.

// Pass a derived class reference to a base class reference. 
 
// using System; 
 
// class TwoDShape
// {
//    double pri_width;
//    double pri_height;

//    // Default constructor. 
//    public TwoDShape()
//    {
//        Width = Height = 0.0;
//    }

//    // Constructor for TwoDShape. 
//    public TwoDShape(double w, double h)
//    {
//        Width = w;
//        Height = h;
//    }

//    // Construct object with equal width and height. 
//    public TwoDShape(double x)
//    {
//        Width = Height = x;
//    }

//    // Construct a copy of a TwoDShape object. 
//    public TwoDShape(TwoDShape ob)
//    {
//        Width = ob.Width;
//        Height = ob.Height;
//    }

//    // Properties for Width and Height. 
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

// A derived class of TwoDShape for triangles. 
// class Triangle : TwoDShape
// {
//    string Style;

//    // A default constructor. 
//    public Triangle()
//    {
//        Style = "null";
//    }

//    // Constructor for Triangle. 
//    public Triangle(string s, double w, double h) : base(w, h)
//    {
//        Style = s;
//    }

//    // Construct an isosceles triangle. 
//    public Triangle(double x) : base(x)
//    {
//        Style = "isosceles";
//    }

//    // Construct a copy of a Triangle object. 
//    public Triangle(Triangle ob) : base(ob)
//    {
//        Style = ob.Style;
//    }

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

// class Shapes7
// {
//    static void Main()
//    {
//        Triangle t1 = new Triangle("right", 8.0, 12.0);

//        // Make a copy of t1. 
//        Triangle t2 = new Triangle(t1);

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

// In this program, t2 is constructed from t1 and is, thus, identical.The output is shown here:

// Info for t1:
// Triangle is right
// Width and height are 8 and 12
// Area is 48

// Info for t2:
// Triangle is right
// Width and height are 8 and 12
// Area is 48

// Pay special attention to this Triangle constructor:

// public Triangle(Triangle ob) : base(ob) {
//    Style = ob.Style;
// }

// It receives an object of type Triangle, and it passes that object (through base) to this
// TwoDShape constructor:

// public TwoDShape(TwoDShape ob)
// {
//    Width = ob.Width;
//    Height = ob.Height;
// }

// The key point is that TwoDShape( ) is expecting a TwoDShape object.However,
// Triangle() passes it a Triangle object. As explained, the reason this works is because a base
// class reference can refer to a derived class object. Thus, it is perfectly acceptable to pass
// TwoDShape( ) a reference to an object of a class derived from TwoDShape. Because the
// TwoDShape() constructor is initializing only those portions of the derived class object
// that are members of TwoDShape, it doesn’t matter that the object might also contain other
// members added by derived classes.

#endregion