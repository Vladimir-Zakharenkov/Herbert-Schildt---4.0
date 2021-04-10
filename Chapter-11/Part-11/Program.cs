#region Russian

// Создание многоуровневой иерархии классов

// В представленных до сих пор примерах программ использовались простые иерархии
// классов, состоявшие только из базового и производного классов. Но в C# можно
// также строить иерархии, состоящие из любого числа уровней наследования. Как
// упоминалось выше, многоуровневая иерархия идеально подходит для использования
// одного производного класса в качестве базового для другого производного класса. Так,
// если имеются три класса, А, В и С, то класс С может наследовать от класса В, а тот,
// в свою очередь, от класса А. В таком случае каждый производный класс наследует характерные
// особенности всех своих базовых классов. В частности, класс С наследует все
// члены классов В и А.

// Для того чтобы показать, насколько полезной может оказаться многоуровневая
// иерархия классов, рассмотрим следующий пример программы. В ней производный
// класс Triangle служит в качестве базового для создания другого производного класса
// — ColorTriangle. При этом класс ColorTriangle наследует все характерные особенности,
// а по существу, члены классов Triangle и TwoDShape, к которым добавляется
// поле color, содержащее цвет треугольника.

//Пример построения многоуровневой иерархии классов.
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

    //Конструктор, используемый по умолчанию.
    public TwoDShape()
    {
        Width = Height = 0;
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

    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
    }
}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string Style; //закрытый член класса

    //Конструктор используемый, по умолчанию.
    //Автоматически вызывает конструктор, доступный поо умолчанию в классе TwoDShape.
    public Triangle()
    {
        Style = null;
    }

    //Конструктор.
    public Triangle(string s, double w, double h) : base(w, h)
    {
        Style = s;
    }

    //Сконструировать равнобедренный треугольник.
    public Triangle(double x) : base(x)
    {
        Style = "равнобедренный";
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

//Расширить класс Triangle.
class ColorTriangle : Triangle
{
    string color;

    public ColorTriangle(string c, string s, double w, double h) : base(s, w, h)
    {
        color = c;
    }

    //Показать цвет треугольника.
    public void ShowColor()
    {
        Console.WriteLine("Цвет " + color);
    }
}

class Shapes6
{
    static void Main()
    {
        ColorTriangle t1 = new ColorTriangle("синий", "прямоугольный", 8.0, 12.0);
        ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2.0, 2.0);

        Console.WriteLine("Сведения об объекте t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        t1.ShowColor();
        Console.WriteLine("Площадь равна " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        t2.ShowColor();
        Console.WriteLine("Площадь равна " + t2.Area());

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующей результат.

// Сведения об объекте t1:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Цвет синий
// Площадь равна 48

// Сведения об объекте t2:
// Треугольник равнобедренный
// Ширина и высота равны 2 и 2
// Цвет красный
// Площадь равна 2

// Благодаря наследованию в классе ColorTriangle могут использоваться определенные
// ранее классы Triangle и TwoDShape, к элементам которых добавляется лишь
// та информация, которая требуется для конкретного применения данного класса.
// В этом отчасти и состоит ценность наследования, поскольку оно допускает повторное
// использование кода.

// Приведенный выше пример демонстрирует еще одно важное положение: ключевое
// слово base всегда обозначает ссылку на конструктор ближайшего по иерархии
// базового класса. Так, ключевое слово base в классе ColorTriangle обозначает вызов
// конструктора из класса Triangle, а ключевое слово base в классе Triangle — вызов
// конструктора из класса TwoDShape. Если же в иерархии классов конструктору базового
// класса требуются параметры, то все производные классы должны предоставлять
// эти параметры вверх по иерархии, независимо от того, требуются они самому производному
// классу или нет.

#endregion

#region English

// Creating a Multilevel Hierarchy

// Up to this point, we have been using simple class hierarchies consisting of only a base class
// and a derived class. However, you can build hierarchies that contain as many layers of
// inheritance as you like. As mentioned, it is perfectly acceptable to use a derived class as a
// base class of another.For example, given three classes called A, B, and C, C can be derived
// from B, which can be derived from A. When this type of situation occurs, each derived class
// inherits all of the traits found in all of its base classes. In this case, C inherits all aspects of
// B and A.

// To see how a multilevel hierarchy can be useful, consider the following program.
// In it, the derived class Triangle is used as a base class to create the derived class called
// ColorTriangle.ColorTriangle inherits all of the traits of Triangle and TwoDShape and
// adds a field called color, which holds the color of the triangle.

// A multilevel hierarchy. 

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

// // A derived class of TwoDShape for triangles. 
// class Triangle : TwoDShape
// {
//    string Style; // private 

//    /* A default constructor. This invokes the default 
//       constructor of TwoDShape. */
//    public Triangle()
//    {
//        Style = "null";
//    }

//    // Constructor. 
//    public Triangle(string s, double w, double h) : base(w, h)
//    {
//        Style = s;
//    }

//    // Construct an isosceles triangle. 
//    public Triangle(double x) : base(x)
//    {
//        Style = "isosceles";
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

// // Extend Triangle. 
// class ColorTriangle : Triangle
// {
//    string color;

//    public ColorTriangle(string c, string s,
//                         double w, double h) : base(s, w, h)
//    {
//        color = c;
//    }

//    // Display the color. 
//    public void ShowColor()
//    {
//        Console.WriteLine("Color is " + color);
//    }
// }

// class Shapes6
// {
//    static void Main()
//    {
//        ColorTriangle t1 =
//             new ColorTriangle("Blue", "right", 8.0, 12.0);
//        ColorTriangle t2 =
//             new ColorTriangle("Red", "isosceles", 2.0, 2.0);

//        Console.WriteLine("Info for t1: ");
//        t1.ShowStyle();
//        t1.ShowDim();
//        t1.ShowColor();
//        Console.WriteLine("Area is " + t1.Area());

//        Console.WriteLine();

//        Console.WriteLine("Info for t2: ");
//        t2.ShowStyle();
//        t2.ShowDim();
//        t2.ShowColor();
//        Console.WriteLine("Area is " + t2.Area());
//    }
// }

// The output of this program is shown here:

// Info for t1:
// Triangle is right
// Width and height are 8 and 12
// Color is Blue
// Area is 48

// Info for t2:
// Triangle is isosceles
// Width and height are 2 and 2
// Color is Red
// Area is 2

// Because of inheritance, ColorTriangle can make use of the previously defined classes of
// Triangle and TwoDShape, adding only the extra information it needs for its own, specific
// application.This is part of the value of inheritance; it allows the reuse of code.

// This example illustrates one other important point: base always refers to the constructor
// in the closest base class. The base in ColorTriangle calls the constructor in Triangle. The
// base in Triangle calls the constructor in TwoDShape. In a class hierarchy, if a base class
// constructor requires parameters, then all derived classes must pass those parameters “up
// the line.” This is true whether or not a derived class needs parameters of its own.

#endregion