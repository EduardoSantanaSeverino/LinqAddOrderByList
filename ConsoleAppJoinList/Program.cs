using System;
using System.Collections.Generic;
using System.Linq;

/*
 Inputs
- Original list of strings
- List of strings to be added
- List of strings to be removed

Return
- List shall only contain unique values
- List shall be ordered as follows
--- Most character count to least character count
--- In the event of a tie, reverse alphabetical

Other Notes
- You can use any programming language you like
- The function you submit shall be runnable

For example:

Original List = ["one", "two", "three",]
Add List = ["one", "two", "five", "six]
Delete List = ["two", "five"]
Result List = ["three", "six", "one"]
 */

namespace ConsoleAppJoinList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Original_List = new List<string>(){"one", "two", "three"};
            List<string> Add_List = new List<string>(){"one", "two", "five", "six"};
            List<string> Delete_List = new List<string>(){"two", "five"};
            List<string> Result_List = new List<string>();
 
            Console.WriteLine("Program to add to list and order it:" + Environment.NewLine);
            
            Console.WriteLine("Original_List:");
            Console.WriteLine(printList(Original_List));
            
            Console.WriteLine("Add_List:");
            Console.WriteLine(printList(Add_List));
            
            Console.WriteLine("Delete_List:");
            Console.WriteLine(printList(Delete_List));

            Result_List.AddRange(Original_List);
            foreach (var item in Add_List)
            {
                if (!Original_List.Any(f => f.Equals(item)) && !Delete_List.Any(f => f.Equals(item)))
                {
                    Result_List.Add(item);
                }
            }

            foreach (var item in Delete_List)
            {
                if (Result_List.Any(f => f.Equals(item)))
                {
                    Result_List.Remove(item);
                }
            }

            Result_List = Result_List
                .OrderByDescending(p => p.Length)
                .ThenByDescending(p => p).ToList();
            

            Console.WriteLine("Result_List:");
            Console.WriteLine(printList(Result_List));

            
            Console.WriteLine("END!");
        }

        static string printList(List<string> list)
        {
            string retVal = "[";
            retVal += string.Join(", ", list);
            retVal += "]" + Environment.NewLine;
            return retVal;
        }
        
    }
}