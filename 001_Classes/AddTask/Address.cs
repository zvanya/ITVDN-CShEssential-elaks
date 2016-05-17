using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Address
  {
    string index, country, city, street, house, apartment;

    public string Index
    {
      set { index = value; }
      get { return index; }
    }

    public string Country
    {
      set { country = value; }
      get { return country; }
    }
    public string City
    {
      set { city = value; }
      get { return city; }
    }
    public string Street
    {
      set { street = value; }
      get { return street; }
    }

  }
}
