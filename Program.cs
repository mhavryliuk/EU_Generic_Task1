using System;
using System.Collections.Generic;

/** <remark>
 * Realize generic class that searches values in the list. 
 * Call search operations through generic delegates to implement this for strings and 3D points.
 </remark> */

namespace _20180315_Task1
{
    internal delegate bool Operation<in T>(T parameter);

    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("********** Searching for string values **********");

            List<string> strings = new List<string> { "Lemon", "Apple", "Cherry", "Strawberry", "Melon" };

            foreach (string word in strings)
            {
                Console.Write(word + "  ");
            }
            Console.WriteLine("\n");

            GenericClass<string> gc1 = new GenericClass<string>(strings);
            Operation<string> strDel = gc1.Search;

            Console.WriteLine("Cherry: " + strDel.Invoke("Cherry"));
            Console.WriteLine("Watermelon: " + strDel.Invoke("Watermelon"));
            Console.WriteLine("\n");



            Console.WriteLine("********** Searching for 3D points **********");

            List<Point3D> points = new List<Point3D>
            {
                new Point3D(16.3, 5.2, 14.7),
                new Point3D(5.2, 11.8, 24)
            };

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine();

            GenericClass<Point3D> gc2 = new GenericClass<Point3D>(points);
            Operation<Point3D> pointDel = gc2.Search;

            Console.WriteLine("[x =  5.2;  y = 11.8;  z =   24]: " + pointDel.Invoke(new Point3D(5.2, 11.8, 24)));
            Console.WriteLine("[x =    7;  y =    7;  z =    7]: " + pointDel.Invoke(new Point3D(7, 7, 7)));

            Console.ReadKey();
        }
    }
}