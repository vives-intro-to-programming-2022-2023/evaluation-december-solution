# Key of Spirits

Normaal maken we gebruik van een library om een voorstelling te maken van key-value pairs in een JSON formaat. Echter soms is het gewoon een mooie oefening om dit zelf te doen.

Een voorbeeld van een JSON object is het volgende

```json
{ "health": 123, "damage": 15, "speed": 23, "mana": 188 }
```

Merk op dat dit de letterlijke string is. Dus zowel de dubbele quotes `""`, de curly braces `{}`, de komma's `,`, als de dubbele punten `:` dienen aanwezig te zijn. In de realiteit maakt whitespace voor JSON niet uit. Hier echter wordt er verondersteld dat er spaties aanwezig zijn zoals aangegeven.

In deze applicatie krijg je twee arrays als input:

1. Een array van strings waarin de keys zitten, bv. `["health", "damage", "speed", "mana"]`
2. Een array van integers waarin de values zitten, bv. `[123, 15, 23, 188]`

De bedoeling is dat je deze twee arrays combineert tot een geldig JSON object.

Hiervoor dien je volgende methodes te implementeren van de class `JsonConverter`:

* `string KeyValueToString(string key, int value)`: deze methode zet een key en waarde om in het string formaat `"key": value`, waarbij de key wordt omringd door dubbele quotes.
  * Je mag er van uit gaan dat zowel `key` als `value` een geldige waarde bevatten en niet `null` of leeg zijn.
* `string ToJsonObject(string[] keys, int[] values)`: deze methode zet een combinatie van een key-array en value-array om naar een geldige JSON string voorstelling
  * Indien beide arrays niet evenveel elementen hebben mag je een leeg JSON object returnen `{}`
  * Je mag er van uit gaan dat de arrays niet `null` zijn.

**Puntenverdeling:** 1/3 voor `KeyValueToString` en 2/3 voor `ToJsonObject`

## Verwachte Werking

De `Main()` methode voorziet reeds een kleine demo applicatie die je kan uitvoeren. Indien je alles implementeert zoals verwacht, zou je volgende output moeten krijgen van de applicatie:

```text
Welcome to Key of Spirits - Your next JSON library

Here is an example of a nice JSON object:
{ "health": 123, "damage": 15, "speed": 23, "mana": 188 }

Or even an empty object:
{ "health": 123, "damage": 15, "speed": 23, "mana": 188 }

Thank you for using Key of Spirits
```

## Unit Tests

Dit project bevat ook unit tests. Je kan deze uitvoeren via `Test => Run All Tests`.
