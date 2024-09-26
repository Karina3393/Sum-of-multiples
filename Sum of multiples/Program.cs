namespace Sum_of_multiples
{
    internal class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Введіть рівень:");
            int level = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Введіть базові значення магічних предметів через кому:");
            List<int> baseValues = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            HashSet<int> multiples = new HashSet<int>();

            
            foreach (int baseValue in baseValues)
            {
                for (int i = baseValue; i < level; i += baseValue)
                {
                    multiples.Add(i); 
                }
            }

            int totalEnergyPoints = multiples.Sum();

            Console.WriteLine($"Гравець заробив {totalEnergyPoints} очок енергії.");
        }
    }
}
