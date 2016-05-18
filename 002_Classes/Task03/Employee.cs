using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Employee
  {
    public enum PositionList { pos1, pos2, pos3 };

    string name = null;
    string surname = null;
    PositionList position;
    double taxKoef = 0.1;
    double expKoef = 1.2;

    public Employee(string name, string surname)
    {
      this.name = name;
      this.surname = surname;
    }

    public PositionList Position
    {
      get { return position; }
      set
      {
        position = value;
      }
    }

    public string Name
    { get { return name; } }

    public string Surname
    { get { return surname; } }

    public int Experience { get; set; }

    double PayCalculate()
    {
      switch (Position)
      {
        case PositionList.pos1:
          return expKoef * Experience * 1000;
        case PositionList.pos2:
          return expKoef * Experience * 500;
        case PositionList.pos3:
          return expKoef * Experience * 100;
      }
      return -1;
    }

    public double Pay
    {
      get { return PayCalculate(); }
    }

    public double Tax
    {
      get { return TaxCalculate(); }
    }

    double TaxCalculate()
    {
      switch (Position)
      {
        case PositionList.pos1:
          return Pay * taxKoef;
        case PositionList.pos2:
          return Pay * taxKoef;
        case PositionList.pos3:
          return Pay * taxKoef;
      }
      return -1;
    }
  }
}
