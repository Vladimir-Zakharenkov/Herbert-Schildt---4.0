#region Russian

// Оператор цикла foreach

// Как упоминалось в главе 5, в языке C# определен оператор цикла foreach, но его рассмотрение
// было отложено до более подходящего момента. Теперь этот момент настал.

// Оператор foreach служит для циклического обращения к элементам коллекции,
// представляющей собой группу объектов. В C# определено несколько видов коллекций,
// каждая из которых является массивом. Ниже приведена общая форма оператора
// цикла foreach.

// foreach (тип имя_переменной_цикла in коллекция) оператор;

// Здесь тип имя_переменной_цикла обозначает тип и имя переменной управления
// циклом, которая получает значение следующего элемента коллекции на каждом
// шаге выполнения цикла foreach. А коллекция обозначает циклически опрашиваемую
// коллекцию, которая здесь и далее представляет собой массив. Следовательно, тип
// переменной цикла должен соответствовать типу элемента массива. Кроме того, тип
// может обозначаться ключевым словом var. В этом случае компилятор определяет тип
// переменной цикла, исходя из типа элемента массива. Это может оказаться полезным
// для работы с определенного рода запросами, как будет показано далее в данной книге.
// Но, как правило, тип указывается явным образом.

// Оператор цикла foreach действует следующим образом. Когда цикл начинается,
// первый элемент массива выбирается и присваивается переменной цикла. На каждом
// последующем шаге итерации выбирается следующий элемент массива, который сохраняется
// в переменной цикла. Цикл завершается, когда все элементы массива окажутся
// выбранными. Следовательно, оператор foreach циклически опрашивает массив по
// отдельным его элементам от начала и до конца.

// Следует, однако, иметь в виду, что переменная цикла в операторе foreach служит
// только для чтения. Это означает, что, присваивая этой переменной новое значение,
// нельзя изменить содержимое массива.

// Ниже приведен простой пример применения оператора цикла foreach. В этом
// примере сначала создается целочисленный массив и задается ряд его первоначальных
// значений, а затем эти значения выводятся, а по ходу дела вычисляется их сумма.

//Использовать оператор цикла foreach.
using System;

class ForeachDemo
{
    static void Main()
    {
        int sum = 0;
        int[] nums = new int[10];

        //Задать первоначальные значения элементов массива nums.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
        }

        //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы.
        foreach (int x in nums)
        {
            Console.WriteLine("Значение элемента равно: " + x);
            sum += x;
        }

        Console.WriteLine("Сумма равна: " + sum);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение приведенного выше кода дает следующий результат.

// Значение элемента равно: 0
// Значение элемента равно: 1
// Значение элемента равно: 2
// Значение элемента равно: 3
// Значение элемента равно: 4
// Значение элемента равно: 5
// Значение элемента равно: 6
// Значение элемента равно: 7
// Значение элемента равно: 8
// Значение элемента равно: 9
// Сумма равна: 45

// Как видите, оператор foreach циклически опрашивает массив по порядку индексирования
// от самого первого до самого последнего его элемента.

#endregion

#region English

// The foreach Loop

// In Chapter 5, it was mentioned that C# defines a loop called foreach, but a discussion of
// that statement was deferred until later. The time for that discussion has now come.

// The foreach loop is used to cycle through the elements of a collection. A collection is a
// group of objects. C# defines several types of collections, of which one is an array. The general
// form of foreach is shown here:

// foreach(type loopvar in collection) statement;

// Here, type loopvar specifies the type and name of an iteration variable. The iteration variable
// receives the value of the next element in the collection each time the foreach loop iterates.
// The collection being cycled through is specified by collection, which, for the rest of this
// discussion, is an array. Thus, type must be the same as (or compatible with) the element
// type of the array. The type can also be var, in which case the compiler determines the type
// based on the element type of the array. This can be useful when working with certain
// queries, as described later in this book. Normally, you will explicitly specify the type.

// Here is how foreach works. When the loop begins, the first element in the array is
// obtained and assigned to loopvar. Each subsequent iteration obtains the next element from
// the array and stores it in loopvar. The loop ends when there are no more elements to obtain.
// Thus, the foreach cycles through the array one element at a time, from start to finish.

// One important point to remember about foreach is that the iteration variable loopvar is
// read-only. This means you can’t change the contents of an array by assigning the iteration
// variable a new value.

// Here is a simple example that uses foreach. It creates an array of integers and gives it
// some initial values. It then displays those values, computing the summation in the process.

//Use the foreach loop.
// using System; 

// class ForeachDemo
// {
//    static void Main()
//    {
//        int sum = 0;
//        int[] nums = new int[10];

//        // Give nums some values. 
//        for (int i = 0; i < 10; i++)
//            nums[i] = i;

//        // Use foreach to display and sum the values. 
//        foreach (int x in nums)
//        {
//            Console.WriteLine("Value is: " + x);
//            sum += x;
//        }
//        Console.WriteLine("Summation: " + sum);
//    }
// }

// The output from the program is shown here:

// Value is: 0
// Value is: 1
// Value is: 2
// Value is: 3
// Value is: 4
// Value is: 5
// Value is: 6
// Value is: 7
// Value is: 8
// Value is: 9
// Summation: 45

// As this output shows, foreach cycles through an array in sequence from the lowest index to
// the highest.

#endregion