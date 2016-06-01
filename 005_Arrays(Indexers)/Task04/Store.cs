using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Store
  {
    Article[] a;

    public void AddArticle(Article a)
    {
      
    }

    public Store(int articlesCount)
    {
      a = new Article[articlesCount];
    }

    public Article this[int index]
    {
      //set { a[index] = value; }
      get { return a[index]; }
    }

    public Article this[string name]
    {
      get
      {
        for (int i = 0; i < a.Length; i++)
        {
          if (a[i].Name == name)
          {
            return a[i];
          }
        }
        return null;
      }
    }

  }
  class Article
  {
    string name = null;
    string shopName = null;
    float price = 0;

    public string Name { get { return name; } }
    public string ShopName { get { return shopName; } }
    public float Price { get { return price; } }

    public Article(string name, string shopName, float price)
    {
      this.name = name;
      this.shopName = shopName;
      this.price = price;
    }

    void ShowInfo()
    {

    }
  }

}
