namespace ConsoleApp2_HW_2_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            Console.WriteLine("exercise 1");
            int x, y;
            x = 10;
            y = 5;
            Console.WriteLine(x + y);
            Console.WriteLine(x / y);

            //ex2
            Console.WriteLine("exercise 2");
            int q;
            decimal f, g, h;
            q = -1 + 4 * 6;
            Console.WriteLine(q);
            f = (35 + 5) % 7;
            Console.WriteLine(f);
            g = 14 + -4 * 6 / 11;
            Console.WriteLine(g);
            h = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(h);

            //ex3
            Console.WriteLine("exercise 3");
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);

            Console.Write("\n");

            //ex4
            Console.WriteLine("exercise 4");
            int a, b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = a * b * c;
            Console.WriteLine(d);




        }
    }
}