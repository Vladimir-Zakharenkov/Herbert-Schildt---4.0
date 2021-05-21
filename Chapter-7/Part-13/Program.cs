#region Russian

// Применение свойства Length при обращении со ступенчатыми массивами

// Особый случай представляет применение свойства Length при обращении со ступенчатыми
// массивами. В этом случае с помощью данного свойства можно получить
// длину каждого массива, составляющего ступенчатый массив. В качестве примера рассмотрим
// следующую программу, в которой имитируется работа центрального процессора
// (ЦП) в сети, состоящей из четырех узлов.

//Продемонстрировать применение свойства Length при обращении со ступенчатыми массивами.
using System;

class Jagged
{
    static void Main()
    {
        int[][] network_nodes = new int[4][];
        network_nodes[0] = new int[3];
        network_nodes[1] = new int[7];
        network_nodes[2] = new int[2];
        network_nodes[3] = new int[5];

        int i, j;

        //Сфабриковать данные об использовании ЦП.
        for (i = 0; i < network_nodes.Length; i++)
        {
            for (j = 0; j < network_nodes[i].Length; j++)
            {
                network_nodes[i][j] = i * j + 70;
            }
        }

        Console.WriteLine("Общее количество узлов сети: " + network_nodes.Length);

        Console.WriteLine();

        for (i = 0; i < network_nodes.Length; i++)
        {
            for (j = 0; j < network_nodes[i].Length; j++)
            {
                Console.WriteLine("Использование в узле " + i + " ЦП " + j + ": " + network_nodes[i][j] + "%");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// Общее количество узлов сети: 4

// Использование в узле 0 ЦП 0: 70 %
// Использование в узле 0 ЦП 1: 70 %
// Использование в узле 0 ЦП 2: 70 %

// Использование в узле 1 ЦП 0: 70 %
// Использование в узле 1 ЦП 1: 71 %
// Использование в узле 1 ЦП 2: 72 %
// Использование в узле 1 ЦП 3: 73 %
// Использование в узле 1 ЦП 4: 74 %
// Использование в узле 1 ЦП 5: 75 %
// Использование в узле 1 ЦП 6: 76 %

// Использование в узле 2 ЦП 0: 70 %
// Использование в узле 2 ЦП 1: 72 %

// Использование в узле 3 ЦП 0: 70 %
// Использование в узле 3 ЦП 1: 73 %
// Использование в узле 3 ЦП 2: 76 %
// Использование в узле 3 ЦП 3: 79 %
// Использование в узле 3 ЦП 4: 82 %

// Обратите особое внимание на то, как свойство Length используется в ступенчатом
// массиве network_nodes. Напомним, что двумерный ступенчатый массив представляет
// собой массив массивов. Следовательно, когда используется выражение

// network_nodes.Length

// то в нем определяется число массивов, хранящихся в массиве network_nodes (в данном
// случае — четыре массива). А для получения длины любого отдельного массива,
// составляющего ступенчатый массив, служит следующее выражение.

// network_nodes[0].Length

// В данном случае это длина первого массива.

#endregion

#region English

// Using Length with Jagged Arrays

// A special case occurs when Length is used with jagged arrays. In this situation, it is possible
// to obtain the length of each individual array. For example, consider the following program,
// which simulates the CPU activity on a network with four nodes:

// Demonstrate Length with jagged arrays. 
// using System; 

// class Jagged
// {
//    static void Main()
//    {
//        int[][] network_nodes = new int[4][];
//        network_nodes[0] = new int[3];
//        network_nodes[1] = new int[7];
//        network_nodes[2] = new int[2];
//        network_nodes[3] = new int[5];


//        int i, j;

//        // Fabricate some fake CPU usage data. 
//        for (i = 0; i < network_nodes.Length; i++)
//            for (j = 0; j < network_nodes[i].Length; j++)
//                network_nodes[i][j] = i * j + 70;


//        Console.WriteLine("Total number of network nodes: " +
//                          network_nodes.Length + "\n");

//        for (i = 0; i < network_nodes.Length; i++)
//        {
//            for (j = 0; j < network_nodes[i].Length; j++)
//            {
//                Console.Write("CPU usage at node " + i +
//                              " CPU " + j + ": ");
//                Console.Write(network_nodes[i][j] + "% ");
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
// }

// The output is shown here:

// Total number of network nodes: 4

// CPU usage at node 0 CPU 0: 70 %
// CPU usage at node 0 CPU 1: 70 %
// CPU usage at node 0 CPU 2: 70 %

// CPU usage at node 1 CPU 0: 70 %
// CPU usage at node 1 CPU 1: 71 %
// CPU usage at node 1 CPU 2: 72 %
// CPU usage at node 1 CPU 3: 73 %
// CPU usage at node 1 CPU 4: 74 %
// CPU usage at node 1 CPU 5: 75 %
// CPU usage at node 1 CPU 6: 76 %

// CPU usage at node 2 CPU 0: 70 %
// CPU usage at node 2 CPU 1: 72 %

// CPU usage at node 3 CPU 0: 70 %
// CPU usage at node 3 CPU 1: 73 %
// CPU usage at node 3 CPU 2: 76 %
// CPU usage at node 3 CPU 3: 79 %
// CPU usage at node 3 CPU 4: 82 %

// Pay special attention to the way Length is used on the jagged array network_nodes.
// Recall, a two-dimensional jagged array is an array of arrays. Thus, when the expression

// network_nodes.Length

// is used, it obtains the number of arrays stored in network_nodes, which is four in this case.
// To obtain the length of any individual array in the jagged array, you will use an expression
// such as this:

// network_nodes[0].Length

// which, in this case, obtains the length of the first array.

#endregion