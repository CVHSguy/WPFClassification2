using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Domain;

namespace TextClassification.Controller
{
    public class VectorsBuilder : AbstractVectorsBuilder
    {
        private Vectors _vectors;

        public VectorsBuilder()
        {
            _vectors = new Vectors();
        }
        public override void AddVectorToA(List<bool> vector)
        {
            _vectors.AddVectorToA(vector);
        }

        public override void AddVectorToB(List<bool> vector)
        {
            _vectors.AddVectorToB(vector);
        }

        public override Vectors GetVectors()
        {
            return _vectors;
        }
    }
}
