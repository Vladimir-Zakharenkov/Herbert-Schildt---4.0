#region Russian

// Наследование и сокрытие имен

// В производном классе можно определить член с таким же именем, как и у члена
// его базового класса. В этом случае член базового класса скрывается в производном
// классе. И хотя формально в C# это не считается ошибкой, компилятор все же выдаст
// сообщение, предупреждающее о том, что имя скрывается. Если член базового класса
// требуется скрыть намеренно, то перед его именем следует указать ключевое слово
// new, чтобы избежать появления подобного предупреждающего сообщения. Следует,
// однако, иметь в виду, что это совершенно отдельное применение ключевого слова new,
// не похожее на его применение при создании экземпляра объекта.

// Ниже приведен пример сокрытия имени.

//Пример сокрытия имени с наследственной связью.
using System;

class A
{
    public int i = 0;
}

//Создать производный класс.
class B : A
{
    new int i; //этот член скрывает член i из класса A.

    public B(int b)
    {
        i = b; //член i в классе B
    }

    public void Show()
    {
        Console.WriteLine("Член i в производном классе: " + i);
    }
}

class NameHiding
{
    static void Main()
    {
        B ob = new B(2);

        ob.Show();

        //Задержка программы.
        Console.ReadKey();

    }
}

// Прежде всего обратите внимание на использование ключевого слова new в следующей
// строке кода.

// new int i; // этот член скрывает член i из класса А

// В этой строке компилятору, по существу, сообщается о том, что вновь создаваемая
// переменная i намеренно скрывает переменную i из базового класса А и что автору
// программы об этом известно. Если же опустить ключевое слово new в этой строке
// кода, то компилятор выдаст предупреждающее сообщение.

// Вот к какому результату приводит выполнение приведенного выше кода.

// Член i в производном классе: 2

// В классе В определяется собственная переменная экземпляра i, которая скрывает
// переменную i из базового класса А. Поэтому при вызове метода Show() для объекта
// типа В выводится значение переменной i, определенной в классе В, а не той, что
// определена в классе А.

#endregion


#region English

// Inheritance and Name Hiding

// It is possible for a derived class to define a member that has the same name as a member in
// its base class. When this happens, the member in the base class is hidden within the derived
// class. While this is not technically an error in C#, the compiler will issue a warning message.
// This warning alerts you to the fact that a name is being hidden. If your intent is to hide a
// base class member, then to prevent this warning, the derived class member must be preceded
// by the new keyword.Understand that this use of new is separate and distinct from its use
// when creating an object instance.

// // An example of inheritance-related name hiding. 

// using System; 

// class A
// {
//    public int i = 0;
// }

// // Create a derived class. 
// class B : A
// {
//    new int i; // this i hides the i in A 

//    public B(int b)
//    {
//        i = b; // i in B 
//    }

//    public void Show()
//    {
//        Console.WriteLine("i in derived class: " + i);
//    }
// }

// class NameHiding
// {
//    static void Main()
//    {
//        B ob = new B(2);

//        ob.Show();
//    }
// }

// First, notice the use of new in this line.

// new int i; // this i hides the i in A

// In essence, it tells the compiler that you know a new variable called i is being created that
// hides the i in the base class A. If you leave new out, a warning is generated.
// he output produced by this program is shown here:

// i in derived class: 2

// Since B defines its own instance variable called i, it hides the i in A.Therefore, when Show( )
// is invoked on an object of type B, the value of i as defined by B is displayed—not the one
// defined in A.

#endregion