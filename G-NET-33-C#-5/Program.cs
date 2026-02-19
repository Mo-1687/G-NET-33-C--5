using G_NET_33_C__5.Enums;
using System.Runtime.InteropServices;

namespace G_NET_33_C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region A1
            //Console.WriteLine("Enter the number of the day from 1 to 7");
            //string input = Console.ReadLine();
            //bool isParsed = Enum.TryParse(input, true, out Days dayNumber) &&
            //    Enum.IsDefined<Days>(dayNumber);

            //Console.WriteLine(isParsed);
            //Console.WriteLine(dayNumber);


            //switch ((int)dayNumber)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Weekend");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Workday");
            //        break;

            //    default:
            //        Console.WriteLine("Invlaid input!");
            //        break;
            //}
            #endregion

            #region A2
            //Console.WriteLine("Enter the size of your array");
            //bool isValidSize = int.TryParse(Console.ReadLine(), out int size);
            //if(isValidSize || size > 0)
            //{
            //    int[] userArray = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"Enter Element [{i}]");
            //        bool isVlaid = int.TryParse(Console.ReadLine(), out userArray[i]);
            //        while (!isVlaid)
            //        {
            //            Console.WriteLine("Invlaid number");
            //            isVlaid = int.TryParse(Console.ReadLine(), out userArray[i]);

            //        }
            //    }

            //    //Sum
            //    int sum = 0;
            //    int max = userArray[0];
            //    int min = userArray[0];
            //    foreach (var item in userArray)
            //    {

            //        sum += item;
            //        if (item > max) max = item;
            //        if (item < min) min = item;
            //    }
            //    Console.WriteLine($"Sum: {sum}");
            //    Console.WriteLine($"Max: {max}");
            //    Console.WriteLine($"Min: {min}");

            //    //Average 
            //    double average = (double)sum / size;
            //    Console.WriteLine($"Average: {average}");



            //    //Reverse 
            //    Console.WriteLine("Reversed Array: ");
            //    for (int i = userArray.Length - 1; i >= 0 ; i--)
            //    {
            //        Console.Write($"{userArray[i]} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invlaid size");
            //}
            #endregion

            #region A3
            //int[,] grades= { 
            //    {70, 60, 90, 50 },
            //    { 85, 65, 77, 90},
            //    {98, 80, 79, 60 }
            //};

            // int sum;
            //double average = 0;

            //for(int i = 0; i < grades.GetLength(0); i++)
            //{
            //    sum = 0;
            //    for(int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write($"{grades[i, j]} ");
            //        sum += grades[i, j];
            //    }
            //    average = (double)sum / grades.GetLength(1);
            //    Console.WriteLine($" The average is: {average}");
            //}

            ////The overall average 
            //sum = 0;
            //int totalNumbers = grades.GetLength(0) * grades.GetLength(1);
            //foreach(var grade in grades)
            //{
            //    sum += grade;
            //}
            //average = (double)sum / totalNumbers;
            //Console.WriteLine($"The overall average is: {average}");
            #endregion

            #region A4
            //Console.WriteLine("Enter the name of your operation: ");
            //string method = Console.ReadLine().ToLower().Trim();

            //Console.WriteLine("Enter the first number: ");
            //bool isFirstNumInt = int.TryParse(Console.ReadLine(), out int firstNum);

            //Console.WriteLine("Enter the second number: ");
            //bool isٍSecondNumInt = int.TryParse(Console.ReadLine(), out int secondNum);

            //if(isFirstNumInt && isٍSecondNumInt)
            //{
            //    string result = Calculator(firstNum, secondNum, method);
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for numbers");
            //}
            #endregion

            #region A5
            //Console.WriteLine("Enter your radius: ");
            //bool isRadiusDouble = double.TryParse(Console.ReadLine(), out double radius);
            //if(isRadiusDouble && radius > 0)
            //{
            //   var result = culateCircle(radius);
            //    Console.WriteLine($"Area: {result.area}");
            //    Console.WriteLine($"Circumference : {result.circumference}");
            //}
            //else
            //{
            //   Console.WriteLine("Invalid input for radius");

            //}
            #endregion
        }

        public static string Calculator(int x, int y, string method)
        {
            int result = 0;
            string errorMessage = null;

            if (method == "+" || method == "add")
                result = x + y;
            else if (method == "-" || method == "subtract")
                result = x - y;
            else if (method == "*" || method == "multiply")
                result = x * y;
            else if (method == "/" || method == "divide")
            {
                if (y != 0)
                    result = x / y;
                else
                    errorMessage = "Cannot divide by zero";
            }
            else
                errorMessage = "Invalid operation";

            if (string.IsNullOrEmpty(errorMessage))
                return $"Result: {result}";
            else
                return errorMessage;
        }

        public static (double area, double circumference) calculateCircle(double radius) 
        {
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            return (area, circumference);
        }


    }
}
