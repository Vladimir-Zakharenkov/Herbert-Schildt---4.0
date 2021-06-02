#region Russian
/*
 Общая форма обобщенного класса

Синтаксис обобщений, представленных в предыдущих примерах, может быть сведен
к общей форме. Ниже приведена общая форма объявления обобщенного класса.

class имя_класса<список_параметров_типа> { // ...

А вот как выглядит синтаксис объявления ссылки на обобщенный класс.

имя_класса<список_аргументов_типа> имя_переменной = new имя_класса<список_параметров_типа> (список_аргументов_конструктора);

Ограниченные типы

В предыдущих примерах параметры типа можно было заменить любым типом данных.
Например, в следующей строке кода объявляется любой тип, обозначаемый как Т.

class Gen<T> {

Это означает, что вполне допустимо создавать объекты класса Gen, в которых тип Т
заменяется типом int, double, string, FileStream или любым другим типом данных.
Во многих случаях отсутствие ограничений на указание аргументов типа считается
вполне приемлемым, но иногда оказывается полезно ограничить круг типов, которые
могут быть указаны в качестве аргумента типа.

Допустим, что требуется создать метод, оперирующий содержимым потока, включая
объекты типа FileStream или MemoryStream. На первый взгляд, такая ситуация
идеально подходит для применения обобщений, но при этом нужно каким-то образом
гарантировать, что в качестве аргументов типа будут использованы только типы
потоков, но не int или любой другой тип. Кроме того, необходимо как-то уведомить
компилятор о том, что методы, определяемые в классе потока, будут доступны для
применения. Так, в обобщенном коде должно быть каким-то образом известно, что
в нем может быть вызван метод Read().

Для выхода из подобных ситуаций в C# предусмотрены ограниченные типы. Указывая
параметр типа, можно наложить определенное ограничение на этот параметр. Это
делается с помощью оператора where при указании параметра типа:

class имя_класса<параметр_типа> where параметр_типа : ограничения { // ...

где ограничения указываются списком через запятую.

В C# предусмотрен ряд ограничений на типы данных.

• Ограничение на базовый класс, требующее наличия определенного базового класса
в аргументе типа. Это ограничение накладывается указанием имени требуемого
базового класса. Разновидностью этого ограничения является неприкрытое
ограничение типа, при котором на базовый класс указывает параметр типа, а не
конкретный тип. Благодаря этому устанавливается взаимосвязь между двумя
параметрами типа.

• Ограничение на интерфейс, требующее реализации одного или нескольких интерфейсов
аргументом типа. Это ограничение накладывается указанием имени требуемого интерфейса.

• Ограничение на конструктор, требующее предоставить конструктор без параметров
в аргументе типа. Это ограничение накладывается с помощью оператора new().

• Ограничение ссылочного типа, требующее указывать аргумент ссылочного типа с
помощью оператора class.

• Ограничение типа значения, требующее указывать аргумент типа значения с помощью
оператора struct.

Среди всех этих ограничений чаще всего применяются ограничения на базовый
класс и интерфейс, хотя все они важны в равной степени. Каждое из этих ограничений
рассматривается далее по порядку.

Применение ограничения на базовый класс

Ограничение на базовый класс позволяет указывать базовый класс, который должен
наследоваться аргументом типа. Ограничение на базовый класс служит двум главным
целям. Во-первых, оно позволяет использовать в обобщенном классе те члены базового
класса, на которые указывает данное ограничение. Это дает, например, возможность
вызвать метод или обратиться к свойству базового класса. В отсутствие ограничения на
базовый класс компилятору ничего не известно о типе членов, которые может иметь
аргумент типа. Накладывая ограничение на базовый класс, вы тем самым даете компилятору
знать, что все аргументы типа будут иметь члены, определенные в этом базовом классе.

И во-вторых, ограничение на базовый класс гарантирует использование только
тех аргументов типа, которые поддерживают указанный базовый класс. Это означает,
что для любого ограничения, накладываемого на базовый класс, аргумент типа
должен обозначать сам базовый класс или производный от него класс. Если же попытаться
использовать аргумент типа, не соответствующий указанному базовому
классу или не наследующий его, то в результате возникнет ошибка во время компиляции.

Ниже приведена общая форма наложения ограничения на базовый класс, в которой
используется оператор where:

where Т : имя_базового_класса

где T обозначает имя параметра типа, а имя_базового_класса — конкретное имя
ограничиваемого базового класса. Одновременно в этой форме ограничения может
быть указан только один базовый класс.

В приведенном ниже простом примере демонстрируется механизм наложения
ограничения на базовый класс.
*/

