using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// deprecated (THA)
namespace TextClassification.Domain
{
    public class WordItem
    {
        string _word;
        int _occurency;

        public WordItem(string word, int occurency)
        {
            _word = word;
            _occurency = occurency;
        }

        public string GetWord()
        {
            return _word;
        }

    }
}
