using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.Domain
{
    // composite object - the complete "brain" of the app
    public class Knowledge
    {
        private FileLists _fileLists;
        private BagOfWords _bagOfWords;
        private Vectors _vectors;

        public Knowledge()
        {

        }

        public BagOfWords GetBagOfWords()
        {
            return _bagOfWords;
        }
        public FileLists GetFileLists()
        {
            return _fileLists;
        }

        public Vectors GetVectors()
        {
            return _vectors;
        }
        public void SetFileLists(FileLists fileLists)
        {
            _fileLists = fileLists;
        }

        public void SetBagOfWords(BagOfWords bagOfWords)
        {
            _bagOfWords = bagOfWords;
        }

        public void SetVectors(Vectors vectors)
        {
            _vectors = vectors;
        }

    }
}
