namespace Procent_16082022
{
    public class Program
    { 
        static void Main(string[] args)
        {

            do
            { 
                Console.Clear();
                int[] outArray = Input_Number();

                double [] resultArray = Calculate(outArray);
                Print_Result(outArray,resultArray);

                Console.WriteLine("Want to try again(Y/N) ");

            }while (Console.ReadKey().Key== ConsoleKey.Y);
        }
        static int[]? Input_Number()
        {
          

            Console.Write("Enter first number: ");
            string? string1 = Console.ReadLine();
            bool diditfail1 = int.TryParse(string1, out int num1);
               

            Console.Write("Enter second number: ");
            string? string2 = Console.ReadLine();
            bool diditfail2 = int.TryParse(string2, out int num2);

            if (diditfail1 == true && diditfail2 == true)
            {
                int[] inputArray = new int[2];
                int[] numArray1 = { num1, num2 };
                return numArray1;
            }
            return null;

        }
        static double[] Calculate(int[] inputArray)
        {

            int num1 = inputArray[0];
            int num2 = inputArray[1];
            double result1 = num1 * num2 / 100d;
            double result2 = (double)num2 * num1 / 100;
            double[] resultArray = { result1, result2 };
            return resultArray;

        }
        static void Print_Result(int [] iA,double[] iR)
        {
            Console.WriteLine($"{iA[0]}% of {iA[1]} equals {iR[0]}");

            Console.WriteLine($"{iA[1]}% of {iA[0]} equals {iR[1]}");
        }
    }
}