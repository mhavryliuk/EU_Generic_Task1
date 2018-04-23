using System;
using System.Collections.Generic;

/* Realize generic class that searches values in the list. 
 * Call search operations through generic delegates. 
 * To implement this for strings and 3D points.
 * 
 * Реализуйте обобщенный класс, который ищет значения в списке. 
 * Вызовите операции поиска через общие делегаты. 
 * Чтобы реализовать это для строк и трехмерных точек. */

namespace _20180315_Task1
{
    delegate T SomeOp<T>(T v);

    class GenDelegate
    {
        // Метод для подсчета количества заданного элемента в списке
        static int Find(int v)
        {
            List<int> numbers = new List<int>() { 2, 1, 3, 4, 7, 3 };
            int result = 0;

            Console.Write("Содержимое списка: ");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }

            // Поиск и подсчет интересующего числа
            foreach (int item in numbers)
            {
                if (item == v)
                    result++;
            }
            return result;
        }

        static void Main()
        {
            SomeOp<int> intDel = Find;

            int wantedNumber = 3;

            // Выводим количество троек в списке
            Console.Write($"\nКоличество {wantedNumber} в списке: " + intDel(wantedNumber));

            Console.ReadKey();
        }
    }
}