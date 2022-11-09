using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsListAss
{
    public class ListReverseClass
    {
        public void reverse() {
            // Creating an List<T> of Integers
            List<int> firstlist = new List<int>();

            // Adding elements to List
            for (int i = 1; i <= 5; i++)
            {
                firstlist.Add(i);
            }

            Console.WriteLine("Elements Present in List:");

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.WriteLine("After Reversing: ");

            // using method Reverse()
            firstlist.Reverse();

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }
        }
        

       
    }
}
