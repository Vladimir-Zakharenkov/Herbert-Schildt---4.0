#region Russian

// Свойства

// Еще одной разновидностью члена класса является свойство. Как правило, свойство
// сочетает в себе поле с методами доступа к нему. Как было показано в приведенных
// ранее примерах программ, поле зачастую создается, чтобы стать доступным для пользователей
// объекта, но при этом желательно сохранить управление над операциями,
// разрешенными для этого поля, например, ограничить диапазон значений, присваиваемых
// данному полю. Этой цели можно, конечно, добиться и с помощью закрытой
// переменной, а также методов доступа к ее значению, но свойство предоставляет более
// совершенный и рациональный путь для достижения той же самой цели.

// Свойства очень похожи на индексаторы. В частности, свойство состоит из имени и
// аксессоров get и set. Аксессоры служат для получения и установки значения переменной.
// Главное преимущество свойства заключается в том, что его имя может быть
// использовано в выражениях и операторах присваивания аналогично имени обычной
// переменной, но в действительности при обращении к свойству по имени автоматически
// вызываются его аксессоры get и set. Аналогичным образом используются аксессоры
// get и set индексатора.

// Ниже приведена общая форма свойства:

// тип имя
// {
//    get
//    {
//        // код аксессора для чтения из поля
//    }
//    set
//    {
//        // код аксессора для записи в поле
//    }

// где тип обозначает конкретный тип свойства, например int, а имя — присваиваемое
// свойству имя. Как только свойство будет определено, любое обращение к свойству по
// имени приведет к автоматическому вызову соответствующего аксессора. Кроме того,
// аксессор set принимает неявный параметр value, который содержит значение, присваиваемое
// свойству.

// Следует, однако, иметь в виду, что свойства не определяют место в памяти для хранения
// полей, а лишь управляют доступом к полям. Это означает, что само свойство не
// предоставляет поле, и поэтому поле должно быть определено независимо от свойства.
// (Исключение из этого правила составляет автоматически реализуемое свойство, рассматриваемое
// далее.)

// Ниже приведен простой пример программы, в которой определяется свойство
// MyProp, предназначенное для доступа к полю prop. В данном примере свойство допускает
// присваивание только положительных значений.

//Простой пример применения свойства.
using System;

class SimpProp
{
    int prop; //поле, управляемое свойством MyProp

    public SimpProp()
    {
        prop = 0;
    }

    //Это свойство обеспечивает доступ к закрытой переменной экземпляра prop.
    //Оно допускает присваивание только положительных значений.
    public int MyProp
    {
        get
        {
            return prop;
        }

        set
        {
            if (value >= 0)
            {
                prop = value;
            }
        }
    }
}

