namespace HvurlqneNaZarZadacha8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int throwsCount = 100000;

            int[] results = RollDice(throwsCount);

            Console.WriteLine($"Брой хвърляния: {throwsCount}\n");

            for (int i = 0; i < results.Length; i++)
            {
                double probability = (double)results[i] / throwsCount;
                Console.WriteLine(
               $"Число {i + 1}: {results[i]} пъти -> Вероятност: {probability:P2}" );
            }
            Console.ReadLine();
        }
        static int[] RollDice(int throwsCount)
        {
            int[] counts = new int[6];
            Random random = new Random();

            for (int i = 0; i < throwsCount; i++)
            {
                int roll = random.Next(1, 7);
                counts[roll - 1]++;
            }
            return counts;
        }
    }
}

