﻿using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

           
            
            
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            SortedSet<Book> sortedList = new SortedSet<Book>(new BookComparator())
            {
                bookOne,
                bookTwo,
                bookThree
            };

            foreach (var book in sortedList)
            {
                Console.WriteLine(book);
            }
        }
    }
}
