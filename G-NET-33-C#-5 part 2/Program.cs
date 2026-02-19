namespace G_NET_33_C__5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsScore = new int[5];

            for (int i = 0; i < studentsScore.Length; i++)
            {
                Console.WriteLine($"Enter student {i + 1} score: ");
                bool isParsed = int.TryParse(Console.ReadLine(), out int score);
                studentsScore[i] = score;
                while(!isParsed || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a valid score between 0 and 100: ");
                    isParsed = int.TryParse(Console.ReadLine(), out score);
                    studentsScore[i] = score;
                }
            }

            
            for (int i = 0; i < studentsScore.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {studentsScore[i]} => Grade: {GetGrade(studentsScore[i])}");

            }

            double average = CalculateAverage(studentsScore);

            GetMinMax(studentsScore, out int min, out int max);

            Console.WriteLine($"The Average: {average}");
            Console.WriteLine($"The Highest Score: {max}");
            Console.WriteLine($"The Lowest Score: {min}");


        }

        public static Grades GetGrade(int score)
        {
            if (score >= 90)
                return Grades.A;
            else if (score >= 80)
                return Grades.B;
            else if (score >= 70)
                return Grades.C;
            else if (score >= 60)
                return Grades.D;
            else
                return Grades.F;
        }

        public static double CalculateAverage(int[] scores)
        {
            int sum = 0;
            foreach (var item in scores)
            {
                sum += item;
            }
            return (double)sum / scores.Length;
        }

        public static void GetMinMax(int[] scores, out int min, out int max)
        {
            min = scores[0];
            max = scores[0];

            foreach (var score in scores)
            {
                if (score < min)
                    min = score;
                if (score > max)
                    max = score;
            }
        }


    }
}
