﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlabik_10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Book LOTR = new Book();
              LOTR.Title = "Lord Of The Rings";
               LOTR.Pages = 576;
               LOTR.Category = "Fantasy";
               LOTR.Author = "J.R.R.Tolkien";
               LOTR.ReleaseDate = 1954;
               Console.WriteLine(LOTR.ToString());*/

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine();

            Book LOTR3 = new Book("Lord Of The Rings 3", 1536);
            Console.WriteLine(LOTR3.ToString());

            Book HOBIT = new Book("Hobit", 304, "Fantasy", "J. R. R. Tolkien", 1937);
            Console.WriteLine(HOBIT.ToString());
        }
    }
}