// Оператор let может также использоваться для хранения неперечислимого значения.
// В качестве примера ниже приведен более эффективный вариант формирования
// запроса в программе IntoDemo из предыдущего раздела.

using System;
using System.Linq;

class IntiDemo
{
    static void Main()
    {
        string[] websites = {   "hsNameA.com", "hsNameB.net", "hsNameC.net",
                                "hsNameD.com", "hsNameE.org", "hsNameF.org",
                                "hsNameG.tv", "hsNameH.net", "hsNameI.tv"};

        // Сформировать запрос на получение списка веб-сайтов, группируемых
        // по имени домена самого верхнего уровня, но выбрать только те группы,
        // которыые состоят более чем из двух членов.
        // Здесь ws - это переменная диапазона для ряда групп,
        // возвращаемых при выполнении первой половины запроса.
        var webAddrs = from addr in websites
                       let idx = addr.LastIndexOf('.')
                       where idx != -1
                       group addr by addr.Substring(idx)
                     into ws
                       where ws.Count() > 2
                       select ws;

        // Выполнить запрос и вывести его результаты.
        Console.WriteLine("Домены самого верхнего уровня с более чем двумя членами.\n");

        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Содержимое домена: " + sites.Key);

            foreach (var site in sites)
            {
                Console.WriteLine("\t" + site);
            }

            Console.WriteLine();
        }

        // Задержка программы.
        Console.ReadKey();
    }
}

// В этом варианте индекс последнего вхождения символа точки в строку присваивается
// переменной idx. Данное значение затем используется в методе Substring().
// Благодаря этому исключается необходимость дважды искать символ точки в строке.