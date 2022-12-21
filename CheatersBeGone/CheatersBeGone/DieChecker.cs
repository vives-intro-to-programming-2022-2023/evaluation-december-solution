using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatersBeGone
{
    public class DieChecker
    {
        public int CountTotalRolls(int[] frequencyTable)
        {
            // TODO - Bepaal hoe dikwijls er met de dobbelsteen werd gegooid.



            // Niet anders dan de som bepalen van alle getallen in de array
            int sum = 0;
            foreach (int frequency in frequencyTable)
            {
                sum += frequency;
            }
            return sum;

            // Of zelfs wat sommigen al kenden
            //return frequencyTable.Sum();

        }

        public double[] DetermineThrowChances(int[] frequencyTable)
        {
            // TODO - Bepaal de kans van de dobbelsteen om het aantal ogen te werpen
            // Het resultaat dient een array van double waarden te zijn





            // Hier diende je eerst en vooral een array te maken voor de 
            // chances te bewaren. Die moet even lang zijn als de frequencyTable
            double[] throwChances = new double[frequencyTable.Length];

            // Makkelijkste was nu het totaal aantal rolls te bepalen en op te slaan
            // in een variabel
            int rolls = CountTotalRolls(frequencyTable);

            // Voor elk experiment bepaal je nu de kans
            for (int i = 0; i < frequencyTable.Length; i++) {
                throwChances[i] = 1.0 * frequencyTable[i]/rolls;
            }

            return throwChances;
        }

    }
}
