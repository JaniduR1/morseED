using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace MorseRSAAlgorithms
{
    class MorseEncoder
    {
        private static Dictionary<char, string> morseConverter = new Dictionary<char, string>
            {
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...-"},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {' ', "/"},
                {'.', ".-.-.-"},
                {')', "-.--.-"},
                {'(', "-.--."},
                {',', "--..--"},
                {'-', "-....-"},
                {'=', "-....-"},
                {'"', ".-..-."},
                {':', "---..."},
            };

        public string MEncoder(string text)
        {
            List<string> output = new List<string>(text.Length);
            string str = text.ToUpper();
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    char ch = str[i];
                    if (morseConverter.TryGetValue(ch, out text))
                    {
                        string code = morseConverter[ch];
                        output.Add(code);
                    }

                }
                catch (KeyNotFoundException) 
                {
                    output.Add(" ");
                }

            }
            return string.Join(" ", output);
        }

        public string MDecoder(string morseV)
        {
            List<string> output = new List<string>(morseV.Length);
            string[] word = Regex.Split(morseV, " / ");
            for (int i = 0; i < word.Length; i++)
            {
                string sSplit = word[i];
                string[] character = Regex.Split(sSplit, " ");
                string outchar = " ";
                output.Add(outchar.ToString());

                for (int j = 0; j < character.Length; j++)
                {
                    string ch = character[j];
                    var morse = morseConverter.FirstOrDefault(x => x.Value == ch).Key;
                    output.Add(morse.ToString());

                }

            }

            return string.Join("", output);
        }
    }
}
