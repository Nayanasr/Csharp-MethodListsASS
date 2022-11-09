using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsListAss
{
    public class ListFindAllClass
    {
        // function which checks whether an
        // element is even or not. Or you can
        // say it is the specified condition
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }
        public void findAll()
        {
            // Creating an List<T> of Integers
            List<int> firstlist = new List<int>();

            // Adding elements to List
            firstlist.Add(2);
            firstlist.Add(4);
            firstlist.Add(7);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(2);
            firstlist.Add(4);

            Console.WriteLine("Elements Present in List:\n");

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.Write("Elements that Match: \n");

            // Will give the List of Elements that
            // match the conditions defined by predicate
            List<int> Result = new List<int>(firstlist.FindAll(isEven));

            foreach (int i in Result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
