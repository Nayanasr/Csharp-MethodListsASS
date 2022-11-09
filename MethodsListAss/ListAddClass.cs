using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsListAss
{
    public class ListAddClass
    {
        public void list()
        {
            //List.Add(T) Method is used to add an object to the end of the List.

            // Creating a List of integers
            List<int> firstlist = new List<int>();

            // adding elements in firstlist
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            // Adding some duplicate
            // elements in firstlist
            firstlist.Add(3);
            firstlist.Add(4);

            // Displaying elements of firstlist
            // by using foreach loop
            foreach (int element in firstlist)
            {
                Console.WriteLine(element);
            }
        }
    }

}



    

