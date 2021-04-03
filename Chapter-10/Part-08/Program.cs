#region Russian

// Автоматически реализуемые свойства

// Начиная с версии C# 3.0, появилась возможность для реализации очень простых
// свойств, не прибегая к явному определению переменной, которой управляет свойство.
// Вместо этого базовую переменную для свойства автоматически предоставляет компилятор.
// Такое свойство называется автоматически реализуемым и принимает следующую
// общую форму:

// тип имя { get; set; }

// где тип обозначает конкретный тип свойства, а имя — присваиваемое свойству имя.
// Обратите внимание на то, что после обозначений аксессоров get и set сразу же следует
// точка с запятой, а тело у них отсутствует. Такой синтаксис предписывает компилятору
// создать автоматически переменную, иногда еще называемую поддерживающим полем,
// для хранения значения. Такая переменная недоступна непосредственно и не имеет
// имени. Но в то же время она может быть доступна через свойство.

// Ниже приведен пример объявления свойства, автоматически реализуемого под именем UserCount. 
// public int UserCount { get; set; }

// Как видите, в этой строке кода переменная явно не объявляется. И как пояснялось
// выше, компилятор автоматически создает анонимное поле, в котором хранится значение.
// А в остальном автоматически реализуемое свойство UserCount подобно всем
// остальным свойствам.

// Но в отличие от обычных свойств автоматически реализуемое свойство не может
// быть доступным только для чтения или только для записи. При объявлении этого свойства
// в любом случае необходимо указывать оба аксессора — get и set. Хотя добиться
// желаемого (т.е. сделать автоматически реализуемое свойство доступным только для
// чтения или только для записи) все же можно, объявив ненужный аксессор как private
// (подробнее об этом — в разделе "Применение модификаторов доступа в аксессорах").

// Несмотря на очевидные удобства автоматически реализуемых свойств, их применение
// ограничивается в основном теми ситуациями, в которых не требуется управление
// установкой или получением значений из поддерживающих полей. Напомним, что
// поддерживающее поле недоступно напрямую. Это означает, что на значение, которое
// может иметь автоматически реализуемое свойство, нельзя наложить никаких ограничений.
// Следовательно, имена автоматически реализуемых свойств просто заменяют
// собой имена самих полей, а зачастую именно это и требуется в программе. Автоматически
// реализуемые свойства могут оказаться полезными и в тех случаях, когда с помощью
// свойств функциональные возможности программы открываются для сторонних
// пользователей, и для этой цели могут даже применяться специальные средства проектирования.

// Применение инициализаторов объектов в свойствах

// Как пояснялось в главе 8, инициализатор объекта применяется в качестве альтернативы
// явному вызову конструктора при создании объекта. С помощью инициализаторов
// объектов задаются начальные значения полей или свойств, которые требуется инициализировать.
// При этом синтаксис инициализаторов объектов оказывается одинаковым
// как для свойств, так и для полей. В качестве примера ниже приведена программа
// из главы 8, измененная с целью продемонстрировать применение инициализаторов
// объектов в свойствах. Напомним, что в версии этой программы из главы 8 использовались
// поля, а приведенная ниже версия отличается лишь тем, что в ней поля Count
// и Str превращены в свойства. В то же время синтаксис инициализаторов объектов не
// изменился.

//Применить инициализаторы объектов в свойствах.
using System;

class MyClass
{
    //Теперь это свойства.
    public int Count { get; set; }
    public string Str { get; set; }
}

class ObjInitDemo
{
    static void Main()
    {
        //Сконструировать объект типа MyClass  с помощью инициализаторов объектов.
        MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };

