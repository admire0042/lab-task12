using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace JamesStuartLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryGeneric employee = new DictionaryGeneric();
            employee.Add("Tom Lee", "Training");
            employee.Add("James Anderson", "HR");
            employee.Add("Michael Chan", "Content Development");
            employee.Add("Jackie Jackson", "Training");
            employee.Add("Bruce Douglas", "Graphics");
            employee.Add("Joseph Mathew", "Content Development");
            employee.Add("Rose Dorson", "Marketting");
            employee.Add("Andrews Stephans", "Graphics");
            employee.Add("Kim Date", "HR");

            Console.WriteLine("\nThe record of promoted member  of staff using Dictionary Generic\n");
            employee.GetDetails();
           
            SortedList emp = new SortedList(){{"Tom Lee", "Training"},{"James Anderson", "HR"},{"Michael Chan", "Content Development"},{"Jackie Jackson", "Training"},{"Bruce Douglas", "Graphics"},{"Joseph Mathew", "Content Development"},{"Rose Dorson", "Marketting"},{"Andrews Stephans", "Graphics"},{"Kim Date", "HR"}};
            
            Console.WriteLine("======================================\n");
            Console.WriteLine("The sortlisted record of promoted members of staff using SortedList\n");
            foreach (DictionaryEntry item in emp)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

             
            Console.WriteLine("\nLIST AFTER DISCOVERING A STAFF HAS LEFT\n");

            Console.Write("Checking if Andrews Stephans is still on the list: ");
            Console.WriteLine(emp.Contains("Andrews Stephans"));
            
            emp.Remove("Andrews Stephans");

            Console.WriteLine("\n Record is removed\n");
            foreach (DictionaryEntry item in emp)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
