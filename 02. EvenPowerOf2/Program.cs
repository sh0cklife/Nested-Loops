namespace _02._EvenPowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i += 2)
            {
                double powerOfTwo = Math.Pow(2, i);
                Console.WriteLine(powerOfTwo);
            }

        }
    }
}