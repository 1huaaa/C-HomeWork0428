namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串以逗號分隔的字串：");
            string input = Console.ReadLine();
            string[] sArray = input.Split(',');

            IEnumerable<string> reversedData = sArray.Reverse();
            string result = string.Join(",", reversedData);

            Console.WriteLine("結果：" + result);
            Console.ReadLine();
        }
    }
}
