using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Book
  {
    Title title = null;
    Author author = null;
    Content content = null;

    public Book(string title)
    {
      this.title.Name = title;
    }

    public string AuthorName
    {
      get
      {
        return this.author.Name;
      }
      set
      {
        this.author.Name = value;
      }
    }
    public string ContentText
    {
      get
      {
        return this.content.Text;
      }
      set
      {
        this.content.Text = value;
      }
    }

    public string Title
    {
      get
      {
        return this.title.Name;
      }
      set
      {
        this.title.Name = value;
      }
    }
  }
}
