using System;
using System.Threading.Tasks;

namespace Task_Programming
{
  class Program
  {
    public static void Write(char c)
    {
      int i = 1000;

      while (i-- > 0)
      {
        Console.Write(c);
      }
    }

    public static void Write(object o)
    {
      int i = 1000;
      while (i-- > 0)
      {
        Console.Write(o);
      }
    }

    public static int TextLength(object o)
    {
      Console.WriteLine($"\nTask with id {Task.CurrentId} processing object {o}...");
      return o.ToString().Length;
    }

    static void Main(string[] args)
    {
      // Task.Factory.StartNew(() => Write('.'));

      // var t = new Task(() => Write('?'));
      // t.Start();

      // Task t = new Task(Write, "hello");
      // t.Start();

      // Task.Factory.StartNew(Write, 123);

      // Write('-');

      string text1 = "testing", text2 = "this";
      var task1 = new Task<int>(TextLength, text1);
      task1.Start();
      Task<int> task2 = Task.Factory.StartNew(TextLength, text2);

      Console.WriteLine($"Length of '{text1}' is {task1.Result}");
      Console.WriteLine($"Length of '{text2}' is {task2.Result}");

    }
  }
}
