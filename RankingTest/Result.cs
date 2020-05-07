using System;
using System.Collections.Generic;
using System.Text;

namespace RankingTest
{
    public class Result
    {
         public int Year { get; set; }
        private int marks;
        public string Subject { get; set; }


        public Result(int yrs, int mark, string subj)
        {
            Year = yrs;
            Marks = mark;
            Subject = subj;
        }


        public int Marks
        {
            get { return marks; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    marks = value;
                }
                else
                {
                  //  throw ArgumentOutOfRangeException;
                }
            }
        }
    }
}