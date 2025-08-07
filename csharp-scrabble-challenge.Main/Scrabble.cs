using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private string _word;
        public Scrabble(string word)
        {
            //TODO: do something with the word variable
            _word = word.ToUpper();
        }

        public int score()
        {
            //TODO: score calculation code goes here
            //throw new NotImplementedException(); //TODO: Remove this line when the code has been written

            ScrabbleDictionary scrabbleDictionary = new ScrabbleDictionary();

            int sum = 0;
            int tempValue = 0;
            bool doubleLetter = false;
            bool tripleLetter = false;
            bool possibledoubleWord = false;
            bool possibletripleWord = false;
            int countIndex = 0;
            int indexStartD = -1;
            int indexStartT = -1;

            foreach (var letter in _word)
            {
                Console.WriteLine($"We are on letter: {letter}");

                if (letter == '{')
                {
                    if (countIndex == 0)
                    {
                        possibledoubleWord = true;
                        countIndex++;
                        continue;
                    }

                    doubleLetter = true;
                    indexStartD = countIndex;
                    countIndex++;
                    continue;
                }

                if (letter == '[')
                {
                    if (countIndex == 0)
                    {
                        possibletripleWord = true;
                        countIndex++;
                        continue;
                    }

                    tripleLetter = true;
                    indexStartT = countIndex;
                    countIndex++;
                    continue;
                }

                if (letter == '}')
                {
                    doubleLetter = false;

                    if (indexStartD == countIndex - 2)
                    {
                        sum += tempValue;
                    }
                    else if (possibledoubleWord == true)
                    {
                        if (countIndex == 2)
                        {
                            possibledoubleWord = false;
                            sum *= 2;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                    indexStartD = 0;
                    countIndex++;
                    continue;
                }

                if (letter == ']')
                {
                    tripleLetter = false;

                    if (indexStartT == countIndex - 2)
                    {
                        sum += tempValue * 2;
                    }
                    else if (possibletripleWord == true)
                    {
                        if (countIndex == 2)
                        {
                            possibletripleWord = false;
                            sum *= 3;
                        }
                    }
                    else
                    {
                        return 0;
                    }

                    indexStartT = 0;
                    countIndex++;
                    continue;
                }

                int value = scrabbleDictionary.LetterValue(letter);
                if (value == 0) return 0;
                sum += value;

                if ((doubleLetter || tripleLetter) == true)
                {
                    tempValue = value;
                }

                countIndex++;
            }

            if (possibledoubleWord && (_word[_word.Length-1] == '}'))
            {
                sum *= 2;
            }

            if (possibletripleWord && (_word[_word.Length - 1] == ']'))
            {
                sum *= 3;
            }

            Console.WriteLine($"Sum: {sum}");

            return sum;

        }
    }
}
