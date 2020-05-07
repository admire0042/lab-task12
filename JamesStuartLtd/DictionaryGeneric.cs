using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JamesStuartLtd
{
    public class DictionaryGeneric : DictionaryBase
    {
         public void Add(string name, string dept)
        {
            Dictionary.Add(name, dept);
        }

        public void OnRemove(int name)
        {
            Console.WriteLine($"You are going to delete record containing ID : {name}");
            Dictionary.Remove(name);
        }

        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate =
            Dictionary.GetEnumerator();
                while (objEnumerate.MoveNext())
                    {
                        Console.WriteLine(objEnumerate.Key.ToString() + "\t\t" + objEnumerate.Value);
                    }
        }
    }
}