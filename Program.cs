using System;

namespace ProjectOne
{
  class Program
  {
    static void Main(string[] args)
    {
      string option = obtainChoice();
      while (option != String.Empty)
      {
        switch (option)
        {
          case "1":
            // add new student
            break;

          case "2":
            // list students
            break;

          case "3":
            // show average student score
            break;

          default:
            throw new ArgumentOutOfRangeException();

        }
        option = obtainChoice();
      }

    }

    private static string obtainChoice()
    {
      Console.WriteLine("Choose option bellow");
      Console.WriteLine("1-Add new student");
      Console.WriteLine("2-List students");
      Console.WriteLine("3-Show average score\n");
      Console.WriteLine("Enter- to exit\n");
      string option = Console.ReadLine();
      return option;
    }
  }
}
