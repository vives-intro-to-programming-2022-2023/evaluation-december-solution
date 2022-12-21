using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathToExile
{
    public class PathParser
    {
        public string ConvertToCsv(string path)
        {
            // TODO - Omzetten naar CSV
            // Voorbeeld `path`: "132 -> 67 -> 40 -> 13 -> 8 -> 2 -> 0"
            // Zet dit om naar een CSV string: "132,67,40,13,8,2,0"

            // TODO - Uitzonderingen
            // Indien `path` null of leeg is, dien je zelf een lege string terug te geven





            // Eerst de uitzondering controlleren. In dat geval een lege string terug geven
            if (path == null || path.Length == 0) return "";
            
            // Makkelijkste was hier gewoon de volledige pijl met de spaties errond te replacen
            // met een komma
            return path.Replace(" -> ", ",");
        }


        public int[] ConvertToNumbers(string path)
        {
            // TODO - Omzetten naar array van getallen
            // Voorbeeld `path`: "132 -> 67 -> 40 -> 13 -> 8 -> 2 -> 0"
            // Zet dit om naar een array van int: [132, 67, 40, 13, 8, 2, 0]

            // TODO - Uitzonderingen
            // Indien `path` null of leeg is, dien je zelf een lege array terug te geven (niet null)






            // Eerst de uitzondering. Hier diende je wel te weten dat je een array van 0 elementen kan maken.
            if (path == null || path == "") return new int[0];

            // Stap 1 - Splitsen in strings op basis van de " -> "
            string[] parts = path.Split(" -> ");

            // Stap 2 - Een array maken voor elk deel dat je nu hebt (bevat telkens een getal als string)
            int[] numbers = new int[parts.Length];

            // Stap 3 - Elk getal (als string) omzetten naar een integer en op dezelfde index in de numbers array plaatsen.
            for(int i = 0; i < parts.Length; i++)
            {
                numbers[i] = Convert.ToInt32(parts[i]);
            }

            // Stap 4 - Resultaat terug geven
            return numbers;

        }


    }
}
