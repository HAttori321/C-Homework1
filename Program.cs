namespace C_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("It`s wasy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            //task2
            Console.WriteLine("Enter 5 numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2 + num3 + num4 + num5);
            Console.WriteLine(num1 * num2 * num3 * num4 * num5);
            int max = num1;
            if (num2 > max) max = num2;
            if (num3 > max) max = num3;
            if (num4 > max) max = num4;
            if (num5 > max) max = num5;
            int min = num1;
            if (num2 < min) min = num2;
            if (num3 < min) min = num3;
            if (num4 < min) min = num4;
            if (num5 < min) min = num5;
            Console.WriteLine("Max number is " + max);
            Console.WriteLine("Min number is " + min);
            //task3
            Console.Write("Enter a six-digit number : ");
            string input = Console.ReadLine();
            string reversedNumber = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedNumber += input[i];
            }
            Console.WriteLine("Reversed number is " + reversedNumber);
            //task4
            Console.Write("Enter the start of the range : ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the range : ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci numbers in the range from start to end : ");
            int a = 0;
            int b = 1;
            while (a <= end)
            {
                if (a >= start)
                {
                    Console.WriteLine(a);
                }
                int temp = a;
                a = b;
                b = temp + b;
            }
            //task5
            Console.Write("Enter a number A : ")
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter a number B : ")
            int B = int.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("A is greater than B");
            }
            else if (A < B)
            {
                Console.WriteLine("A is less than B");
            }
            else
            {
                Console.WriteLine("A is equal to B");
            }
            //task6
            Console.Write("Enter length of tthe line : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the symbol : ");
            char symbol = char.Parse(Console.ReadLine());
            Console.Write("Enter the direction (right or left) : ");
            string direction = Console.ReadLine().ToLower();
            if(direction== "right")
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
            else if(direction == "left")
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = length - 1; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                Console.WriteLine("Invalid direction");
            }

        }
    }
}
