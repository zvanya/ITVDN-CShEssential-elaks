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

    public double X { get; set; } = 0;
    public double Y { get; set; } = 0;
    public double Price { get { return price; } set { price = value; } }
    public double Speed { get { return speed; } }
    public int YearCreation { get { return yearCreation; } }
    string Type
    { get { return type == null ? "Неизв.тип трансп.средства" : type; } }

    public virtual void ShowInfo()
    {
      Console.WriteLine("Тип:{0}", Type);
      Console.WriteLine(new string('-', 10));
      Console.WriteLine("Координаты: X = {0}; Y = {1}", X, Y);
      Console.WriteLine(new string('-', 10));
      Console.WriteLine("Общие характеристики:");
      Console.WriteLine("Price: {0}", Price);
      Console.WriteLine("Speed: {0}", Speed);
      Console.WriteLine("YearCreation: {0}", YearCreation);
    }
  }

  class Car : Vehicle
  {
    public Car(double price, double speed, int yearCreation) : base(price, speed, yearCreation)
    {
      type = "Car";
    }

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine(new string('-', 50));
    }
  }

  class Plane : Vehicle
  {
    int height = 0;
    int passCount = 0;
    public Plane(double price, double speed, int yearCreation, int height, int passCount) : base(price, speed, yearCreation)
    {
      type = "Plane";
      this.height = height;
      this.passCount = passCount;
    }

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine(new string('-', 10));
      Console.WriteLine("Доп. характеристики:");
      Console.WriteLine("height: {0}", height);
      Console.WriteLine("passCount: {0}", passCount);
      Console.WriteLine(new string('-', 50));
    }
  }

  class Ship : Vehicle
  {
    string port = null;
    int passCount = 0;
    public Ship(double price, double speed, int yearCreation, string port, int passCount) : base(price, speed, yearCreation)
    {
      type = "Ship";
      this.port = port;
      this.passCount = passCount;
    }

    public override void ShowInfo()
    {
      base.ShowInfo();
      Console.WriteLine(new string('-', 10));
      Console.WriteLine("Доп. характеристики:");
      Console.WriteLine("port: {0}", port);
      Console.WriteLine("passCount: {0}", passCount);
      Console.WriteLine(new string('-', 50));
    }
  }
}
