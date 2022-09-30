using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Domain;

namespace TextClassification.Controller
{
    public abstract class AbstractKnowledgeBuilder
    {
        // Called to initiate the learning process

        public abstract void Train();

        // (Internal) steps in creating the Knowledge:
        // step 1
        public abstract void BuildFileLists();

        // step 2
        public abstract void BuildBagOfWords();

        // step 3
        public abstract void BuildVectors();

        // step after each training
        public abstract Knowledge GetKnowledge();
    }
}
