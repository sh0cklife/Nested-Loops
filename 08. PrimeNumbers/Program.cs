namespace _08._PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                bool isPrime = true;
                int divider = 2;

                while (divider < y)
                {
                    if (i == divider)
                    {
                        divider++;
                        continue;
                    }
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }
                if (isPrime)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}