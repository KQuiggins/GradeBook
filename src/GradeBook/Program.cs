using static System.Console;

namespace GradeBook
{
    class Program
    {


        static void Main(string[] args)
        {

            var book = new Book("Ken's awesome coding book");
            
            while(true)
            {
                WriteLine("Enter a grade or enter 'q' to quit: ");
                var input = ReadLine();
                if(input == "q")
                {
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            var stats = book.GetStatistics();

            WriteLine($"The average grade is {stats.Average:N1}");
            WriteLine($"The lowest grade is {stats.Low}");
            WriteLine($"The highest grade is {stats.High}");
            WriteLine($"The letter grade is {stats.Letter}");
            



        }


    }


}
