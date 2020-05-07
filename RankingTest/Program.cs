using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RankingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            Result result1 = new Result(2019, 90,"MATHS");
            Result result2 = new Result(2018, 75, "English");
            Result result3 = new Result(2019, 69, "Chemistry");
            Result result4 = new Result(2018, 79, "MATHS");
            Result result5 = new Result(2019, 59, "Chemistry");
            Result result6 = new Result(2019, 62, "English");
            Result result7 = new Result(2018, 79, "Chemistry");
            Result result8 = new Result(2018, 89, "MATHS");
            Result result9 = new Result(2019, 71, "English");
            Result result10 = new Result(2018, 29, "Chemistry");
            Result result11 = new Result(2019, 87, "MATHS");

            Rankers rankers1 = new Rankers("Ituah John",result1);
            Rankers rankers2 = new Rankers("Bolarinwa Sade", result2);
            Rankers rankers3 = new Rankers("Johnson Sharon", result3);
            Rankers rankers4 = new Rankers("Oguntunde Issac", result4);
            Rankers rankers5 = new Rankers("Ikubani Mattew", result5);
            Rankers rankers6 = new Rankers("Bolarinwa Sola", result6);
            Rankers rankers7 = new Rankers("Olapelu Titus", result7);
            Rankers rankers8 = new Rankers("Peace Okogie", result8);
            Rankers rankers9 = new Rankers("Kolapo Adewale", result9);
            Rankers rankers10 = new Rankers("Chukwuese Ifeanyi", result10);
            Rankers rankers11 = new Rankers("Oreoluwa Kunle", result11);
            rankers1.GetTopRanked();
            rankers2.GetTopRanked();
            rankers3.GetTopRanked();
            rankers4.GetTopRanked();
            rankers5.GetTopRanked();
            rankers6.GetTopRanked();
            rankers7.GetTopRanked();
            rankers8.GetTopRanked();
            rankers9.GetTopRanked();
            rankers10.GetTopRanked();
            rankers11.GetTopRanked();

           
            hashtable.Add(rankers1.Name, rankers1.GetResults());
            hashtable.Add(rankers2.Name, rankers2.GetResults());
            hashtable.Add(rankers3.Name, rankers3.GetResults());
            hashtable.Add(rankers4.Name, rankers4.GetResults());
            hashtable.Add(rankers5.Name, rankers5.GetResults());
            hashtable.Add(rankers6.Name, rankers6.GetResults());
            hashtable.Add(rankers7.Name, rankers7.GetResults());
            hashtable.Add(rankers8.Name, rankers8.GetResults());
            hashtable.Add(rankers9.Name, rankers9.GetResults());
            hashtable.Add(rankers10.Name, rankers10.GetResults());
            hashtable.Add(rankers11.Name, rankers11.GetResults());

           
            foreach (Object key in hashtable.Values)
            {
                Console.WriteLine($"{key}");
            }

            
                if(hashtable.ContainsKey(rankers1.Name)){
                    Console.WriteLine($"{rankers1.Name} has gotten admission into the University");
                 }
               


        }
    }
}
