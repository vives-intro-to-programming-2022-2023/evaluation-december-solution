using StatsCanProveAnything;

namespace Tests;

public class UnitTestGraph
{
    private Graph graph = new Graph();
    
    
    [Fact]
    public void TestMaximumYValue()
    {
        Assert.Equal(43, graph.MaximumYValue(new int[] { 12, 2, 31, 23, 43, 22 }));
        Assert.Equal(92, graph.MaximumYValue(new int[] { 90, 66, 11, 23, 11, 92, 32, 3, 57, 49 }));
        Assert.Equal(0, graph.MaximumYValue(new int[] { 0, 0, 0, 0, 0, 0 }));
        Assert.Equal(96, graph.MaximumYValue(new int[] { -41, -74, -18, -44, 96, 12, -83, -16, -99, 47 }));
        Assert.Equal(-69, graph.MaximumYValue(new int[] { -95, -71, -69, -77 }));
        Assert.Equal(1, graph.MaximumYValue(new int[] { 1 }));
        Assert.Equal(0, graph.MaximumYValue(new int[] { }));
        Assert.Equal(0, graph.MaximumYValue(null));
    }

    [Fact]
    public void TestRepresentValuesAsBarGraphs()
    {
        int[] values1 = { 3, 5, 0, 1, 11 };
        string[] expected1 = { "***", "*****", "", "*", "***********" };

        Assert.Equal(expected1, graph.RepresentValuesAsBarGraphs(values1, '*'));

        int[] values2 = { 1, 2, 3, 4, 5 };
        string[] expected2 = { "@", "@@", "@@@", "@@@@", "@@@@@" };

        Assert.Equal(expected2, graph.RepresentValuesAsBarGraphs(values2, '@'));
    }

    [Fact]
    public void TestGenerateBarPlot()
    {
        int[] values = { 8, 12, 16, 3, 11, 0, 12, 1 };

        string expected = @"max speed [km/h]
     ^                                        
  16 |            #                           
  15 |            #                           
  14 |            #                           
  13 |            #                           
  12 |       #    #                   #       
  11 |       #    #         #         #       
  10 |       #    #         #         #       
  9  |       #    #         #         #       
  8  |  #    #    #         #         #       
  7  |  #    #    #         #         #       
  6  |  #    #    #         #         #       
  5  |  #    #    #         #         #       
  4  |  #    #    #         #         #       
  3  |  #    #    #    #    #         #       
  2  |  #    #    #    #    #         #       
  1  |  #    #    #    #    #         #    #  
     ---------------------------------------->
                     time [s]                ".Replace("\r", "");

        Assert.Equal(expected, graph.GenerateBarPlot(values, "time [s]", "max speed [km/h]"));
    }


}