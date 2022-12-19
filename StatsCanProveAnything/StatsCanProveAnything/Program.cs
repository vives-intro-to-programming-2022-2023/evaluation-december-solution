namespace StatsCanProveAnything;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Stats can prove Anything.\n");

        Graph graph = new Graph();

        int[] values = { 12, 8, 5, 11, 2, 5 };

        Console.WriteLine(graph.GenerateBarPlot(values, "time [s]", "max speed [km/h]"));

        Console.WriteLine("\nThanks for using Stats can prove Anything.");
    }
}
