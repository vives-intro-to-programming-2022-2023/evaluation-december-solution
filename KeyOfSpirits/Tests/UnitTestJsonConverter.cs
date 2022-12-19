using KeyOfSpirits;

namespace Tests;

public class UnitTestJsonConverter
{
    private JsonConverter json = new JsonConverter();

    [Fact]
    public void TestKeyValueToString()
    {
        Assert.Equal("\"age\": 36", json.KeyValueToString("age", 36));
        Assert.Equal("\"number_of_dogs\": 2", json.KeyValueToString("number_of_dogs", 2));
        Assert.Equal("\"cats\": 2", json.KeyValueToString("cats", 2));
        Assert.Equal("\"Fishes\": 0", json.KeyValueToString("Fishes", 0));
        Assert.Equal("\"MOTOR_CYCLES\": 2", json.KeyValueToString("MOTOR_CYCLES", 2));
        Assert.Equal("\"Wifes\": 1", json.KeyValueToString("Wifes", 1));
        Assert.Equal("\"Air-planes\": 0", json.KeyValueToString("Air-planes", 0));
    }

    [Fact]
    public void TestToJsonObject()
    {
        string[] keys1 = { "health", "damage" };
        int[] values1 = { 123, 15 };
        Assert.Equal("{ \"health\": 123, \"damage\": 15 }", json.ToJsonObject(keys1, values1));

        string[] keys2 = { "health", "damage", "speed", "mana" };
        int[] values2 = { 155, 27, 15, 50 };
        Assert.Equal("{ \"health\": 155, \"damage\": 27, \"speed\": 15, \"mana\": 50 }", json.ToJsonObject(keys2, values2));

        string[] keys3 = { "width", "height", "depth" };
        int[] values3 = { -43, 188, 0 };
        Assert.Equal("{ \"width\": -43, \"height\": 188, \"depth\": 0 }", json.ToJsonObject(keys3, values3));

        string[] keys4 = { "_x_", "_y_" };
        int[] values4 = { 12, 1095 };
        Assert.Equal("{ \"_x_\": 12, \"_y_\": 1095 }", json.ToJsonObject(keys4, values4));
    }

    [Fact]
    public void TestToJsonObjectDifferentSizeArrays()
    {
        string[] keys1 = { "health", "damage" };
        int[] values1 = { 123, 15, 23, 188 };
        Assert.Equal("{}", json.ToJsonObject(keys1, values1));

        string[] keys2 = new string[] { };
        int[] values2 = { 123, 15, 23, 188 };
        Assert.Equal("{}", json.ToJsonObject(keys2, values2));

        string[] keys3 = { "health", "damage" };
        int[] values3 = new int[] {  };
        Assert.Equal("{}", json.ToJsonObject(keys3, values3));
    }
}