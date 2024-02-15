using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Playground
{
  internal class Animal
  {
    virtual public string Eat() => "Yummy!"; // Overriding
    public string Pet() => "*Nuzzles*"; // Hiding
  }

  internal class Dog : Animal
  {
    public override string Eat() => "Yummy woof!"; // Overriding
    public string Bark() => "Woof!";
  }

  internal class  Cat : Animal
  {
    public string Purr() => "Purr!";
    public new string Pet() => "*Preens*"; // Hiding
  }
}
