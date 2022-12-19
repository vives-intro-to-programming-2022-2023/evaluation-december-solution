namespace CheatersBeGone;
class Program
{
    static string ChancesToString(double[] chances)
    {
        if (chances == null) return "";
        string output = "";
        foreach (var value in chances)
        {
            output += string.Format("{0:N3}%", value) + " ";
        }
        return output;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Official Die Validation App\n");

        DieChecker checker = new DieChecker();

        int[] die1 = { 43, 43, 43, 44, 42, 45 };
        Console.Write("Die 1 throw chances: ");
        Console.WriteLine(ChancesToString(checker.DetermineThrowChances(die1)));

        int[] die2 = { 13, 27, 28, 25, 25, 45 };
        Console.Write("Die 2 throw chances: ");
        Console.WriteLine(ChancesToString(checker.DetermineThrowChances(die2)));

        Console.WriteLine("\nThank you for using 'Cheaters be Gone'");
    }
}
