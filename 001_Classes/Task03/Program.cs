﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b = new Book("BookName1");

      b.AuthorName = "AuthorName1";
      b.ContentText = "ContentText1";

      Console.ReadKey();
    }
  }
}
