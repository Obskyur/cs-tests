using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Playground
{
  internal class Exam1Tests
  {
    public static int MyFunction(double a, double b)
    {
      int x = 0, y, z;
      z = (int)(a * a);
      y = (int)(b * b);
      if (z > 100 || y > 100)
      {
        x = (int)Math.Sqrt((double)y + z);
      }
      return x;
    }
  }
}
