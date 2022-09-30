using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.Domain
{

    public class Vectors
    {
        private List<List<bool>> _vectorsInA;
        private List<List<bool>> _vectorsInB;

        public Vectors()
        {
            _vectorsInA = new List<List<bool>>();

            _vectorsInB = new List<List<bool>>();
        }

        public void AddVectorToA(List<bool> vector)
        {
            _vectorsInA.Add(vector);
        }

        public void AddVectorToB(List<bool> vector)
        {
            _vectorsInB.Add(vector);
        }
    }
}
