#region Russian

// Ссылки на базовый класс и объекты производных классов

// Как вам должно быть уже известно, C# является строго типизированным языком
// программирования. Помимо стандартных преобразований и автоматического продвижения
// простых типов значений, в этом языке строго соблюдается принцип совместимости
// типов. Это означает, что переменная ссылки на объект класса одного типа,
// как правило, не может ссылаться на объект класса другого типа. В качестве примера
// рассмотрим следующую программу, в которой объявляются два класса одинаковой
// структуры.

//Эта программа не подлежит компиляции.

class X
{
    int a;

    public X(int i)
    {
        a = i;
    }
}

class Y
{
    int a;

    public Y(int i)
    {
        a = i;
    }
}

class IncompatibleRef
{
    static void Main()
    {
        X x = new X(10);
        X x2;

        Y y = new Y(5);

        x2 = x; //верно, поскольку оба объекта относятся к одному и тому же типу

        x2 = y; //ошибка, поскольку это разнотипные объекты 
    }
}

// Несмотря на то что классы X и Y в данном примере совершенно одинаковы по своей
// структуре, ссылку на объект типа Y нельзя присвоить переменной ссылки на объект
// типа X, поскольку типы у них разные. Поэтому следующая строка кода оказывается
// неверной и может привести к ошибке из-за несовместимости типов во время компиляции.

// х2 = у; // неверно, поскольку это разнотипные объекты

#endregion

#region English

// Base Class References and Derived Objects

// As you know, C# is a strongly typed language. Aside from the standard conversions and
// automatic promotions that apply to its value types, type compatibility is strictly enforced.
// Therefore, a reference variable for one class type cannot normally refer to an object of
// another class type. For example, consider the following program that declares two classes
// that are identical in their composition:

// This program will not compile. 

// class X
// {
//    int a;

//    public X(int i) { a = i; }
// }

// class Y
// {
//    int a;

//    public Y(int i) { a = i; }
// 

// class IncompatibleRef
// {
//    static void Main()
//    {
//        X x = new X(10);
//        X x2;
//        Y y = new Y(5);

//        x2 = x; // OK, both of same type 

//        x2 = y; // Error, not of same type 
//    }
// }

// Here, even though class X and class Y are physically the same, it is not possible to assign a
// reference of type Y to a variable of type X because they have different types. Therefore, this
// line is incorrect because it causes a compile-time type mismatch:

// x2 = y; // Error, not of same type

#endregion