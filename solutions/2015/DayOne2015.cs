using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCodeCSharp
{
    class DayOne2015
    {
        public string DayOne()
        {
            /* Grab input as character array */
            string puzzleInput = File.ReadAllText(@"inputs/2015/day_one.txt");
            char[] puzzleInputArr = puzzleInput.ToCharArray();
            
            /* Keep running total in arr */
            List<int> floor = new List<int>(); 

            for (int i = 0; i < puzzleInputArr.Length; i ++)
            {
                if (puzzleInputArr[i] == '(')
                {
                    floor.Add(1);
                }
                else if  (puzzleInputArr[i] == ')')
                {
                    floor.Add(-1);  
                }
            }

            int finalFloor = 0;
            
            List<int> basementVisits = new List<int>();
            for (int i = 0; i < floor.Count; i++)
            {
                finalFloor += floor[i];
                if (finalFloor == -1)
                {
                    basementVisits.Add(i + 1);
                }
            }

           string puzzleAnswer = $"The instructions take Santa to {finalFloor}. He first enters the basement on the {basementVisits[0]} floor.";
           return puzzleAnswer;
        }
    }
}