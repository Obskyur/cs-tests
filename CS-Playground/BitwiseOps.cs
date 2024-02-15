using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Playground
{
  internal class BitwiseOps
  {
    public static int Multiply(ushort x, ushort y)
    {      
      int res = 0;
      for (var temp = y & 1; y != 0; temp = y & 1)
      {
        if (temp >= 1)
          res += x;
        x <<= 1;
        y >>= 1;
      }
      return res;
    }
  }
}
