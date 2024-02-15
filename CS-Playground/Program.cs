namespace CS_Playground;


public class Program
{
  static void Main()
  {
    Strings.Run();
    string s = "Hello World!";
    s.Replace('H', 'J');
    Console.WriteLine(s);
    s += " Again!";
    Console.WriteLine(s);

    //for (int i = 0;i++<5;) { Console.WriteLine(i); }
    //for(int i = 0;++i<5;) { Console.WriteLine(i); }

    Console.WriteLine(BitwiseOps.Multiply(40, 8));
    Console.WriteLine(BitwiseOps.Multiply(5, 315));

    //Console.WriteLine(Exam1Tests.MyFunction(33.3, 4.4));
    //Console.WriteLine(Exam1Tests.MyFunction(55.5, 6.6));

    Dog aDog = new();
    Animal anAnimal = aDog; // Overrides
    Console.WriteLine(anAnimal.Eat());
    Cat aCat = new();
    anAnimal = aCat; // Hides
    Console.WriteLine(anAnimal.Pet());
    Console.WriteLine(anAnimal.Purr());

  }
}