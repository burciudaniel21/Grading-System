namespace Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a score
            Console.Write("Enter your score (0 - 100%): ");
            int score = Convert.ToInt32(Console.ReadLine());

            if(score > 100 && score < 0)
            {
                // Determine the grade using if-else statements
                string grade;
                if (score >= 70)
                {
                    grade = "First";
                }
                else if (score >= 60)
                {
                    grade = "2:1";
                }
                else if (score >= 50)
                {
                    grade = "2:2";
                }
                else if (score >= 40)
                {
                    grade = "3";
                }
                else
                {
                    grade = "Fail";
                }

                Console.WriteLine($"You have achieved a {grade}");
            }
        }
    }
}
