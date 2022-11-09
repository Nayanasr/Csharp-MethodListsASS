using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsListAss
{
    public class ListContainsClass
    {
        public void listContains()
        {
            //List<T>.Contains(T) Method is used to check whether an element is in the List<T> or not

            // Creating an List<T> of String
            List<String> firstlist = new List<String>();

            // Adding elements to List
            firstlist.Add("Hai");
            firstlist.Add("Everyone!");
            firstlist.Add("Good");
            firstlist.Add("Morning");
            firstlist.Add("Have a");
            firstlist.Add("Nice");
            firstlist.Add("Day");

            // Checking whether Coffee is present
            // in List or not
            Console.Write(firstlist.Contains("Coffee"));
        }
    }
}
