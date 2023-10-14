namespace _04._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countFloors = int.Parse(Console.ReadLine());
            int countRooms = int.Parse(Console.ReadLine());

            for (int floor = countFloors; floor >= 1; floor--) 
            {
                for (int room = 0; room < countRooms; room++)
                {
                    if (floor == countFloors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }

                 
                }
                Console.WriteLine();
            }
        }
    }
}