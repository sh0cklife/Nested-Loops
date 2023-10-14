namespace _03._TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int stars = 1; stars <= row; stars += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Add this line to move to the next row
            }

        }
    }
}