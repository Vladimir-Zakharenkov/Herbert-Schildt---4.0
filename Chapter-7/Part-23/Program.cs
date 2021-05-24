#region Russian

// Постоянство строк

// Как ни странно, содержимое объекта типа string не подлежит изменению. Это
// означает, что однажды созданную последовательность символов изменить нельзя. Но
// данное ограничение способствует более эффективной реализации символьных строк.
// Поэтому этот, на первый взгляд, очевидный недостаток на самом деле превращается в
// преимущество. Так, если требуется строка в качестве разновидности уже имеющейся
// строки, то для этой цели следует создать новую строку, содержащую все необходимые
// изменения. А поскольку неиспользуемые строковые объекты автоматически собираются
// в "мусор", то о дальнейшей судьбе ненужных строк можно даже не беспокоиться.

// Следует, однако, подчеркнуть, что переменные ссылки на строки (т.е. объекты типа
// string) подлежат изменению, а следовательно, они могут ссылаться на другой объект.
// Но содержимое самого объекта типа string не меняется после его создания.

// Для того чтобы стало понятнее, почему неизменяемые строки не являются помехой,
// воспользуемся еще одним методом обращения со строками: Substring().Этот метод
// возвращает новую строку, содержащую часть вызывающей строки. В итоге создается
// новый строковый объект, содержащий выбранную подстроку, тогда как исходная
// строка не меняется, а следовательно, соблюдается принцип постоянства строк. Ниже
// приведена рассматриваемая здесь форма метода Substring():

// string Substring(int индекс_начала, int длина)

// где индекс_начала обозначает начальный индекс исходной строки, а длина — длину
// выбираемой подстроки.

// Ниже приведена программа, в которой принцип постоянства строк демонстрируется
// на примере использования метода Substring().

//Применить метод Substring().
using System;

class SubStr
{
    static void Main()
    {
        string orgstr = "В C# упрощается обращение со строками.";

        //сформировать подстроку
        string substr = orgstr.Substring(5, 20);

        Console.WriteLine("orgstr: " + orgstr);
        Console.WriteLine("sustr: " + substr);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этой программы.

// orgstr: В C# упрощается обращение со строками.
// substr: упрощается обращение

// Как видите, исходная строка из переменной orgstr не меняется, а выбранная из
// нее подстрока содержится в переменной substr.

// И последнее замечание: несмотря на то, что постоянство строк обычно не является
// ни ограничением, ни помехой для программирования на С#, иногда оказывается
// полезно иметь возможность видоизменять строки. Для этой цели в C# имеется класс
// StringBuilder, который определен в пространстве имен System.Text. Этот класс
// позволяет создавать строковые объекты, которые можно изменять. Но, как правило,
// в программировании на C# используется тип string, а не класс StringBuilder.

#endregion

#region English

// Strings Are Immutable

// Here is something that might surprise you: The contents of a string object are immutable.
// That is, once created, the character sequence comprising that string cannot be altered. This
// restriction allows strings to be implemented more efficiently. Even though this probably
// sounds like a serious drawback, it isn’t. When you need a string that is a variation on one
// that already exists, simply create a new string that contains the desired changes. Because
// unused string objects are automatically garbage-collected, you don’t even need to worry
// about what happens to the discarded strings.

// It must be made clear, however, that string reference variables may, of course, change
// which object they refer to. It is just that the contents of a specific string object cannot be
// changed after it is created.

// To fully understand why immutable strings are not a hindrance, we will use another of
// string’s methods: Substring().The Substring() method returns a new string that contains
// a specified portion of the invoking string. Because a new string object is manufactured that
// contains the substring, the original string is unaltered, and the rule of immutability is still
// intact. The form of Substring( ) that we will be using is shown here:

// string Substring(int startIndex, int length)

// Here, startIndex specifies the beginning index, and length specifies the length of the substring.
// Here is a program that demonstrates Substring( ) and the principle of immutable
// strings:

//Use Substring(). 
// using System; 

// class SubStr
// {
//    static void Main()
//    {
//        string orgstr = "C# makes strings easy.";

//        // construct a substring 
//        string substr = orgstr.Substring(5, 12);

//        Console.WriteLine("orgstr: " + orgstr);
//        Console.WriteLine("substr: " + substr);
//    }
// }

// Here is the output from the program:

// orgstr: C# makes strings easy.
// substr: kes strings

// As you can see, the original string orgstr is unchanged, and substr contains the substring.

// One more point: Although the immutability of string objects is not usually a restriction
// or hindrance, there may be times when it would be beneficial to be able to modify a string.
// To allow this, C# offers a class called StringBuilder, which is in the System.Text namespace.
// It creates string objects that can be changed. For most purposes, however, you will want to
// use string, not StringBuilder.

#endregion