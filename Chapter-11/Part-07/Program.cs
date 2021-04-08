#region Russian

// С помощью ключевого слова base можно вызвать конструктор любой формы,
// определяемой в базовом классе, причем выполняться будет лишь тот конструктор, параметры
// которого соответствуют переданным аргументам. В качестве примера ниже
// приведены расширенные варианты классов TwoDShape и Triangle, в которые включены
// как используемые по умолчанию конструкторы, так и конструкторы, принимающие
// один аргумент.

//Добавить дополнительные конструкторы в класс TwoDShape.
using System;

//Класс для двумерных объектов.
class TwoDShape
{
    double pri_width;
    double pri_height;

    //Конструктор, вызываемый по умолчанию.
    public TwoDShape()
    {
        Width = Height = 0.0;
    }

    //Конструктор класса TwoDShape.
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

    public void ShowDim()
    {
        Console.WriteLine("Ширина и длина равны " + Width + " и " + Height);
    }

}

//Класс для треугольников, производный от класса TwoDShape.
class Triangle : TwoDShape
{
    string Style;

    //Конструктор, используемый по умолчанию.
    //Автоматически вызывает конструктор, доступный по умолчанию в классе TwoDShape.
    public Triangle()
    {
        Style = null;
    }

    //Конструктор, принимающий три аргумента.
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

class Shape5
{
    static void Main()
    {
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
        Triangle t3 = new Triangle(4.0);

        t1 = t2;

        Console.WriteLine("Сведения об объекте t1:");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Площадь равна " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t2:");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Площадь равна " + t2.Area());

        Console.WriteLine();

        Console.WriteLine("Сведения об объекте t3:");
        t3.ShowStyle();
        t3.ShowDim();
        Console.WriteLine("Площадь равна " + t3.Area());

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этого кода.

// Сведения об объекте t1:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Площадь равна 48

// Сведения об объекте t2:
// Треугольник прямоугольный
// Ширина и высота равны 8 и 12
// Площадь равна 48

// Сведения об объекте t3:
// Треугольник равнобедренный
// Ширина и высота равны 4 и 4
// Площадь равна 8

// А теперь рассмотрим вкратце основные принципы действия ключевого слова base.
// Когда в производном классе указывается ключевое слово base, вызывается конструктор
// из его непосредственного базового класса. Следовательно, ключевое слово base всегда
// обращается к базовому классу, стоящему в иерархии непосредственно над вызывающим
// классом. Это справедливо даже для многоуровневой иерархии классов. Аргументы
// передаются базовому конструктору в качестве аргументов метода base(). Если же
// ключевое слово отсутствует, то автоматически вызывается конструктор, используемый
// в базовом классе по умолчанию.

#endregion

#region English

// Any form of constructor defined by the base class can be called by base. The constructor
// executed will be the one that matches the arguments. For example, here are expanded
// versions of both TwoDShape and Triangle that include default constructors and constructors
// that take one argument.

// // Add more constructors to TwoDShape. 

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
//    string Style;

//    /* A default constructor. This automatically invokes 
//       the default constructor of TwoDShape. */
//    public Triangle()
//    {
//        Style = "null";
//    }

//    // Constructor that takes three arguments. 
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

// class Shapes5
// {
//    static void Main()
//    {
//        Triangle t1 = new Triangle();
//        Triangle t2 = new Triangle("right", 8.0, 12.0);
//        Triangle t3 = new Triangle(4.0);

//        t1 = t2;

//        Console.WriteLine("Info for t1: ");
//        t1.ShowStyle();
//        t1.ShowDim();
//        Console.WriteLine("Area is " + t1.Area());

//        Console.WriteLine();

//        Console.WriteLine("Info for t2: ");
//        t2.ShowStyle();
//        t2.ShowDim();
//        Console.WriteLine("Area is " + t2.Area());

//        Console.WriteLine();

//        Console.WriteLine("Info for t3: ");
//        t3.ShowStyle();
//        t3.ShowDim();
//        Console.WriteLine("Area is " + t3.Area());

//        Console.WriteLine();
//    }
// }

// Here is the output from this version:

// Info for t1:
// Triangle is right
// Width and height are 8 and 12
// Area is 48

// Info for t2:
// Triangle is right
// Width and height are 8 and 12
// Area is 48

// Info for t3:
// Triangle is isosceles
// Width and height are 4 and 4
// Area is 8

// Let’s review the key concepts behind base. When a derived class specifies a base
// clause, it is calling the constructor of its immediate base class. Thus, base always refers
// to the base class immediately above the calling class. This is true even in a multileveled
// hierarchy. You pass arguments to the base constructor by specifying them as arguments
// to base. If no base clause is present, then the base class’ default constructor is called
// automatically.

#endregion