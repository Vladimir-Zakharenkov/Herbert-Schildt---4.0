// Ниже приведена программа, демонстрирующая другое применение оператора
// select. В этой программе сначала создается класс EmailAddress, содержащий два
// свойства. В первом из них хранится имя адресата, а во втором — адрес его электронной
// почты. Затем в этой программе создается массив, содержащий несколько элементов
// данных типа EmailAddress. И наконец, в данной программе создается список, состоящий
// только из адресов электронной почты, извлекаемых по запросу.

// Возвратить часть значения переменной диапазона.
using System;
using System.Linq;

class EmailAddress
{
    public string Name { get; set; }
    public string Address { get; set; }

    public EmailAddress(string n, string a)
    {
        Name = n;
        Address = a;
    }
}

class SelectDemo2
{
    static void Main()
    {
        EmailAddress[] addrs =
        {
            new EmailAddress("Герберт", "Herb@HerbertSchildt.com"),
            new EmailAddress("Том", "Tom@HerbertSchildt.com"),
            new EmailAddress("Сара", "Sara@HerbertSchildt.com")
        };

        //Сформировать запрос на получение адресов электронной почты.
        var eAddrs = from entry in addrs
                     select entry.Address;

        Console.WriteLine("Адреса электронной почты:\n");

        //Выполнить запрос и вывести его результаты.
        foreach (string s in eAddrs)
        {
            Console.WriteLine(" " + s);
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этой программы.

// Адреса электронной почты:
// Herb @HerbSchildt.com
// Tom @HerbSchildt.com
// Sara@HerbSchildt.com

// Обратите особое внимание на следующий оператор select.

//select entry.Address;

// Вместо полного значения переменной диапазона этот оператор возвращает лишь
// его адресную часть (Address). Это означает, что по данному запросу возвращается
// последовательность символьных строк, а не объектов типа EmailAddress. Именно
// поэтому переменная s указывается в цикле foreach как string. Ведь как пояснялось
// ранее, тип последовательности результатов, возвращаемых по запросу, определяется
// типом значения, возвращаемым оператором select.