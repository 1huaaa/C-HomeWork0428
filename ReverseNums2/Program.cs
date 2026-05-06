namespace ReverseNums2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字：");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                var lines = Enumerable.Range(1, n)
                .Select(i => string.Concat(Enumerable.Repeat(
                    (n - i + 1).ToString(),
                    i
                )));

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("輸入無效，請輸入整數。");
            }
        }
    }
}
