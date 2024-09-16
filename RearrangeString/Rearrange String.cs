public class Solution
{
  public static string RearrangeString(string str)
  {
    int[] count = new int[26];
    foreach (char c in str)
    {
      count[c - 'a']++;
    }
    
    PriorityQueue<(char, int)> pq = new(new MaxComparer());
      
    for (char c = 'a'; c <= 'z'; c++)
    {
      if (count[c - 'a'] > 0)
      {
        pq.Enqueue((c, count[c - 'a']));
      }
    }

    (char, int) prev = ('#', -1);
    string result = "";

    while (pq.Count > 0)
    {
      (char, int) curr = pq.Dequeue();
      result += curr.Item1;

      if (prev.Item2 > 0)
      {
        pq.Enqueue(prev);
      }

      curr.Item2--;
      prev = curr;
    }

    if (result.Length != str.Length)
    {
      return "Not possible";
    }

    return result;
  }

  private struct Key
  {
    public char Item1 { get; set; }
    public int Item2 { get; set; }
  }
  
  private class MaxComparer : IComparer<(char, int)>
  {
    public int Compare((char, int)x, (char, int)y) => y.Item2.CompareTo(x.Item2);
  }
  
  private class PriorityQueue<T>(IComparer<T> comparer) : SortedSet<T>(comparer)
  {
    public new int Count { get; private set; } = 0;

    public new bool Add(T item)
    {
      if (!base.Add(item))
      {
        this[item.Item2]++;
      }
      return true;
    }
    
    public new void Enqueue(T item)
    {
      base.Add(item);
      Count++;
    }

    public new T Dequeue()
    {
      if (Count > 0)
      {
        T item = Min;
        base.Remove(item);
        Count--;
        return item;
      }

      throw new InvalidOperationException("The queue is empty");
    }
  }
}

