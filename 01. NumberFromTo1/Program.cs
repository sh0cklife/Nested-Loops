namespace _01._NumberFromTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Console.WriteLine(n);
                --n;
            }
        }
    }
}