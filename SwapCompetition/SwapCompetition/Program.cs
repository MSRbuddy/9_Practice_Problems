namespace SwapCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Swap-Competition program!*****");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("\nEnter the No.of Rounds : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter the Words as per No.of Rounds : ");
                string[] words = Console.ReadLine().Split(' ');
                char[] arr1 = words[0].ToCharArray();
                char[] arr2 = words[1].ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                if (new string(arr1) == new string(arr2))
                {
                    Console.WriteLine("YES --> Eligible for next round.");
                }
                else
                {
                    Console.WriteLine("NO --> Not-Elgible for next round.");
                }
            }
        }
    }
}