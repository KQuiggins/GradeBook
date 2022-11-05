using static System.Console;

namespace GradeBook
{
    class Program
    {


        static void Main(string[] args)
        {

            var book = new DiskBook("Ken's awesome coding book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);
            var stats = book.GetStatistics();

            
            WriteLine($"For the book named {book.Name}");
            WriteLine($"The average grade is {stats.Average:N1}");
            WriteLine($"The lowest grade is {stats.Low}");
            WriteLine($"The highest grade is {stats.High}");
            WriteLine($"The letter grade is {stats.Letter}");




        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                WriteLine("Enter a grade or enter 'q' to quit: ");
                var input = ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {

                    var grade = double.Parse(input);
                    book.AddGrade(grade);


                }
                catch (ArgumentException ex)
                {
                    WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            WriteLine("A grade was added");
        }


    }


}
