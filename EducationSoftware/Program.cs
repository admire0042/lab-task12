using System;
using System.Collections;

namespace EducationSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] record = new string[15,5]{{"Fluid Dynamics","Adekunle Adebola", "Mathematics", "4","Primary"}, {"Internal Relation", "Mathew James", "Social Studies", "2", "Primary"}, {"Chemical Physics","Okosun Micah", "Chemistry", "5", "Labs"}, {"Mathematical Modelling", "Ituah John", "Mathematics","3","Higher"}, {"Genetics", "Ituah John", "Biology","4","Higher"}, {"Industrialization", "Mathew James", "Chemistry", "4", "Labs"}, {"Micro-Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}, {"Molecular Physics", "Ogundele Blessing", "Physics", "1", "Labs"}};


             ArrayList arr = new ArrayList();
            for(int i = 0; i < 15; i++)
            {
                arr.Add($"{record[i,0]} {record[i,1]}  {record[i,2]} {record[i,4]}");
            }
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAfter one of the record is removed\n");

            arr.RemoveAt(1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