        Console.WriteLine(obj.Count + " " + obj.Str);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Как видите, свойства Count и Str устанавливаются в выражениях с инициализатором
// объекта. Приведенная выше программа дает такой же результат, как и программа
// из главы 8, а именно:

// 100 Тестирование

// Как пояснялось в главе 8, синтаксис инициализатора объекта оказывается наиболее
// пригодным для работы с анонимными типами, формируемыми в LINQ-выражениях.
// А в остальных случаях чаще всего используется синтаксис обычных конструкторов.

// Ограничения, присущие свойствам

// Свойствам присущ ряд существенных ограничений. Во-первых, свойство не определяет
// место для хранения данных, и поэтому не может быть передано методу в качестве
// параметра ref или out. Во-вторых, свойство не подлежит перегрузке. Наличие двух
// разных свойств с доступом к одной и той же переменной допускается, но это, скорее,
// исключение, чем правило. И наконец, свойство не должно изменять состояние базовой
// переменной при вызове аксессора get. И хотя это ограничительное правило не
// соблюдается компилятором, его нарушение считается семантической ошибкой. Действие
// аксессора get не должно носить характер вмешательства в функционирование
// переменной.

#endregion

#region English

// Auto - Implemented Properties

// Beginning with C# 3.0, it became possible to implement very simple properties without
// having to explicitly define the variable managed by the property. Instead, you can let the
// compiler automatically supply the underlying variable. This is called an auto-implemented
// property. It has the following general form:

// type name { get; set; }

// Here, type specifies the type of the property and name specifies the name. Notice that get
// and set are immediately followed by a semicolon. The accessors for an auto-implemented
// property have no bodies. This syntax tells the compiler to automatically create a storage
// location (sometimes referred to as a backing field) that holds the value. This variable is not
// named and is not directly available to you. Instead, it can be accessed only through the
// property.

// Here is how a property called UserCount is declared using an auto-implemented
// property:

// public int UserCount { get; set; }

// Notice that no variable is explicitly declared. As explained, the compiler automatically
// generates an anonymous field that holds the value. Otherwise, UserCount acts like and is
// used like any other property.

// Unlike normal properties, an auto-implemented property cannot be read-only or writeonly.
// Both the get and set must be specified in all cases. However, you can approximate the
// same effect by declaring either get or set as private, as explained in “Use Access Modifiers
// with Accessors” later in this chapter.

// Although auto-implemented properties offer convenience, their use is limited to those
// cases in which you do not need control over the getting or setting of the backing field.
// Remember, you cannot access the backing field directly. This means that there is no way
// to constrain the value an auto-implemented property can have. Thus, auto-implemented
// properties simply let the name of the property act as a proxy for the field, itself. However,
// sometimes this is exactly what you want. Also, they can be very useful in cases in which
// properties are used to expose functionality to a third party, possibly through a design tool.

// Use Object Initializers with Properties

// As discussed in Chapter 8, an object initializer provides an alternative to explicitly calling a
// constructor when creating an object. When using object initializers, you specify initial values
// for the fields and/or properties that you want to initialize. Furthermore, the object initializer
// syntax is the same for both properties or fields. For example, here is the object initializer
// demonstration program from Chapter 8, reworked to show the use of object initializers with
// properties. Recall that the version shown in Chapter 8 used fields. The only difference
// between this version of the program and the one shown in Chapter 8 is that Count and
// Str have been converted from fields into properties. The object initializer syntax is
// unchanged.

// Use object initializers with properties. 

// using System;  

// class MyClass
// {
//    // These are now properties.  
//    public int Count { get; set; }
//    public string Str { get; set; }
// }

// class ObjInitDemo
// {
//    static void Main()
//    {
//        // Construct a MyClass object by using object initializers. 
//        MyClass obj = new MyClass { Count = 100, Str = "Testing" };

//        Console.WriteLine(obj.Count + " " + obj.Str);
//    }
// }

// As you can see, the properties Count and Str are set via object initializer expressions. The
// output is the same as that produced by the program in Chapter 8 and is shown here:

// 100 Testing

// As explained in Chapter 8, the object initializer syntax is most useful when working
// with anonymous types generated by a LINQ expression. In most other cases, you will use
// the normal constructor syntax.

// Property Restrictions

// Properties have some important restrictions. First, because a property does not define a storage
// location, it cannot be passed as a ref or out parameter to a method. Second, you cannot
// overload a property. (You can have two different properties that both access the same variable,
// but this would be unusual.) Finally, a property should not alter the state of the underlying
// variable when the get accessor is called. Although this rule is not enforced by the compiler,
// violating it is semantically wrong. A get operation should be nonintrusive.

#endregion