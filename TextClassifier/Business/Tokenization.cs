using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.Business
{

    public class Tokenization
    {
        private const int SMALLESTWORDLENGTH = 3;

        public static List<string> Tokenize(string originalText)
        {
            List<string> words = new List<string>();
            String [] tokens = originalText.Split(' ');

            
            foreach (string token in tokens)
            {
                
                if (IsAShortWord(token)){
                    // skip
                }
                else
                {
                    string cleanWord = RemovePunctuation(token);
                    cleanWord = cleanWord.ToLower();
                    words.Add(cleanWord);
                }
            }
            return words;
        }
        public static bool IsAShortWord(string token)
        {
            if (token.Length < SMALLESTWORDLENGTH)
            {
                return true;
            }
            return false;
        }

        public static string RemovePunctuation(string token)
        {
            token = token.Trim();
            char[] punctuations = {'.', ',', '"', '?','\n'};
            
            for (int i = 0; i < punctuations.Length; i++)
            {
                string ch = punctuations[i].ToString();
                if (token.StartsWith(ch))
                {
                    return token.Substring(1);
                }
                else if (token.EndsWith(ch))
                {
                    return token.Substring(0, token.Length - 1);
                }
            }
            return token;
        }
    }
}
