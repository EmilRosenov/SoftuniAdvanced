﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.matchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Stack<int> indexes = new Stack<int>()
                ;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    indexes.Push(i);
                }
                else if (input[i]==')')
                {
                    int index = indexes.Pop();
                    string substring = input.Substring(index, i-index+1);
                    Console.WriteLine(substring);
                }
                
            }
          
        }
    }
}