// Простой пример, демонстрирующий механизм наложения ограничения на базовый класс.
using System;

class A
{
    public void Hello()
    {
        System.Console.WriteLine("Hello");
    }
}

//Класс B наследует класс A.
class B : A
{

}

//Класс C не наследует класс A.
class C
{

}

//В силу ограничения на базовый класс во всех аргументах типа,
//передаваемых классу Test, должен присутствовать базовый класс A.
class Test<T> where T : A
{
    T obj;

    public Test(T obj)
    {
        this.obj = obj;
    }

    public void SayHello()
    {
        //Метод Hello() вызывается, поскольку он объевлен в базовом классе A.
        obj.Hello();
    }
}

class BaseClassConstrainDemo
{
    static void Main()
    {
        A a = new A();
        B b = new B();
        C c = new C();

        //Следующий код вполне допустим, поскольку класс A указан как базовый.
        Test<A> t1 = new Test<A>(a);

        t1.SayHello();

        //Следующий код вполне допустим, поскольку класс B наследует от класса A.
        Test<B> t2 = new Test<B>(b);

        t2.SayHello();

        //Следующий код недопустим, поскольку класс C не наследует от класса A.
        // Test<C> t3 = new Test<C>(c);
        // t3.SayHello(); //Ошибка!

        //Задержка программы.
        Console.ReadKey();
    }
}

/*
 В данном примере кода класс А наследуется классом В, но не наследуется классом
С. Обратите также внимание на то, что в классе А объявляется метод Hello(), а класс
Test объявляется как обобщенный следующим образом.

class Test<T> where Т : А {

Оператор where в этом объявлении накладывает следующее ограничение: любой
аргумент, указываемый для типа Т, должен иметь класс А в качестве базового.

А теперь обратите внимание на то, что в классе Test объявляется метод
SayHello(), как показано ниже.

public void SayHello() {
// Метод Hello() вызывается, поскольку он объявлен в базовом классе А.
obj.Hello();
}

Этот метод вызывает в свою очередь метод Hello() для объекта obj типа Т. Любопытно,
что единственным основанием для вызова метода Hello() служит следующее
требование ограничения на базовый класс: любой аргумент типа, привязанный к типу
Т, должен относиться к классу А или наследовать от класса А, в котором объявлен метод
Hello(). Следовательно, любой допустимый тип Т будет также определять метод
Hello(). Если бы данное ограничение на базовый класс не было наложено, то компилятору
ничего не было бы известно о том, что метод Hello() может быть вызван для
объекта типа Т. Убедитесь в этом сами, удалив оператор where из объявления обобщенного
класса Test. В этом случае программа не подлежит компиляции, поскольку
теперь метод Hello() неизвестен.

Помимо разрешения доступа к членам базового класса, ограничение на базовый
класс гарантирует, что в качестве аргументов типа могут быть переданы только те типы
данных, которые наследуют базовый класс. Именно поэтому приведенные ниже строки
кода закомментированы.

// Test<C> t3 = new Test<C>(c); // Ошибка!
// t3.SayHello(); // Ошибка!

Класс С не наследует от класса А, и поэтому он не может использоваться в качестве
аргумента типа при создании объекта типа Test. Убедитесь в этом сами, удалив символы
комментария и попытавшись перекомпилировать этот код.

Прежде чем продолжить изложение дальше, рассмотрим вкратце два последствия
наложения ограничения на базовый класс. Во-первых, это ограничение разрешает доступ
к членам базового класса из обобщенного класса. И во-вторых, оно гарантирует
допустимость только тех аргументов типа, которые удовлетворяют данному ограничению,
обеспечивая тем самым типовую безопасность.
 */
