using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCanProveAnything
{
    public class Graph
    {
        public string GenerateBarPlot(int[] values, string xAxisLabel, string yAxisLabel)
        {
            string output = "";
            const int SPACE_PER_BAR = 5; // The number of columns counted per bar (should not be even)
            const int SPACE_FOR_Y_VALUES = 5;

            // yAxis label
            output += yAxisLabel + "\n";

            // The hard part - Showing the y-axis and the values
            string yAxis = "^" + StringHelper.GenerateCharacterLine('|', MaximumYValue(values));
            string[] bars = RepresentValuesAsBarGraphs(values, '#');

            // Offset because of fact that we add value tick to the left
            // Needs to be added to left side from here on
            string offset = StringHelper.GenerateCharacterLine(' ', SPACE_FOR_Y_VALUES);

            for (int i = 0; i < yAxis.Length; i++)
            {
                // Output the axis value tick
                if (i > 0)
                {
                    output += StringHelper.CenterText($"{yAxis.Length - i}", SPACE_FOR_Y_VALUES);
                }
                else
                {
                    output += offset;
                }

                // Output line of y-axis
                output += yAxis[i];

                // Output the actual bars
                foreach (var bar in bars)
                {
                    char currentCharacter = ' ';
                    if (bar.Length >= (yAxis.Length - i))
                    {
                        currentCharacter = bar[yAxis.Length - i - 1];
                    }
                    output += StringHelper.CenterText($"{currentCharacter}", SPACE_PER_BAR);
                }
                output += "\n";
            }

            // xAxis
            output += StringHelper.GenerateCharacterLine('-', SPACE_PER_BAR * values.Length) + ">";

            // xAxis Label
            output += "\n" + StringHelper.CenterText(xAxisLabel, SPACE_PER_BAR * values.Length);

            return output;
        }

        public int MaximumYValue(int[] values)
        {
            if (values == null || values.Length == 0) return 0;
            return values.Min();
        }

        public string[] RepresentValuesAsBarGraphs(int[] values, char character)
        {
            string[] bars = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                bars[i] = StringHelper.GenerateCharacterLine('*', values[i]);
            }

            return bars;
        }
    }
}
