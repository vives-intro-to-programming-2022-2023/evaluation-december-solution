using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KeyOfSpirits
{
    public class JsonConverter
    {
        public string KeyValueToString(string key, int value)
        {
            // TODO - Converteer de key en value in een string volgens volgend formaat:
            // "key": value

            // Je mag er van uit gaan dat `key` en `value` steeds geldige waarden bevatten.



            // Optie 1 (indien je niet wist hoe de dubbele quotes escapen:
            // return '"' + key + '"' + ": " + value;

            // Optie 2 is de properste
            return $"\"{key}\": {value}";
        }

        public string ToJsonObject(string[] keys, int[] values)
        {
            // TODO - Zet de combinatie `keys` en `values` om naar een geldig JSON object volgens volgende
            // formaat: { "health": 123, "damage": 15, "speed": 23, "mana": 188 }

            // TODO - Indien de lengtes van `keys` en `values` verschillend zijn, dien je een leeg JSON
            // object te returnen onder vorm van: {}




            // Makkelijkste is eerst controlleren of de lengtes verschillen,
            // dit is namelijk de "uitzonderlijke" situatie
            if (keys.Length != values.Length) return "{}";

            // Dan output opbouwen
            string output = "";
            for (int i = 0; i < keys.Length; i++)
            {
                // Hier heb je 2 opties. Of eerst de komma of komma erna
                if (i > 0) output += ", ";
                output += KeyValueToString(keys[i], values[i]);
            }

            // Op laatste de curly braces errond
            return $"{{ {output} }}";

            // Of indien je niet wist hoe te curly braces te verkrijgen
            //return "{ " + output + " }";

        }
    }
}
