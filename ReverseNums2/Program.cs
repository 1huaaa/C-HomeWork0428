namespace ReverseNums2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字：");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                var lines = Enumerable.Range(1, n) // 1到n的序列
                    .Select(i => new string(
                        (n - i + 1).ToString()[0], // 顯示數字字元
                        i                          // 字元重複的次數
                    ));

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
