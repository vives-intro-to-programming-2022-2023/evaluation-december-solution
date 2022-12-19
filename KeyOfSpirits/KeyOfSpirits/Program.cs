namespace KeyOfSpirits;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Key of Spirits - Your next JSON library\n");

        string[] keys = { "health", "damage", "speed", "mana" };
        int[] values = { 123, 15, 23, 188 };

        JsonConverter json = new JsonConverter();

        string jsonObject = json.ToJsonObject(keys, values);

        Console.WriteLine("Here is an example of a nice JSON object:");
        Console.WriteLine(jsonObject);

        string[] emptyKeys = { };
        int[] emptyValues = { };
        jsonObject = json.ToJsonObject(keys, values);

        Console.WriteLine("\nOr even an empty object:");
        Console.WriteLine(jsonObject);


        Console.WriteLine("\nThank you for using Key of Spirits");
    }
}
