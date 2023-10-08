using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MyStringClass : MyClass
    {

        public string ToLowerString(ref string text)
        {
            char[] lowerAlphabet = {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            char[] upperAlphabet = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            string[] newString = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < upperAlphabet.Length; j++)
                {
                    if (text[i] == upperAlphabet[j])
                    {
                        newString[i] += lowerAlphabet[j];
                    }
                    if (text[i] == lowerAlphabet[j])
                    {
                        newString[i] += lowerAlphabet[j];
                    }
                }
            }

            text = "";
            for (int i = 0; i < newString.Length; i++) text += newString[i];
            return text;
        }
    }
}
