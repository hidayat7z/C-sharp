using System;

namespace Survey
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your name:");
      var name= Console.ReadLine();

      Console.WriteLine("Enter your age:");
      var age= Console.ReadLine();

      Console.WriteLine("Enter your birth month:");
      var month= Console.ReadLine();

      Console.WriteLine("Your name: {0}",name);
      Console.WriteLine("Your age: {0}",age);
      Console.WriteLine("Your age: {0}",month);
    }
  }
