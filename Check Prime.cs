using System;

namespace CheckPrime
{
  class Program
  {
    static void Main(string[] args)
    {
      int flag=0;

      Console.WriteLine("Enter number:");
      int num= Convert.ToInt32(Console.ReadLine());

      for(int i=2; i<num;i++)
      {
        if(num%i==0)
        {
          flag=1;
          Console.WriteLine("NOT Prime Number");
          break;
        }
      }

      if(flag==0)
      {
        Console.WriteLine("Prime Number.");
      }
    }
  }
}
