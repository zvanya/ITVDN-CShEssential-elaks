using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Vehicle // Транспортное средство
  {
    protected string type = null;
    protected double price = 0;
    protected double speed = 0;
    protected int yearCreation = 0;

    public Vehicle(double price, double speed, int yearCreation)
    {
      this.price = price;
      this.speed = speed;
      this.yearCreation = yearCreation;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Price { get { return price; } set { price = value; } }
    public double Speed { get { return speed; } set { speed = value; } }
    public int YearCreation { get { return yearCreation; } set { yearCreation = value; } }
    string Type
    {
      get
      {
        //TODO: добавить проверку
        return type;
      }
    }

    void ShowInfo()
    {
      Console.WriteLine("Общие характеристики:\n");
      Console.WriteLine("Общие характеристики:\n");
    }
  }
}
