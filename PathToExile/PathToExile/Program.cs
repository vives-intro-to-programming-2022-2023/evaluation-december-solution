namespace PathToExile;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Path to Exile\n");

        string smallPath = "2 -> 1 -> 0";

        PathParser parser = new PathParser();

        Console.WriteLine($"Converting {smallPath} to CSV: {parser.ConvertToCsv(smallPath)}");
        Console.Write($"Converting {smallPath} to array of integers:");

        int[] values = parser.ConvertToNumbers(smallPath);
        if (values != null)
        {
            foreach (var value in values)
            {
                Console.Write($" {value}");
            }
        }

        Console.WriteLine("\n\nThank you for using Path to Exile");
    }
}
