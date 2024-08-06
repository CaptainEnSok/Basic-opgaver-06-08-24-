namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(multiplyNumbers(1, 2, 3));
            if (fahrenheitToCelsius(1, 2, 3) <= -300)
            {
                Console.WriteLine($"Its below absolute zero!");
            }
            else
            {
                Console.WriteLine($"It is {fahrenheitToCelsius(1, 2, 3)}F outside today!");
            }

            Console.WriteLine(Calculator(1, 2, 3, 4, 5, 6));

            if (isResultSame1(true) == true)
            {
                Console.WriteLine("The result is the Same!");
            }
            else
            {
                Console.WriteLine("The result is not the same.");
            }

            if (isResultSame2(true) == true)
            {
                Console.WriteLine("The result is the Same!");
            }
            else
            {
                Console.WriteLine("The result is not the same.");
            }
            Console.WriteLine($"{cubeOf1(1, 2)}");
            Console.WriteLine($"{cubeOf2(1, 2)}");
            Console.WriteLine($"{swapNumbers(1, 2, 3)}");

        }

        static int multiplyNumbers(int value1, int value2, int value3)
        {
            // Our different values
            value1 = 2;
            value2 = 3;
            value3 = 5;

            // Values are multiplied together
            int result = value1 * value2 * value3;
            return result;

        }

        static int fahrenheitToCelsius(int fahrenheit, int celsius, int total)
        {
            Random rnd = new Random();
            celsius = 0;
            fahrenheit = 32;

            // Fahrenheit is calculated
            total = fahrenheit * celsius + fahrenheit;
            return total;
        }

        static string Calculator(int addition, int subtraction, int multiplication, int division, int value1, int value2)
        {
            value1 = 3;
            value2 = 8;

            addition = value1 + value2;
            subtraction = value1 - value2;
            multiplication = value1 * value2;
            division = value1 / value2;

            return addition.ToString() + "," + subtraction.ToString() + "," + multiplication.ToString() + "," + division.ToString();
        }

        static bool isResultSame1(bool result)
        {

            if (2 + 2 == 2 * 2)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return false;
            }
        }
        static bool isResultSame2(bool result)
        {

            if (9 / 3 == 16 - 1)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return false;
            }
        }

        static int cubeOf1(int value1, int result)
        {
            value1 = 2;
            result = value1 * value1 * value1;
            return result;
        }
        static int cubeOf2(int value1, int result)
        {
            value1 = -5;
            result = value1 * value1 * value1;
            return result;
        }
        static string swapNumbers(int value1, int value2, int tempValue)
        {
            value1 = 87;
            value2 = 45;

            string tempString = $"Before: a = {value1}, b = {value2};";
            tempValue = value2;
            value2 = value1;
            value1 = tempValue;

            string result = tempString + $" After: a = {value1}, b = {value2};";
            return result;


        }

    }
}

