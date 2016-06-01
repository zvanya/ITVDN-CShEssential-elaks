using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class MyMatrix
  {
    int row = 0;
    int col = 0;
    float[,] m;

    public MyMatrix(int row, int col)
    {
      this.row = row;
      this.col = col;
      m = new float[row, col];

      Random r = new Random();
      for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
          m[i, j] = r.Next(0, 101);
    }

    public static void Resize(int newRow, int newCol, ref float[,] m)
    {
      if (m.GetLength(0) < 1 || m.GetLength(1) < 1)
      {
        Console.WriteLine("Неверно задан массив на входе.");
        return;
      }
      if (newRow < 1 || newCol < 1 || newRow > m.GetLength(0) || newCol > m.GetLength(1))
      {
        Console.WriteLine("Неверно заданы размеры нового массива.");
        return;
      }

      float[,] newM = new float[newRow, newCol];

      for (int i = 0; i < newRow; i++)
      {
        for (int j = 0; j < newCol; j++)
        {
          newM[i, j] = m[i, j];
        }
      }

      m = newM;
    }
    
    public void Resize(int newRow, int newCol)
    {
      if (m.GetLength(0) < 1 || m.GetLength(1) < 1)
      {
        Console.WriteLine("Неверно задан массив на входе.");
        return;
      }
      if (newRow < 1 || newCol < 1 || newRow > this.m.GetLength(0) || newCol > this.m.GetLength(1))
      {
        Console.WriteLine("Неверно заданы размеры нового массива.");
        return;
      }

      float[,] newM = new float[newRow, newCol];

      for (int i = 0; i < newRow; i++)
      {
        for (int j = 0; j < newCol; j++)
        {
          newM[i, j] = this.m[i, j];
        }
      }

      this.m = newM;
    }

    public void Show()
    {
      for (int i = 0; i < m.GetLength(0); i++)
      {
        for (int j = 0; j < m.GetLength(1); j++)
          Console.Write("{0} ", m[i, j]);
        Console.WriteLine();
      }
    }

    public float this[int row, int col] //Индексатор для матрицы
    {
      get
      {
        if (row >= 0 && row < m.GetLength(0) && col >= 0 && col < m.GetLength(1))
          return m[row,col];
        Console.WriteLine("Попытка обращения за пределы массива.");
        return 0;
      }

      set
      {
        if (row >= 0 && row < m.GetLength(0) && col >= 0 && col < m.GetLength(1))
          m[row,col] = value;
        else
          Console.WriteLine("Попытка записи за пределами массива.");
      }
    }
  }
}
