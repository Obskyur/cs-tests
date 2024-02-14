string s = "Hello World!";
DoReplacement(ref s);
Console.WriteLine(s);

static void DoReplacement(ref string s)
{
  s = s.Replace('H', 'J');
}