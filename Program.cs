using System;

namespace ProjectOne
{
  class Program
  {
    static void Main(string[] args)
    {
      Student[] studentRoll = new Student[10];
      int nextStudent = 0;
      string option = obtainChoice();
      while (option != String.Empty)
      {
        switch (option)
        {
          case "1":
            Student oneStudent = new Student();
            Console.WriteLine("What´s the student name");
            oneStudent.name = Console.ReadLine();
            Console.WriteLine("What´s the student score");
            oneStudent.score = decimal.Parse(Console.ReadLine());
            studentRoll[nextStudent++] = oneStudent;
            break;

          case "2":
            // list students
            Console.WriteLine("\nName ..... Score");
            for (int i = 0; i < nextStudent; i++)
            {
              Console.WriteLine($"{studentRoll[i].name} {studentRoll[i].score}");
            }
            Console.WriteLine();
            break;

          case "3":
            // show average student score
            decimal sum = 0;
            for (int i = 0; i < nextStudent; i++)
            {
              sum += studentRoll[i].score;
            }
            Console.WriteLine($"\nAverage score is {sum / nextStudent}\n");
            break;

          default:
            throw new ArgumentOutOfRangeException();

        }
        option = obtainChoice();
      }
      Console.WriteLine("Terminated by user");

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
