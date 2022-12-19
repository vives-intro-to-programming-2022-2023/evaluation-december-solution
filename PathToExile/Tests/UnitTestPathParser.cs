using PathToExile;

namespace Tests;

public class UnitTestPathParser
{
    private PathParser pathParser = new PathParser();

    [Fact]
    public void TestToCsv()
    {
        Assert.Equal("5,4,3,2,1,0", pathParser.ConvertToCsv("5 -> 4 -> 3 -> 2 -> 1 -> 0"));
        Assert.Equal("104,15,11,7,2,1,0", pathParser.ConvertToCsv("104 -> 15 -> 11 -> 7 -> 2 -> 1 -> 0"));
        Assert.Equal("3232,1234,754,667,545,322,214,123,34,0", pathParser.ConvertToCsv("3232 -> 1234 -> 754 -> 667 -> 545 -> 322 -> 214 -> 123 -> 34 -> 0"));
        Assert.Equal("5436,5311,4726,3192,2105,1023,600,323,88,12,4,0", pathParser.ConvertToCsv("5436 -> 5311 -> 4726 -> 3192 -> 2105 -> 1023 -> 600 -> 323 -> 88 -> 12 -> 4 -> 0"));
        Assert.Equal("9678,9318,8114,6905,6579,5021,4600,3310,0", pathParser.ConvertToCsv("9678 -> 9318 -> 8114 -> 6905 -> 6579 -> 5021 -> 4600 -> 3310 -> 0"));
    }

    [Fact]
    public void TestSingleValues()
    {
        Assert.Equal("343", pathParser.ConvertToCsv("343"));
        Assert.Equal("6543", pathParser.ConvertToCsv("6543"));
        Assert.Equal("7675", pathParser.ConvertToCsv("7675"));
        Assert.Equal("45", pathParser.ConvertToCsv("45"));
        Assert.Equal("0", pathParser.ConvertToCsv("0"));
    }

    [Fact]
    public void TestNullAndEmptyCsvConvert()
    {
        Assert.Equal("", pathParser.ConvertToCsv(""));
        Assert.Equal("", pathParser.ConvertToCsv(null));
    }

    [Fact]
    public void TestToNumberArray()
    {
        int[] first = { 5, 4, 3, 2, 1, 0 };
        Assert.Equal(first, pathParser.ConvertToNumbers("5 -> 4 -> 3 -> 2 -> 1 -> 0"));

        int[] second = { 742, 671, 212, 127, 109, 65, 2, 0 };
        Assert.Equal(second, pathParser.ConvertToNumbers("742 -> 671 -> 212 -> 127 -> 109 -> 65 -> 2 -> 0"));

        int[] third = { 6541, 899, 837, 752, 556, 552, 443, 398, 324, 318, 167, 54, 47, 0 };
        Assert.Equal(third, pathParser.ConvertToNumbers("6541 -> 899 -> 837 -> 752 -> 556 -> 552 -> 443 -> 398 -> 324 -> 318 -> 167 -> 54 -> 47 -> 0"));

        int[] fourth = { 908, 836, 734, 669, 434, 201, 137, 110, 106, 54, 23, 11, 0 };
        Assert.Equal(fourth, pathParser.ConvertToNumbers("908 -> 836 -> 734 -> 669 -> 434 -> 201 -> 137 -> 110 -> 106 -> 54 -> 23 -> 11 -> 0"));
    }

    [Fact]
    public void TestNullAndEmptyNumberConvert()
    {
        int[] empty = new int[0];

        Assert.Equal(empty, pathParser.ConvertToNumbers(""));
        Assert.Equal(empty, pathParser.ConvertToNumbers(null));
    }
}