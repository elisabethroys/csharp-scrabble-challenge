using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class ScrabbleDictionary
    {
        Dictionary<char, int> scrabbledictionary;
        public ScrabbleDictionary()
        {   
            scrabbledictionary = new Dictionary<char, int>();

            scrabbledictionary.Add('A', 1);
            scrabbledictionary.Add('B', 3);
            scrabbledictionary.Add('C', 3);
            scrabbledictionary.Add('D', 2);
            scrabbledictionary.Add('E', 1);
            scrabbledictionary.Add('F', 4);
            scrabbledictionary.Add('G', 2);
            scrabbledictionary.Add('H', 4);
            scrabbledictionary.Add('I', 1);
            scrabbledictionary.Add('J', 8);
            scrabbledictionary.Add('K', 5);
            scrabbledictionary.Add('L', 1);
            scrabbledictionary.Add('M', 3);
            scrabbledictionary.Add('N', 1);
            scrabbledictionary.Add('O', 1);
            scrabbledictionary.Add('P', 3);
            scrabbledictionary.Add('Q', 10);
            scrabbledictionary.Add('R', 1);
            scrabbledictionary.Add('S', 1);
            scrabbledictionary.Add('T', 1);
            scrabbledictionary.Add('U', 1);
            scrabbledictionary.Add('V', 4);
            scrabbledictionary.Add('W', 4);
            scrabbledictionary.Add('X', 8);
            scrabbledictionary.Add('Y', 4);
            scrabbledictionary.Add('Z', 10);

            /*foreach (KeyValuePair<char, int> kvp in scrabbledictionary)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }*/

        }

        public int LetterValue(char letter)
        {
            if (letter >= 65 && letter <= 90)
            {
                int value = 0;
                value = scrabbledictionary[letter];
                return value;
            }

            return 0;
        }
    }
}
