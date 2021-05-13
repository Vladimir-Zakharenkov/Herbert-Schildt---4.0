#region Russian

// Присваивание ссылок на массивы

// Присваивание значения одной переменной ссылки на массив другой переменной,
// по существу, означает, что обе переменные ссылаются на один и тот же массив,
// и в этом отношении массивы ничем не отличаются от любых других объектов. Такое
// присваивание не приводит ни к созданию копии массива, ни к копированию содержимого
// одного массива в другой. В качестве примера рассмотрим следующую программу.

//Присваивание ссылок на массивы.
using System;

class AssignARef
{
    static void Main()
    {
        int i;

        int[] nums1 = new int[10];
        int[] nums2 = new int[10];

        for (i = 0; i < 10; i++)
        {
            nums1[i] = i;
        }

        for (i = 0; i < 10; i++)
        {
            nums2[i] = -i;
        }

        Console.WriteLine("Содержимое массива nums1: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write(nums1[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Содержимое массива nums2: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write(nums2[i] + " ");
        }
        Console.WriteLine();

        nums2 = nums1; //теперь nums2 ссылается на nums1

        Console.WriteLine("Содержимое массива nums2\nпосле присваивания: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write(nums2[i] + " ");
        }
        Console.WriteLine();

        //Далее оперировать массивом nums1 посредством переменной ссылки на массив nums2.
        nums2[3] = 99;

        Console.WriteLine("Содержимое массиива nums1 после изменения\nпосредством переменной nums2: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write(nums1[i] + " ");
        }
        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этой программы приводит к следующему результату.

// Содержимое массива nums1: 0 1 2 3 4 5 6 7 8 9
// Содержимое массива nums2: 0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9
// Содержимое массива nums2
// после присваивания: 0 1 2 3 4 5 6 7 8 9
// Содержимое массива nums1 после изменения
// посредством переменной nums2: 0 1 2 99 4 5 6 7 8 9

// Как видите, после присваивания переменной nums2 значения переменной nums1
// обе переменные ссылки на массив ссылаются на один и тот же объект.

#endregion

#region English

// Assigning Array References

// As with other objects, when you assign one array reference variable to another, you are
// simply making both variables refer to the same array. You are neither causing a copy of the
// array to be created, nor are you causing the contents of one array to be copied to the other.
// For example, consider this program:

// Assigning array reference variables. 

// using System; 

// class AssignARef
// {
//    static void Main()
//    {
//        int i;

//        int[] nums1 = new int[10];
//        int[] nums2 = new int[10];

//        for (i = 0; i < 10; i++) nums1[i] = i;

//        for (i = 0; i < 10; i++) nums2[i] = -i;

//        Console.Write("Here is nums1: ");
//        for (i = 0; i < 10; i++)
//            Console.Write(nums1[i] + " ");
//        Console.WriteLine();

//        Console.Write("Here is nums2: ");
//        for (i = 0; i < 10; i++)
//            Console.Write(nums2[i] + " ");
//        Console.WriteLine();

//        nums2 = nums1; // now nums2 refers to nums1 

//        Console.Write("Here is nums2 after assignment: ");
//        for (i = 0; i < 10; i++)
//            Console.Write(nums2[i] + " ");
//        Console.WriteLine();

//        // Next, operate on nums1 array through nums2. 
//        nums2[3] = 99;

//        Console.Write("Here is nums1 after change through nums2: ");
//        for (i = 0; i < 10; i++)
//            Console.Write(nums1[i] + " ");
//        Console.WriteLine();
//    }
// }

// The output from the program is shown here:

// Here is nums1: 0 1 2 3 4 5 6 7 8 9
// Here is nums2: 0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9
// Here is nums2 after assignment: 0 1 2 3 4 5 6 7 8 9
// Here is nums1 after change through nums2: 0 1 2 99 4 5 6 7 8 9

// As the output shows, after the assignment of nums1 to nums2, both array reference
// variables refer to the same object.

#endregion