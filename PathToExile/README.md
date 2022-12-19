# Path to Exile

Path to Exile is een PixelArt game gemaakt door een collega. Hij wil nu starten met het maken van een map-generator. Een onderdeel is een random generator die slierten coördinaten genereert. Hieronder vind je een voorbeeld ervan.

```
132 -> 67 -> 40 -> 13 -> 8 -> 2 -> 0
```

Dit is echter niet rechtstreeks bruikbaar in het spel en dient dus eerst te worden omgezet naar een bruikbaar formaat. We hebben nood aan volgende 2 opties:

1. Een CSV (Comma Separated Value) string voorstelling: `"132,67,40,13,8,2,0"`
2. Een array van `int` values.

Om dit te verwezenlijk dien je volgende methodes te implementeren in `PathParser`:

* `string ConvertToCsv(string path)`: Deze krijgt het origineel formaat binnen en zet dit om naar CSV waarden.
  * Merk op dat er geen spaties mogen staan in de CSV string
  * Indien `path` een lege string is of null, dien je zelf een lege string terug te geven
* `int[] ConvertToNumbers(string path)`: De krijgt het origineel formaat binnen en zit om naar een array van `int` waarden
  * Indien `path` een lege string is of null, dien je zelf een lege array van `int` terug te geven

**Puntenverdeling:** 3/5 voor `ConvertToCsv` en 2/5 voor `ConvertToNumbers`

## Verwachte Werking

De `Main()` methode voorziet reeds een kleine demo applicatie die je kan uitvoeren. Indien je alles implementeert zoals verwacht, zou je volgende output moeten krijgen van de applicatie:

```text
Welcome to Path to Exile

Converting 2 -> 1 -> 0 to CSV: 2,1,0
Converting 2 -> 1 -> 0 to array of integers: 2 1 0

Thank you for using Path to Exile
```

## Unit Tests

Dit project bevat ook unit tests. Je kan deze uitvoeren via `Test => Run All Tests`.
