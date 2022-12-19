using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Utility
    {
        public static bool AreDoubleArraysSame(double[] first, double[] second, double delta)
        {
            if (first == null || second == null) return false;
            if (first == second) return true;
            if (first.Length != second.Length) return false;
            if (first.Length == 0 && second.Length == 0) return true;

            for (int i = 0; i < first.Length; i++)
            {
                if (Math.Abs(first[i] - second[i]) > Math.Abs(delta)) return false;
            }

            return true;
        }
    }
}
