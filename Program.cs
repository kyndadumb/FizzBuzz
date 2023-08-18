namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = Enumerable.Range(1,1000).ToArray();
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 1; i <= nums.Length; i++)
        {
            string str = "";  
            if (i % 3 == 0) str += "Fizz";  
            if (i % 5 == 0) str += "Buzz";  
            if (str.Length == 0) str = i.ToString();  
            
            Console.WriteLine(str); 
        }

        sw.Stop();
        Console.WriteLine($"Elapsed Time: {sw.Elapsed}");
    }
}