#endregion

#region English
/*
 Using a Base Class Constraint

The base class constraint enables you to specify a base class that a type argument must
inherit. A base class constraint serves two important purposes. First, it lets you use the
members of the base class specified by the constraint within the generic class. For example,
you can call a method or use a property of the base class. Without a base class constraint,
the compiler has no way to know what type of members a type argument might have. By
supplying a base class constraint, you are letting the compiler know that all type arguments
will have the members defined by that base class.

The second purpose of a base class constraint is to ensure that only type arguments that
support the specified base class are used. This means that for any given base class constraint,
the type argument must be either the base class, itself, or a class derived from that base class.
If you attempt to use a type argument that does not match or inherit the specified base class,
a compile-time error will result.

The base class constraint uses this form of the where clause:

where T : base-class-name

Here, T is the name of the type parameter, and base-class-name is the name of the base class.
Only one base class can be specified.

Here is a simple example that demonstrates the base class constraint mechanism:
 */

// A simple demonstration of a base class constraint. 

// using System; 

// class A
// {
//    public void Hello()
//    {
//        Console.WriteLine("Hello");
//    }
// }

//// Class B inherits A. 
// class B : A { }

//// Class C does not inherit A. 
// class C { }

//// Because of the base class constraint, all type arguments 
//// passed to Test must have A as a base class. 
// class Test<T> where T : A
// {
//    T obj;

//    public Test(T o)
//    {
//        obj = o;
//    }

//    public void SayHello()
//    {
//        // OK to call Hello() because it's declared 
//        // by the base class A. 
//        obj.Hello();
//    }
// }

// class BaseClassConstraintDemo
// {
//    static void Main()
//    {
//        A a = new A();
//        B b = new B();
//        C c = new C();

//        // The following is valid because A is the specified base class. 
//        Test<A> t1 = new Test<A>(a);

//        t1.SayHello();

//        // The following is valid because B inherits A. 
//        Test<B> t2 = new Test<B>(b);

//        t2.SayHello();


//        // The following is invalid because C does not inherit A. 
//        //    Test<C> t3 = new Test<C>(c); // Error! 
//        //    t3.SayHello(); // Error! sayHello is not known. 
//    }
// }

/*
 In this program, class A is inherited by B, but not by C. Notice also that A declares a
method called Hello( ). Next, notice that Test is a generic class that is declared like this:

class Test<T> where T : A {

The where clause stipulates that any type argument specified for T must have A as a base
class.

Now notice that Test declares the method SayHello( ), shown next:

public void SayHello() {
// OK to call Hello() because it’s declared
// by the base class A.
obj.Hello();
}

This method calls Hello( ) on obj, which is a T object. The key point is that the only reason
that Hello( ) can be called is because the base class constraint requires that any type argument
bound to T must be A or inherit A, and A declares Hello( ). Thus, any valid T will define
Hello( ). If the base class constraint had not been used, the compiler would have no way of
knowing that a method called Hello( ) could be called on an object of type T. You can prove
this for yourself by removing the where clause. The program will no longer compile because
the Hello( ) method will be unknown.

In addition to enabling access to members of the base class, the base class constraint
enforces that only types that inherit the base class can be passed as type arguments. This
is why the following two lines are commented-out:

// Test<C> t3 = new Test<C>(c); // Error!
// t3.SayHello(); // Error!

Because C does not inherit A, it can’t be used as a type argument when constructing a Test
object. You can prove this by removing the comment symbols and trying to recompile.

Before continuing, let’s review the two effects of a base class constraint: A base class
constraint enables a generic class to access the members of the base class. It also ensures that
only those type arguments that fulfill this constraint are valid, thus preserving type safety.
 */

#endregion