//Продемонстрировать применение свойства.
class PropertyDemo
{
    static void Main()
    {
        SimpProp ob = new SimpProp();

        Console.WriteLine("Первоначальное значение ob.MyProp: " + ob.MyProp);

        ob.MyProp = 100; //присвоить значение
        Console.WriteLine("Текущее значение ob.MyProp: " + ob.MyProp);

        //Переменной prop нельзя присвоить отрицательное значение.
        Console.WriteLine("Попытка присвоить значение -10 свойству ob.MyProp");
        ob.MyProp = -10;
        Console.WriteLine("Текущее значение ob.MyProp: " + ob.MyProp);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этого кода.

// Первоначальное значение ob.МуРrор: 0
// Текущее значение ob.МуРrор: 100
// Попытка присвоить значение -10 свойству ob.МуРrор
// Текущее значение ob.МуРrор: 100

// Рассмотрим приведенный выше код более подробно. В этом коде определяется
// одно закрытое поле prop и свойство MyProp, управляющее доступом к полю prop.
// Как пояснялось выше, само свойство не определяет место в памяти для хранения поля,
// а только управляет доступом к полю. Кроме того, поле prop является закрытым, а значит,
// оно доступно только через свойство MyProp.

// Свойство MyProp указано как public, а следовательно, оно доступно из кода за
// пределами его класса. И в этом есть своя логика, поскольку данное свойство обеспечивает
// доступ к полю prop, которое является закрытым. Аксессор get этого свойства
// просто возвращает значение из поля prop, тогда как аксессор set устанавливает значение
// в поле prop в том и только в том случае, если это значение оказывается положительным.
// Таким образом, свойство MyProp контролирует значения, которые могут
// храниться в поле prop. В этом, собственно, и состоит основное назначение свойств.

// Тип свойства MyProp определяется как для чтения, так и для записи, поскольку оно
// позволяет читать и записывать данные в базовое поле. Тем не менее свойства можно
// создавать доступными только для чтения или только для записи. Так, если требуется
// создать свойство, доступное только для чтения, то достаточно определить единственный
// аксессор get. А если нужно создать свойство, доступное только для записи, то
// достаточно определить единственный аксессор set.

#endregion

#region English

// Properties

// Another type of class member is the property. As a general rule, a property combines a field
// with the methods that access it. As some examples earlier in this book have shown, you will
// often want to create a field that is available to users of an object, but you want to maintain
// control over the operations allowed on that field. For instance, you might want to limit the
// range of values that can be assigned to that field. While it is possible to accomplish this goal
// through the use of a private variable along with methods to access its value, a property
// offers a better, more streamlined approach.

// Properties are similar to indexers. A property consists of a name along with get and set
// accessors. The accessors are used to get and set the value of a variable. The key benefit of a
// property is that its name can be used in expressions and assignments like a normal variable,
// but in actuality the get and set accessors are automatically invoked. This is similar to the
// way that an indexer’s get and set accessors are automatically used.
//T he general form of a property is shown here:

// type name
// {
//    get
//    {
//        // get accessor code
//    }
//    set
//    {
//        // set accessor code
//    }
// }

// Here, type specifies the type of the property, such as int, and name is the name of the property.
// Once the property has been defined, any use of name results in a call to its appropriate
// accessor. The set accessor automatically receives a parameter called value that contains the
// value being assigned to the property.

// It is important to understand that properties do not define storage locations. Instead, a
// property typically manages access to a field. It does not, itself, provide that field. The field
// must be specified independently of the property. (The exception is the auto-implemented
// property, which is described shortly.)

// Here is a simple example that defines a property called MyProp, which is used to access
// the field prop. In this case, the property allows only positive values to be assigned.

// A simple property example. 

// using System; 

// class SimpProp
// {
//    int prop; // field being managed by MyProp 

//    public SimpProp() { prop = 0; }

//    /* This is the property that supports access to 
//       the private instance variable prop.  It 
//       allows only positive values. */
//    public int MyProp
//    {
//        get
//        {
//            return prop;
//        }
//        set
//        {
//            if (value >= 0) prop = value;
//        }
//    }
// }

// // Demonstrate a property. 
// class PropertyDemo
// {
//    static void Main()
//    {
//        SimpProp ob = new SimpProp();

//        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

//        ob.MyProp = 100; // assign value 
//        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);

//        // Can't assign negative value to prop. 
//        Console.WriteLine("Attempting to assign -10 to ob.MyProp");
//        ob.MyProp = -10;
//        Console.WriteLine("Value of ob.MyProp: " + ob.MyProp);
//    }
// }

// Output from this program is shown here:

// Original value of ob.MyProp: 0
// Value of ob.MyProp: 100
// Attempting to assign -10 to ob.MyProp
// Value of ob.MyProp: 100

// Let’s examine this program carefully. The program defines one private field, called
// prop, and a property called MyProp that manages access to prop. As explained, a property
// by itself does not define a storage location. Instead, most properties simply manage access
// to a field. Furthermore, because prop is private, it can be accessed only through MyProp.

// The property MyProp is specified as public so it can be accessed by code outside of its
// class. This makes sense because it provides access to prop, which is private. The get accessor
// simply returns the value of prop. The set accessor sets the value of prop if and only if that
// value is positive. Thus, the MyProp property controls what values prop can have. This is
// the essence of why properties are important.

// The type of property defined by MyProp is called a read-write property because it allows
// its underlying field to be read and written. It is possible, however, to create read-only and
// write-only properties. To create a read-only property, define only a get accessor. To define
// a write-only property, define only a set accessor.

#endregion