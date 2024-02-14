using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Playground
{
  internal class Strings
  {
    public static void Run()
    {
      string s = "Hello World!";
      DoReplacement(ref s);
      Console.WriteLine(s);
    }

    private static void DoReplacement(ref string s)
    {
      s = s.Replace('H', 'J');
    }
  }
}
