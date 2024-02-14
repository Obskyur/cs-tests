namespace CS_Playground;


public class Program
{
  static void Main()
  {
    Strings.Run();

    for(int i = 0;i++<5;) { Console.WriteLine(i); }
    for(int i = 0;++i<5;) { Console.WriteLine(i); }

    Console.WriteLine(BitwiseOps.Multiply(4, 8));
    Console.WriteLine(BitwiseOps.Multiply(5, 3));
  }
}