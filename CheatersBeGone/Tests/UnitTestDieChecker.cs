using CheatersBeGone;

namespace Tests;

public class UnitTestDieChecker
{
    private DieChecker checker = new DieChecker();

    [Fact]
    public void TestCountTotalRolls()
    {
        int[] first = { 53, 54, 54, 50, 57, 52 };
        Assert.Equal(320, checker.CountTotalRolls(first));

        int[] second = { 321, 342, 336, 312, 339, 336, 334, 329, 320, 330, 322, 332 };
        Assert.Equal(3953, checker.CountTotalRolls(second));

        int[] third = { 58, 36, 55, 38 };
        Assert.Equal(187, checker.CountTotalRolls(third));

        int[] fourth = { 1, 1, 1, 1, 1, 1 };
        Assert.Equal(6, checker.CountTotalRolls(fourth));
    }

    [Fact]
    public void TestDetermineThrowChances()
    {
        int[] first = { 53, 54, 54, 50, 57, 52 };
        double[] firstExpected = { 0.166, 0.169, 0.169, 0.156, 0.178, 0.163 };
        Assert.True(Utility.AreDoubleArraysSame(checker.DetermineThrowChances(first), firstExpected, 0.001));

        int[] second = { 82, 78, 89, 84, 78, 84, 86, 78 };
        double[] secondExpected = { 0.124, 0.118, 0.135, 0.127, 0.118, 0.127, 0.131, 0.118 };
        Assert.True(Utility.AreDoubleArraysSame(checker.DetermineThrowChances(second), secondExpected, 0.001));

        int[] third = { 83, 138, 116, 99, 147, 133, 81, 100, 140, 87, 106, 110 };
        double[] thirdExpected = { 0.062, 0.103, 0.087, 0.074, 0.110, 0.099, 0.060, 0.075, 0.104, 0.065, 0.079, 0.082 };
        Assert.True(Utility.AreDoubleArraysSame(checker.DetermineThrowChances(third), thirdExpected, 0.001));

        int[] fourth = { 1, 1, 1, 1, 1, 1 };
        double[] fourthExpected = { 0.167, 0.167, 0.167, 0.167, 0.167, 0.167 };
        Assert.True(Utility.AreDoubleArraysSame(checker.DetermineThrowChances(fourth), fourthExpected, 0.001));

        int[] fifth = { 1, 1, 1, 1, 1, 8 };
        double[] fifthExpected = { 0.077, 0.077, 0.077, 0.077, 0.077, 0.615 };
        Assert.True(Utility.AreDoubleArraysSame(checker.DetermineThrowChances(fifth), fifthExpected, 0.001));
    }

    //[Fact]
    //public void TestCompareArrays()
    //{
    //    double[] first = { 3.23, 1.27 };
    //    double[] second = { 0.1, 5.12, 7.20 };
    //    double[] third = { 0.1, 5.13, 7.21 };
    //    double[] fourth = { -0.1, -5.13, -7.21 };
    //    double[] empty = { };

    //    Assert.True(Utility.AreDoubleArraysSame(first, first, 0.1));
    //    Assert.True(Utility.AreDoubleArraysSame(empty, empty, 0.1));
    //    Assert.True(Utility.AreDoubleArraysSame(second, third, 0.1));
    //    Assert.True(Utility.AreDoubleArraysSame(second, third, -0.1));

    //    Assert.False(Utility.AreDoubleArraysSame(first, second, 0.1));
    //    Assert.False(Utility.AreDoubleArraysSame(second, fourth, 0.1));
    //    Assert.False(Utility.AreDoubleArraysSame(null, fourth, 0.1));
    //    Assert.False(Utility.AreDoubleArraysSame(fourth, null, 0.1));
    //    Assert.False(Utility.AreDoubleArraysSame(second, third, 0.001));
    //    Assert.False(Utility.AreDoubleArraysSame(third, fourth, 0.1));
    //}

}