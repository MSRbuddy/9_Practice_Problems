namespace PurchaseListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Purchase-List Program!*****");
            Console.WriteLine("----------------------------------------------\n");

            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> pricesCount = new Dictionary<int, int>();
            Dictionary<int, int> pricesIndex = new Dictionary<int, int>();
            for (int i = 0; i < prices.Length; i++)
            {
                int price = prices[i];
                if (pricesCount.ContainsKey(price))
                {
                    pricesCount[price]++;
                }
                else
                {
                    pricesCount.Add(price, 1);
                    pricesIndex.Add(price, i);
                }
            }
            int uniquePrice = pricesCount.FirstOrDefault(pair => pair.Value == 1).Key;
            if (uniquePrice == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(uniquePrice);
            }
            int repeatedPrice = pricesCount.FirstOrDefault(pair => pair.Value > 1).Key;
            if (repeatedPrice == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(repeatedPrice);
            }
        }
    }
}