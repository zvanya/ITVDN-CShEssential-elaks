using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Employee
  {
    string name = null;
    string surname = null;
    string position = null;
    double pay = 0;
    int experience = 0;
    double tax = 0;

    public Employee(string name, string surname)
    {
      this.name = name;
      this.surname = surname;
    }
  }
}
